using CodingWiki.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\sqlexpress;database=codingwiki;TrustServerCertificate=true;Trusted_Connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(_ => _.Price).HasPrecision(10, 5);
            //modelBuilder.Entity<Author>().Property(_ => _.FirstName)
            //                             .HasMaxLength(50)
            //                             .IsRequired();
            //modelBuilder.Entity<Author>().Property(_ => _.LastName)
            //                             .IsRequired();
            //modelBuilder.Entity<Publisher>().Property(_ => _.Name).IsRequired();

            //modelBuilder.Entity<SubCategory>().Property(_ => _.Name).IsRequired().HasMaxLength(50); ;


        }
    }
}
