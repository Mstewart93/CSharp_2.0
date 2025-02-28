using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;
using Microsoft.AspNetCore.Mvc;


namespace CarInsurance.Controllers.Data
{
    public class InsureeContext : DbContext
    {
        public InsureeContext(DbContextOptions<InsureeContext> options) : base(options)
        { }
        public DbSet<Insuree> Insurees { get; set; }

        //public ActionResult AdminView()
        //{
        //    var quotes = this.Insurees.Select(i => new  Insuree.AdminViewModel
        //    {
        //        FirstName = i.FirstName,
        //        LastName = i.LastName,
        //        EmailAddress = i.EmailAddress,
        //        Quote = i.Quote // Assuming you have a property for Quote in your Insuree model
        //    }).ToList();

        //    return View(quotes);
        //}

    }
    }

