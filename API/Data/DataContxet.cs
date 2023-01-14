using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContxet : DbContext
    {
        public DataContxet(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
    }
}