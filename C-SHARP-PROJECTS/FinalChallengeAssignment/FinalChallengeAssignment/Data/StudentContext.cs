using Microsoft.EntityFrameworkCore;
using FinalChallengeAssignment.Models;


namespace FinalChallengeAssignment.Data
{
    public class StudentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=StudentsDb");
        }
        public StudentContext() : base()
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
