using System;
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
    public class InvoicesController : Controller
    {
        private readonly TestDbContext _context;

        public InvoicesController(TestDbContext context)
        {
            _context = context;
        }

        // GET: Invoices
        public async Task<IActionResult> Index(string sortby = "invdate", bool asc = false, string searchstr="", int gotopage = 1)
        {
            int take = 15;
            searchstr = !string.IsNullOrWhiteSpace(searchstr) ? searchstr.Trim().ToLower() : searchstr;
            gotopage = gotopage <= 0 ? 1 : gotopage;
            IQueryable<Invoice> query = _context.Invoice.Include(i => i.Company);

            switch (sortby)
            {
                default:
                    query = asc ? query.OrderBy(c => c.InvDate) : query.OrderByDescending(c => c.InvDate);
                    break;
            }


            if (!string.IsNullOrWhiteSpace(searchstr))
            {
                query = query.Where(i =>
                    i.Company.Name.ToLower().Contains(searchstr)
                    || i.Number.ToLower().Contains(searchstr)
                    );
            }
                       
            try
            {
                int count = await query.CountAsync();
                int totalPages = (int)Math.Ceiling((double)count / take);
                gotopage = gotopage > totalPages && totalPages > 0 ? totalPages : gotopage;
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

        // GET: Invoices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            try
            {
                Invoice invoice = await _context.Invoice
                .Include(i => i.Company)
                .FirstOrDefaultAsync(m => m.Uid == id);
                if (invoice == null)
                {
                    return NotFound();
                }
                return View(invoice);
            }
            catch (SqlException)
            {
                ViewData["ErrorMessage"] = "Database Error.";
                return View("_Error");
            }
            
           
        }

        // GET: Invoices/Create
        public IActionResult Create()
        {
            ViewData["CompanyUid"] = new SelectList(_context.Company, "Uid", "Name");
            return View(new Invoice());
        }

        // POST: Invoices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyUid,Number,InvDate,Type,Total")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                invoice.Uid = SequentialGuid.GenerateComb();
                _context.Add(invoice);
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
            ViewData["CompanyUid"] = new SelectList(_context.Company, "Uid", "Name", invoice.CompanyUid);
            return View(invoice);
        }

        // GET: Invoices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Invoice invoice = await _context.Invoice.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }
            ViewData["CompanyUid"] = new SelectList(_context.Company, "Uid", "Name", invoice.CompanyUid);
            return View(invoice);
        }

        // POST: Invoices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Uid,CompanyUid,Number,InvDate,Type,Total")] Invoice invoice)
        {
            if (id != invoice.Uid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceExists(invoice.Uid))
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
            ViewData["CompanyUid"] = new SelectList(_context.Company, "Uid", "Name", invoice.CompanyUid);            
            return View(invoice);
        }

        // GET: Invoices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Invoice invoice = await _context.Invoice
                .Include(i => i.Company)
                .FirstOrDefaultAsync(m => m.Uid == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // POST: Invoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            Invoice invoice = await _context.Invoice.FindAsync(id);
            try 
            {
                _context.Invoice.Remove(invoice);
                await _context.SaveChangesAsync();
            }
            catch(SqlException)
            {
                ViewData["ErrorMessage"] = "Database Error.";
                return View("_Error");
            }

            return RedirectToAction(nameof(Index));
        }

        private bool InvoiceExists(Guid id)
        {
            return _context.Invoice.Any(e => e.Uid == id);
        }
    }
}
