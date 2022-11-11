using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PE.Helpers;
using PE.Models;
using PE.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PE.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {

        private readonly shopPEContext _context;
        public INotyfService _notyfService { get; }


        public AccountsController(shopPEContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidatePhone(string phone)
        {
            try
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Phone.ToLower() == phone.ToLower());
                if (customer != null)
                {
                    return Json(data: "Phone : " + phone + "is used");

                }
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ValidateEmail(string email)
        {
            try
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.ToLower() == email.ToLower());
                if (customer != null)
                {
                    return Json(data: "Phone : " + email + "is used <br />");

                }
                return Json(data: true);
            }
            catch
            {
                return Json(data: true);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("register.html", Name = "Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register.html", Name = "Register")]
        public async Task<IActionResult> Register(RegisterVM customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string salt = Utilites.GetRandomKey();
                    Customer tk = new Customer
                    {
                        FullName = customer.FullName,
                        Phone = customer.Phone.Trim().ToLower(),
                        Email = customer.Email.Trim().ToLower(),
                        Password = customer.Password,
                        Active = true,
                        Salt = salt,
                        CreateDate = System.DateTime.Now
                    };
                    _context.Add(tk);
                    _notyfService.Success("Register Success");
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index", "Home");

                    //try
                    //{
                    //    _context.Add(tk);
                    //    _notyfService.Success("Register Success");
                    //    await _context.SaveChangesAsync();

                    //    //save session customer
                    //    HttpContext.Session.SetString("CustomerId", customer.CustomerId.ToString());
                    //    var customerID = HttpContext.Session.GetString("CustomerId");

                    //    //identity
                    //    var claims = new List<Claim>
                    //    {
                    //        new Claim(ClaimTypes.Name, customer.FullName),
                    //        new Claim("CustomerId", customer.CustomerId.ToString())
                    //    };
                    //    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    //    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    //    await HttpContext.SignInAsync(claimsPrincipal);
                    //    _notyfService.Success("Login Success");

                    //    return RedirectToAction("Dashboard", "Accounts");
                    //}
                    //catch
                    //{
                    //    return RedirectToAction("Register", "Accounts");
                    //}
                }
                else
                {
                    return View(customer);
                }
            }
            catch
            {
                return View(customer);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("login.html", Name = "Login")]
        public IActionResult Login(string returnUrl = null)
        {
            var userId = HttpContext.Session.GetString("CustomerId");
            if (userId != null)
            {

                return RedirectToAction("Dashboard", "Accounts");
            }
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login.html", Name = "Login")]
        public async Task<IActionResult> Login(LoginViewModel customer, string returnUrl = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isEmail = Utilites.IsValidEmail(customer.Email);
                    if (!isEmail)
                    {
                        return View(customer);
                    }

                    var cus = _context.Customers.AsNoTracking().SingleOrDefault(x => x.Email.Trim().ToLower() == customer.Email.Trim().ToLower());
                    if (cus == null)
                    {
                        return RedirectToAction("Register");
                    }

                    string pass = customer.Password;
                    if (cus.Password != customer.Password)
                    {
                        _notyfService.Error("Not Correct");
                        return View(customer);
                    }

                    //check if account is disable
                    if (cus.Active == false)
                    {
                        return RedirectToAction("Notificate", "Accounts");
                    }

                    //save session customer
                    HttpContext.Session.SetString("CustomerId", cus.CustomerId.ToString());
                    var customerID = HttpContext.Session.GetString("CustomerId");

                    //identity
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, cus.FullName),
                            new Claim("CustomerId", cus.CustomerId.ToString())
                        };
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "login");
                    ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(claimsPrincipal);
                    _notyfService.Success("Login Success");
                    //return RedirectToAction("Shipping", "Accounts");
                    return RedirectToAction("Dashboard", "Accounts");

                }
            }
            catch
            {
                return RedirectToAction("Register", "Accounts");
            }
            return View(customer);
        }

        [HttpGet]
        [Route("logout.html", Name = "Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            HttpContext.Session.Remove("CustomerId");
            return RedirectToAction("Index", "Home");
        }


        [Route("dashboard.html", Name = "Dashboard")]
        public IActionResult Dashboard()
        {
            var userId = HttpContext.Session.GetString("CustomerId");
            if (userId != null)
            {
                var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(userId));
                if (customer != null)
                {
                    var lsOrder = _context.Orders.AsNoTracking()
                        .Where(x => x.CustomerId == customer.CustomerId)
                        .OrderByDescending(x => x.OrderDate).ToList();
                    ViewBag.lsOrd = lsOrder;
                    return View(customer);
                }
            }
            return RedirectToAction("Login");
        }

        //[Route("order.html", Name = "Order")]
        //public IActionResult Order()
        //{
        //    var userId = HttpContext.Session.GetString("CustomerId");

        //    var customer = _context.Customers.AsNoTracking().SingleOrDefault(x => x.CustomerId == Convert.ToInt32(userId));

        //    var lsOrder = _context.Orders.AsNoTracking()
        //        .Where(x => x.CustomerId == customer.CustomerId)
        //        .OrderByDescending(x => x.OrderDate).ToList();

        //    ViewBag.lsOrd = lsOrder;

        //    return View(customer);
        //}
        public IActionResult Shipping()
        {
            return View();
        }
    }
}
