using Microsoft.EntityFrameworkCore;
using CarInsuranceFix.Models;

namespace CarInsuranceFix.Controllers.Data
{
    public class InsureeContext : DbContext
    {
        public InsureeContext(DbContextOptions<InsureeContext> options) : base (options)
        
        { }
        
            
        }
    }

