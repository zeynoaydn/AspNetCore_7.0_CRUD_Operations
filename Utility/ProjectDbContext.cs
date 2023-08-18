using Microsoft.EntityFrameworkCore;
using Mvc_Project.Models;

namespace Mvc_Project.Utility
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {}
        public DbSet<KitapTuru> KitapTurleri { get; set; }
        public DbSet<Kitap> Kitaplar { get; set; }
    }
}
