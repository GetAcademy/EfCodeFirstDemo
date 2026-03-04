using EfCodeFirstDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCodeFirstDemo.Data
{
    internal class SchoolContext : DbContext
    {
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Course> Courses => Set<Course>();
        public DbSet<Assignment> Assignments => Set<Assignment>();
        public DbSet<Enrollment> Enrollments => Set<Enrollment>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolCodeFirst;Integrated Security=True");
            }
        }
    }
}
