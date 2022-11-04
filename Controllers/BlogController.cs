using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PE.Helpers;
using PE.Models;
using PE.Models.paging;
namespace PE.Controllers
{
    public class BlogController : Controller
    {

        private readonly shopPEContext _context;


        public BlogController(shopPEContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber)
        {
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
            var pages = from s in _context.Pages
                        select s;

            //search
            //name
            if (!String.IsNullOrEmpty(searchString))
            {
                pages = pages.Where(p => p.PageName.Contains(searchString));
            }

            int pageSize = 5;

            //result
            return View(await PaginatedList<Page>.CreateAsync(pages.AsNoTracking(), pageNumber ?? 1, pageSize));

        }

        // GET: Admin/AdminPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var page = await _context.Pages
                .FirstOrDefaultAsync(m => m.PageId == id);
            if (page == null)
            {
                RedirectToAction("Index");
            }

            return View(page);
        }
    }
}
