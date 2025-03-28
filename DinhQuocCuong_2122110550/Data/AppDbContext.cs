using DinhQuocCuong_2122110550.Model;
using Microsoft.EntityFrameworkCore;

namespace DinhQuocCuong_2122110550.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { } 
        public DbSet<Product> Products { get; set; }
    }
}