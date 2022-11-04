using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PE.Helpers;
using PE.Models;
using PE.Models.paging;

namespace PE.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLocationsController : Controller
    {
        private readonly shopPEContext _context;

        public AdminLocationsController(shopPEContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminLocations
        public async Task<IActionResult> Index(string sortOrder, string searchString, string searchCate, string currentFilter, int? pageNumber)
        {
            /////filter
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["Type"] = String.IsNullOrEmpty(sortOrder) ? "Type_desc" : "";
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
            var locations = from s in _context.Locations
                           select s;

            //search
            //name
            if (!String.IsNullOrEmpty(searchString))
            {
                locations = locations.Where(p => p.Name.Contains(searchString));
            }

            //category
            if (!String.IsNullOrEmpty(searchCate))
            {
                locations = locations.Where(p => p.Type.Contains(searchCate));
            }
            //sort
            switch (sortOrder)
            {
                case "name_desc":
                    locations = locations.OrderByDescending(s => s.Name);
                    break;
                case "Type_desc":
                    locations = locations.OrderByDescending(s => s.Type);
                    break;
                default:
                    locations = locations.OrderBy(s => s.LocationId);
                    break;
            }

            int pageSize = Utilites.PAGE_SIZE;

            return View(await PaginatedList<Location>.CreateAsync(locations.AsNoTracking(), pageNumber ?? 1, pageSize));

        }

        // GET: Admin/AdminLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Locations
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // GET: Admin/AdminLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminLocations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationId,Name,Type,Slug,NameWithType,PathWithType,ParentCode,Levels")] Location location)
        {
            if (ModelState.IsValid)
            {
                _context.Add(location);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(location);
        }

        // GET: Admin/AdminLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Locations.FindAsync(id);
            if (location == null)
            {
                return NotFound();
            }
            return View(location);
        }

        // POST: Admin/AdminLocations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationId,Name,Type,Slug,NameWithType,PathWithType,ParentCode,Levels")] Location location)
        {
            if (id != location.LocationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(location);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationExists(location.LocationId))
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
            return View(location);
        }

        // GET: Admin/AdminLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var location = await _context.Locations
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (location == null)
            {
                return NotFound();
            }

            return View(location);
        }

        // POST: Admin/AdminLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var location = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationExists(int id)
        {
            return _context.Locations.Any(e => e.LocationId == id);
        }
    }
}
