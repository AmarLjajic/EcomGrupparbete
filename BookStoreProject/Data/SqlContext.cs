using BookStoreProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreProject.Data
{
    public class SqlContext : IdentityDbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<CoverTypeEntity> CoverTypes { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
