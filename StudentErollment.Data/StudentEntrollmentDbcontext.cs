using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentErollment.Data.Configuration;

namespace StudentErollment.Data
{
    public class StudentEntrollmentDbcontext : IdentityDbContext
    {
        public StudentEntrollmentDbcontext(DbContextOptions<StudentEntrollmentDbcontext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
