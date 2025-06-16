using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;
using Microsoft.Data.SqlClient;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private readonly InsureesContext _context;
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InsureeManagerDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public InsureesController(InsureesContext context)
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
                insuree.Quote = CalculateQuote(insuree);
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


        public decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50;
            if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18)
            {
                quote += 100;
            }
            else if (DateTime.Now.Year - insuree.DateOfBirth.Year > 19 && DateTime.Now.Year - insuree.DateOfBirth.Year <= 25)
            {
                quote += 50;
            }
            else
            {
                quote += 25;
            }
            if (Convert.ToInt32(insuree.CarYear) < 2000 || Convert.ToInt32(insuree.CarYear) > 2015)
            {
                quote += 25;
            }
            if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() != "911 carrera")
            {
                quote += 25;
            }
            else if (insuree.CarMake.ToLower() == "porsche" && insuree.CarModel.ToLower() == "911 carrera")
            {
                quote += 50;
            }
            quote += insuree.SpeedingTickets * 10;
            if (insuree.DUI)
            {
                quote = quote * 1.25m;
            }
            if (insuree.CoverageType.ToLower() == "full")
            {
                quote *= 1.5m;
            }
            return insuree.Quote = quote;
        }

        public ActionResult Admin()
        {
            string queryString = @"SELECT FirstName, LastName, EmailAddress, Quote FROM Insurees";
            List<Insuree> insurees = new List<Insuree>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var insuree = new Insuree();
                    insuree.FirstName = reader["FirstName"].ToString();
                    insuree.LastName = reader["LastName"].ToString();
                    insuree.EmailAddress = reader["EmailAddress"].ToString();
                    insuree.Quote = (decimal)reader["Quote"];
                    insurees.Add(insuree);
                }
            }

            var insureesVms = new List<InsureeVm>();
            foreach (var insuree in insurees)
            {
                var insureeVm = new InsureeVm();
                insureeVm.FirstName = insuree.FirstName;
                insureeVm.LastName = insuree.LastName;
                insureeVm.EmailAddress = insuree.EmailAddress;
                insureeVm.Quote = insuree.Quote;
                insureesVms.Add(insureeVm);
            }
            return View(insureesVms);
        }
    }
}
