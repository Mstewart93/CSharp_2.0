using Microsoft.EntityFrameworkCore;
using CarInsuranceFix.Models;

namespace CarInsuranceFix.Data
{
    public class InsureeContext : DbContext
    {
        public InsureeContext(DbContextOptions<InsureeContext> options) : base(options)
        {
        }
        public DbSet<Insuree> Insuree { get; set; }
    }
}




