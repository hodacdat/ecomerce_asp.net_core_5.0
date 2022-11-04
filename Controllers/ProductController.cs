using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PE.Helpers;
using PE.Models;
using PE.Models.paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PE.Controllers
{
    public class ProductController : Controller
    {

        private readonly shopPEContext _context;

        public ProductController(shopPEContext context)
        {
            _context = context;
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

            ////
            var products = from s in _context.Products
                           select s;

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

        // GET: Admin/AdminProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Cat)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            var productSameCate = (from s in _context.Products
                                 where s.Cat.Equals(product.Cat) && s.ProductId != product.ProductId
                                 select s).Take(3);

            ViewData["sameCat"] = new List<Product>(productSameCate);

            //recent
            //recently add
            var productrecent = (from s in _context.Products
                                 orderby s.DateCreated descending
                                 select s).Take(3);
            ViewData["newPro"] = new List<Product>(productrecent);

            //best seller
            var productseller = (from s in _context.Products
                                 where s.BestSellers.Equals(true) && s.ProductId != product.ProductId
                                 select s).Take(3);
            ViewData["bestSeller"] = new List<Product>(productseller);

            return View(product);
        }
    }
}
