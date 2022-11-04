using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using PE.Helpers;
using PE.Models;
using PE.Models.paging;

namespace PE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCustomersController : Controller
    {
        private readonly shopPEContext _context;

        public INotyfService _notyfService { get; }

        public AdminCustomersController(shopPEContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminCustomers
        public async Task<IActionResult> Index(string sortOrder, string searchString, string currentFilter, int? pageNumber)
        {

            /////filter
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["AddressSortParm"] = String.IsNullOrEmpty(sortOrder) ? "address_desc" : "";
            ViewData["LocationSortParm"] = String.IsNullOrEmpty(sortOrder) ? "location_desc" : "";

            //paging
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            ////
            var customers = from s in _context.Customers
                           select s;

            //search
            //name
            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(p => p.FullName.Contains(searchString));
            }
            //sort
            switch (sortOrder)
            {
                case "name_desc":
                    customers = customers.OrderByDescending(s => s.FullName);
                    break;
                case "address_desc":
                    customers = customers.OrderByDescending(s => s.Address);
                    break;
                case "location_desc":
                    customers = customers.OrderByDescending(s => s.Location.Name);
                    break;
                
                default:
                    customers = customers.OrderBy(s => s.CustomerId);
                    break;
            }

            int pageSize = Utilites.PAGE_SIZE;

            //result
            return View(await PaginatedList<Customer>.CreateAsync(customers.AsNoTracking().Include(l => l.Location), pageNumber ?? 1, pageSize));

        }

        // GET: Admin/AdminCustomers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(l => l.Location)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Admin/AdminCustomers/Create
        public IActionResult Create()
        {
            ViewData["LocaId"] = new SelectList(_context.Locations, "LocationId", "Name");
            return View();
        }

        // POST: Admin/AdminCustomers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FullName,Birthday,Avatar,Address,Email,Phone,LocationId,District,Ward,CreateDate,Password,Salt,LastLogin,Active")] Customer customer, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                if (fThumb != null)
                {
                    string extentions = Path.GetExtension(fThumb.FileName);
                    string image = Utilites.SEOUrl(customer.FullName) + extentions;
                    customer.Avatar = await Utilites.UploadFile(fThumb, @"customers", image.ToLower());
                }
                if (string.IsNullOrEmpty(customer.Avatar)) customer.Avatar = "default.jpg";
                customer.CreateDate = DateTime.Now;

                _context.Add(customer);
                await _context.SaveChangesAsync();
                _notyfService.Success("Success");
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocaId"] = new SelectList(_context.Locations, "LocationId", "Name", customer.LocationId);
            return View(customer);
        }

        // GET: Admin/AdminCustomers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["LocaId"] = new SelectList(_context.Locations, "LocationId", "Name", customer.LocationId);
            return View(customer);
        }

        // POST: Admin/AdminCustomers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FullName,Birthday,Avatar,Address,Email,Phone,LocationId,District,Ward,CreateDate,Password,Salt,LastLogin,Active")] Customer customer, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (fThumb != null)
                    {
                        string extentions = Path.GetExtension(fThumb.FileName);
                        string image = Utilites.SEOUrl(customer.FullName) + extentions;
                        customer.Avatar = await Utilites.UploadFile(fThumb, @"customers", image.ToLower());
                    }
                    if (string.IsNullOrEmpty(customer.Avatar)) customer.Avatar = "default.jpg";
                    customer.CreateDate = DateTime.Now;

                    _context.Update(customer);
                    _notyfService.Success("Success");
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocaId"] = new SelectList(_context.Locations, "LocationId", "Name", customer.LocationId);
            return View(customer);
        }

        // GET: Admin/AdminCustomers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(l => l.Location)
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Admin/AdminCustomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            _notyfService.Success("Success");
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }

        private async Task<PagingCustomer> GetCustomerList(int currentPage)
        {
            int maxRowPerPage = 5;
            PagingCustomer pagingCustomer = new PagingCustomer();

            pagingCustomer.CustomerList= await (from customer in _context.Customers select customer)
                .OrderBy(x => x.CustomerId)
                .Include(x => x.Location)
                .Skip((currentPage - 1) * maxRowPerPage)
                .Take(maxRowPerPage)
                .ToListAsync();

            double pageCount = (double)((decimal)_context.Customers.Count()/Convert.ToDecimal(maxRowPerPage));

            pagingCustomer.PageCount = (int)Math.Ceiling(pageCount);
            pagingCustomer.CurrentPageIndex = currentPage;
            return pagingCustomer;
        }
    }
}
