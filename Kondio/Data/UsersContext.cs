using Kondio.Models;
using Microsoft.EntityFrameworkCore;

namespace Kondio.Data
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
