using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using employeeManagement_MVC.Models.EF;

namespace employeeManagement_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeManagementContext _context = new EmployeeManagementContext();

        //public EmployeeController(EmployeeManagementContext context)
        //{
        //    _context = context;
        //}

        // GET: Employee
        public async Task<IActionResult> Index()
        {
              return _context.EmployeeDetailsNikhils != null ? 
                          View(await _context.EmployeeDetailsNikhils.ToListAsync()) :
                          Problem("Entity set 'EmployeeManagementContext.EmployeeDetailsNikhils'  is null.");
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EmployeeDetailsNikhils == null)
            {
                return NotFound();
            }

            var employeeDetailsNikhil = await _context.EmployeeDetailsNikhils
                .FirstOrDefaultAsync(m => m.EmpNo == id);
            if (employeeDetailsNikhil == null)
            {
                return NotFound();
            }

            return View(employeeDetailsNikhil);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpNo,EmpName,EmpDesignation,EmpSalary,EmpIsPermenant")] EmployeeDetailsNikhil employeeDetailsNikhil)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeDetailsNikhil);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeDetailsNikhil);
        }

        // GET: Employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EmployeeDetailsNikhils == null)
            {
                return NotFound();
            }

            var employeeDetailsNikhil = await _context.EmployeeDetailsNikhils.FindAsync(id);
            if (employeeDetailsNikhil == null)
            {
                return NotFound();
            }
            return View(employeeDetailsNikhil);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpNo,EmpName,EmpDesignation,EmpSalary,EmpIsPermenant")] EmployeeDetailsNikhil employeeDetailsNikhil)
        {
            if (id != employeeDetailsNikhil.EmpNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeDetailsNikhil);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeDetailsNikhilExists(employeeDetailsNikhil.EmpNo))
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
            return View(employeeDetailsNikhil);
        }

        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EmployeeDetailsNikhils == null)
            {
                return NotFound();
            }

            var employeeDetailsNikhil = await _context.EmployeeDetailsNikhils
                .FirstOrDefaultAsync(m => m.EmpNo == id);
            if (employeeDetailsNikhil == null)
            {
                return NotFound();
            }

            return View(employeeDetailsNikhil);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EmployeeDetailsNikhils == null)
            {
                return Problem("Entity set 'EmployeeManagementContext.EmployeeDetailsNikhils'  is null.");
            }
            var employeeDetailsNikhil = await _context.EmployeeDetailsNikhils.FindAsync(id);
            if (employeeDetailsNikhil != null)
            {
                _context.EmployeeDetailsNikhils.Remove(employeeDetailsNikhil);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeDetailsNikhilExists(int id)
        {
          return (_context.EmployeeDetailsNikhils?.Any(e => e.EmpNo == id)).GetValueOrDefault();
        }
    }
}
