using Microsoft.EntityFrameworkCore;
using StudentProjectMgtSystem.Models;

namespace StudentProjectMgtSystem.Data
{
    public class ModulesDbContext : DbContext
    {
        public ModulesDbContext(DbContextOptions<ModulesDbContext> options) : base(options)
        {

        }

        public DbSet<Modules> Modules { get; set; }

    }
}
