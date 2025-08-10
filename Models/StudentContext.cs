using Microsoft.EntityFrameworkCore;

namespace CodeFirstStudentsEnrollments.Models
{
    // 1. inherit the db from database
    public class StudentContext : DbContext
    {
        //2.
        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Student> Students {  get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=RAJU_GOWTHAM;database=StudentDb;integrated security=true;trustservercertificate=true;");
        }

    }
}
