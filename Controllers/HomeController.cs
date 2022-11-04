using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PE.Models;
using PE.Models.paging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly shopPEContext _context;
        public HomeController(ILogger<HomeController> logger, shopPEContext context)
        {
            _logger = logger; _context = context;
        }

        public async Task<IActionResult> Index(string sortOrder, string searchString, string searchCate, string currentFilter, int? pageNumber)
        {

            /////filter

            ViewData["CurrentSort"] = sortOrder;

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

            ////home flag
            var products = from s in _context.Products where s.HomeFlag.Equals(true)
                           select s;

            //best seller
            var productseller = (from s in _context.Products where s.BestSellers.Equals(true)
                           select s).Take(3);
            ViewData["bestSeller"] = new List<Product>(productseller);

            //recently add
            var productrecent = (from s in _context.Products
                                 orderby s.DateCreated descending
                                 select s).Take(3);
            ViewData["newPro"] = new List<Product>(productrecent);



            //search
            //name
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.ProductName.Contains(searchString));
            }

            //category
            if (!String.IsNullOrEmpty(searchCate))
            {
                products = products.Where(p => p.Cat.CatName.Contains(searchCate));
            }
            //sort


            int pageSize = 8;

            //result
            return View(await PaginatedList<Product>.CreateAsync(products.AsNoTracking().Include(c => c.Cat), pageNumber ?? 1, pageSize));

        }

        ////public IActionResult Index()
        ////{
        ////    return View();
        ////}

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
