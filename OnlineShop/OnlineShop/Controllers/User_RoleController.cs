using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class User_RoleController : Controller
    {
        private readonly MvcContext _context;

        public User_RoleController(MvcContext context)
        {
            _context = context;
        }

        // GET: User_Role
        public async Task<IActionResult> Index()
        {
            var mvcContext = _context.User_Roles.Include(u => u.Role).Include(u => u.User);
            return View(await mvcContext.ToListAsync());
        }

        // GET: User_Role/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Role = await _context.User_Roles
                .Include(u => u.Role)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user_Role == null)
            {
                return NotFound();
            }

            return View(user_Role);
        }

        // GET: User_Role/Create
        public IActionResult Create()
        {
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "name");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "fullName");
            return View();
        }

        // POST: User_Role/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,RoleId")] User_Role user_Role)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user_Role);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Id", user_Role.RoleId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", user_Role.UserId);
            return View(user_Role);
        }

        // GET: User_Role/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Role = await _context.User_Roles.FindAsync(id);
            if (user_Role == null)
            {
                return NotFound();
            }
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "name", user_Role.RoleId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "fullName", user_Role.UserId);
            return View(user_Role);
        }

        // POST: User_Role/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,RoleId")] User_Role user_Role)
        {
            if (id != user_Role.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user_Role);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!User_RoleExists(user_Role.Id))
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
            ViewData["RoleId"] = new SelectList(_context.Roles, "Id", "Id", user_Role.RoleId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", user_Role.UserId);
            return View(user_Role);
        }

        // GET: User_Role/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user_Role = await _context.User_Roles
                .Include(u => u.Role)
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user_Role == null)
            {
                return NotFound();
            }

            return View(user_Role);
        }

        // POST: User_Role/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user_Role = await _context.User_Roles.FindAsync(id);
            _context.User_Roles.Remove(user_Role);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool User_RoleExists(int id)
        {
            return _context.User_Roles.Any(e => e.Id == id);
        }
    }
}
