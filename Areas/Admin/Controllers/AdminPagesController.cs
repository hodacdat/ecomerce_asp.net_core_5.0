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

namespace PE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPagesController : Controller
    {
        private readonly shopPEContext _context;

        public INotyfService _notyfService { get; }

        public AdminPagesController(shopPEContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }

        // GET: Admin/AdminPages
        public async Task<IActionResult> Index( string searchString, string currentFilter, int? pageNumber)
        {
            //for(int i = 0; i<20; i++)
            //{
            //    Page page = new Page();
            //    page.Title = "tin moi";
            //    page.PageName = "tin moi";
            //    page.Published = true;
            //    page.CreateDate = DateTime.Now;
            //    page.Contents = "tin moi tin moi tin moi";
            //    _context.Add(page);
            //    _context.SaveChanges();
            //}
            

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
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages
                .FirstOrDefaultAsync(m => m.PageId == id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // GET: Admin/AdminPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminPages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PageId,PageName,Contents,Thumb,Published,Title,MetaDesc,MetalKey,Alias,CreateDate,Ordering")] Page page, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {
                page.Title = Utilites.ToTitleCase(page.Title);
                if (fThumb != null)
                {
                    string extentions = Path.GetExtension(fThumb.FileName);
                    string image = Utilites.SEOUrl(page.PageName) + extentions;
                    page.Thumb = await Utilites.UploadFile(fThumb, @"pages", image.ToLower());
                }
                if (string.IsNullOrEmpty(page.Thumb)) page.Thumb = "default.jpg";
                page.Alias = Utilites.SEOUrl(page.PageName);
                page.CreateDate = DateTime.Now;

                _context.Add(page);
                _notyfService.Success("Success");
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(page);
        }

        // GET: Admin/AdminPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }
            return View(page);
        }

        // POST: Admin/AdminPages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PageId,PageName,Contents,Thumb,Published,Title,MetaDesc,MetalKey,Alias,CreateDate,Ordering")] Page page, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (id != page.PageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    page.Title = Utilites.ToTitleCase(page.Title);
                    if (fThumb != null)
                    {
                        string extentions = Path.GetExtension(fThumb.FileName);
                        string image = Utilites.SEOUrl(page.PageName) + extentions;
                        page.Thumb = await Utilites.UploadFile(fThumb, @"pages", image.ToLower());
                    }
                    if (string.IsNullOrEmpty(page.Thumb)) page.Thumb = "default.jpg";
                    page.Alias = Utilites.SEOUrl(page.PageName);
                    page.CreateDate = DateTime.Now;

                    _context.Update(page);
                    _notyfService.Success("Success");
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PageExists(page.PageId))
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
            return View(page);
        }

        // GET: Admin/AdminPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var page = await _context.Pages
                .FirstOrDefaultAsync(m => m.PageId == id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // POST: Admin/AdminPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var page = await _context.Pages.FindAsync(id);
            _context.Pages.Remove(page);
            _notyfService.Success("Success");
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PageExists(int id)
        {
            return _context.Pages.Any(e => e.PageId == id);
        }
    }
}
