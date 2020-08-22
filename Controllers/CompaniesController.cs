using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Test.Data;
using Test.Helpers;
using Test.Models;

namespace Test.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly TestDbContext _context;

        public CompaniesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: Companies
        public async Task<IActionResult> Index(string sortby = "name", bool asc = true, string searchstr = null, int gotopage = 1)
        {
            int take = 15;
            searchstr = !string.IsNullOrWhiteSpace(searchstr) ? searchstr.Trim().ToLower() : searchstr;
            gotopage = gotopage <= 0 ? 1 : gotopage;
            IQueryable<Company> query = from c in _context.Company select c;
            switch (sortby)
            {
                case "regdate":
                    query = asc ? query.OrderBy(c => c.RegDate) : query.OrderByDescending(c => c.RegDate);
                    break;
                default:
                    query = asc ? query.OrderBy(c => c.Name) : query.OrderByDescending(c => c.Name);
                    break;
            }

            if (!string.IsNullOrWhiteSpace(searchstr))
            {
                query = query.Where(c =>
                    c.Name.ToLower().Contains(searchstr)
                    || c.Address.ToLower().Contains(searchstr)
                    );
            }

            try
            {
                int count = await query.CountAsync();
                int totalPages = (int)Math.Ceiling((double)count / take);
                gotopage = gotopage > totalPages && totalPages>0 ? totalPages : gotopage;
                ViewData["SortBy"] = sortby;
                ViewData["Asc"] = asc;
                ViewData["TotalPages"] = totalPages == 0 ? 1 : totalPages;
                ViewData["CurrentPage"] = gotopage;
                ViewData["SearchStr"] = searchstr;

                return View(await query.Skip(take * gotopage - take).Take(take).ToListAsync());
            }
            catch (SqlException)
            {
                ViewData["ErrorMessage"] = "Database Error.";
                return View("_Error");
            }
        }

        // GET: Companies/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }



            try
            {
                Company company = await _context.Company
                    .FirstOrDefaultAsync(m => m.Uid == id);
                if (company == null)
                {
                    return NotFound();
                }

                return View(company);
            }
            catch (SqlException)
            {
                ViewData["ErrorMessage"] = "Database Error.";
                return View("_Error");
            }
        }

        // GET: Companies/Create
        public IActionResult Create()
        {
            return View(new Company());
        }

        // POST: Companies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,RegDate,Address,Telephone")] Company company)
        {
            if (ModelState.IsValid)
            {
                company.Uid = SequentialGuid.GenerateComb();
                _context.Add(company);
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (SqlException)
                {
                    ViewData["ErrorMessage"] = "Database Error.";
                    return View("_Error");
                }

            }
            return View(company);
        }

        // GET: Companies/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                Company company = await _context.Company.FindAsync(id);
                if (company == null)
                {
                    return NotFound();
                }
                return View(company);
            }

            catch (SqlException)
            {
                ViewData["ErrorMessage"] = "Database Error.";
                return View("_Error");
            }

        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Uid,Name,RegDate,Address,Telephone")] Company company)
        {
            if (id != company.Uid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(company);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyExists(company.Uid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        return View("_Error");
                    }
                }
                catch (SqlException)
                {
                    ViewData["ErrorMessage"] = "Database Error.";
                    return View("_Error");
                }
                return RedirectToAction(nameof(Index));
            }
            return View(company);
        }

        // GET: Companies/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                Company company = await _context.Company
                                .FirstOrDefaultAsync(m => m.Uid == id);
                if (company == null)
                {
                    return NotFound();
                }
                return View(company);
            }
            catch (SqlException)
            {
                ViewData["ErrorMessage"] = "Database Error.";
                return View("_Error");
            }



        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            Company company = await _context.Company.FindAsync(id);
            _context.Company.Remove(company);
            try
            {
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (SqlException)
            {
                ViewData["ErrorMessage"] = "Database Error.";
                return View("_Error");
            }
        }

        private bool CompanyExists(Guid id)
        {
            return _context.Company.Any(e => e.Uid == id);
        }
    }
}
