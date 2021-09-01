using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Covid19WebApp.Data;
using Covid19WebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace Covid19WebApp.Controllers
{
    public class CovidController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CovidController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Covid
        public async Task<IActionResult> Index()
        {
            return View(await _context.Covid.ToListAsync());
        }

        // GET: Covid/ShowSearchForm
        public async Task<IActionResult> ShowSearchForm()
        {
            return View();
        }

        // POST: Covid/ShowSearchResults
        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            return View("Index",await _context.Covid.Where(j => j.ImePrezime.Contains(SearchPhrase)).ToListAsync());
        }

        // GET: Covids/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covid = await _context.Covid
                .FirstOrDefaultAsync(m => m.Id == id);
            if (covid == null)
            {
                return NotFound();
            }

            return View(covid);
        }

        // GET: Covid/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Covid/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Oib,ImePrezime,rezultatiTesta")] Covid covid)
        {
            if (ModelState.IsValid)
            {
                _context.Add(covid);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(covid);
        }

        // GET: Covid/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covid = await _context.Covid.FindAsync(id);
            if (covid == null)
            {
                return NotFound();
            }
            return View(covid);
        }

        // POST: Covid/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Oib,ImePrezime,rezultatiTesta")] Covid covid)
        {
            if (id != covid.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(covid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CovidExists(covid.Id))
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
            return View(covid);
        }

        // GET: Covid/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var covid = await _context.Covid
                .FirstOrDefaultAsync(m => m.Id == id);
            if (covid == null)
            {
                return NotFound();
            }

            return View(covid);
        }

        // POST: Covids/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var covid = await _context.Covid.FindAsync(id);
            _context.Covid.Remove(covid);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CovidExists(int id)
        {
            return _context.Covid.Any(e => e.Id == id);
        }
    }
}
