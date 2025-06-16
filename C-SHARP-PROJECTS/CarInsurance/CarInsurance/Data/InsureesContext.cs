using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;


namespace CarInsurance.Data
{
    public class InsureesContext : DbContext
    {
        public InsureesContext(DbContextOptions<InsureesContext> options) : base(options)
        {
        }

        public DbSet<Insuree> Insurees { get; set; }
    }
}
