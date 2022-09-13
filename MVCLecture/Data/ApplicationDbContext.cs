using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCLecture.Models;

namespace MVCLecture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student>? Student { get; set; }
        public DbSet<Grade>? Grade { get; set; }
        public DbSet<MVCLecture.Models.Course>? Course { get; set; }
        public DbSet<MVCLecture.Models.CourseStudent>? CourseStudent { get; set; }

    }
}