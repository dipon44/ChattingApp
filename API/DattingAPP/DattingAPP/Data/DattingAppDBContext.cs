using DattingAPP.Models;
using Microsoft.EntityFrameworkCore;




namespace DattingAPP.Data
{
    public class DattingAppDBContext : DbContext
    {
        public DattingAppDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; }

    }
}
