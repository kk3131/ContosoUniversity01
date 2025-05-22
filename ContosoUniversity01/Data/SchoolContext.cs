using ContosoUniversity01.Models;
using Microsoft.EntityFrameworkCore;
namespace ContosoUniversity01.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Enrollment> Enrollments { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
        public DbSet<ContosoUniversity01.Models.Instructor> Instructors { get; set; } = default!;
        public DbSet<ContosoUniversity01.Models.Department> Department { get; set; } = default!;
    }
}