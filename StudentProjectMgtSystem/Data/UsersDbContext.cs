using Microsoft.EntityFrameworkCore;
using StudentProjectMgtSystem.Models;

namespace StudentProjectMgtSystem.Data
{
    public class UsersDbContext :DbContext
    {
        public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }

    }
}
