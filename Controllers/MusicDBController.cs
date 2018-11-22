using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class MusicDBController : Controller
    {
        readonly MusicDBContext _context;

        public MusicDBController(MusicDBContext context)
        {
            _context = context;
        }

        // GET: MusicDB
        public async Task<IActionResult> Index()
        {
            return View(await _context.Album.ToListAsync());
        }

        // GET: MusicDB/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicDB = await _context.Album
                .FirstOrDefaultAsync(m => m.ID == id);
            if (musicDB == null)
            {
                return NotFound();
            }

            return View(musicDB);
        }

        // GET: MusicDB/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MusicDB/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Album,Artist")] MusicDB musicDB)
        {
            if (ModelState.IsValid)
            {
                _context.Add(musicDB);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musicDB);
        }

        // GET: MusicDB/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicDB = await _context.Album.FindAsync(id);
            if (musicDB == null)
            {
                return NotFound();
            }
            return View(musicDB);
        }

        // POST: MusicDB/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Album,Artist")] MusicDB musicDB)
        {
            if (id != musicDB.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musicDB);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicDBExists(musicDB.ID))
                    {
                        return NotFound();
                    }
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(musicDB);
        }

        // GET: MusicDB/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musicDB = await _context.Album
                .FirstOrDefaultAsync(m => m.ID == id);
            if (musicDB == null)
            {
                return NotFound();
            }

            return View(musicDB);
        }

        // POST: MusicDB/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var musicDB = await _context.Album.FindAsync(id);
            _context.Album.Remove(musicDB);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        bool MusicDBExists(int id)
        {
            return _context.Album.Any(e => e.ID == id);
        }
    }
}
