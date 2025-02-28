using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Controllers.Data;
using CarInsurance.Models;
using Humanizer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using static CarInsurance.Models.Insuree;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsureeContext _context;

        public InsureesController(InsureeContext context)
        {
            _context = context;
        }

        // GET: Insurees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insurees/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insurees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Id = Guid.NewGuid();
                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insurees/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insurees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
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
            return View(insuree);
        }

        // GET: Insurees/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insurees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InsureeExists(Guid id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }


        public ActionResult CalculateQuote(Insuree model)
        {

            decimal monthlyTotal = 50; // Base amount

            // Age-based calculations
            if (model.DateOfBirth <= 18)
                monthlyTotal += 100;
            else if (model.DateOfBirth >= 19 && model.DateOfBirth <= 25)
                monthlyTotal += 50;
            else
                monthlyTotal += 25;

            // Car year-based calculations
            if (model.CarYear < 2000)
                monthlyTotal += 25;
            else if (model.CarYear > 2015)
                monthlyTotal += 25;

            // Make and model-based calculations
            if (model.CarMake == "Porsche")
            {
                monthlyTotal += 25;
                if (model.CarModel == "911 Carrera")
                    monthlyTotal += 25;
            }

            // Other factors
            monthlyTotal += model.SpeedingTickets * 10;

            if (model.DUI)
                monthlyTotal *= 1.25m;

            if (!string.IsNullOrEmpty(model.CoverageType))
                monthlyTotal *= 1.5m;

            

            return View("Create"); // Redirect to the appropriate view
        }
        public IActionResult AdminView()
        {
            var quotes = _context.Insurees.Select(i => new AdminViewModel
            {
                FirstName = i.FirstName,
                LastName = i.LastName,
                EmailAddress = i.EmailAddress,  // Make sure this property exists
                Quote = i.Quote
            }).ToList();

            return View(quotes);  // ✅ Now it works because it's inside a Controller
        }
    }


}

    


