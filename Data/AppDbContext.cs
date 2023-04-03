using APIProject.Model;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> MyStudent { get; set; }
    }
}
