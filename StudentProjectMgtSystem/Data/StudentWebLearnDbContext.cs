using Microsoft.EntityFrameworkCore;
using StudentProjectMgtSystem.Models;

namespace StudentProjectMgtSystem.Data
{
    public class StudentWebLearnDbContext : DbContext
    {
        public StudentWebLearnDbContext(DbContextOptions<StudentWebLearnDbContext> options) : base(options)
        {

        }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Module> Module { get; set; }

    }
}