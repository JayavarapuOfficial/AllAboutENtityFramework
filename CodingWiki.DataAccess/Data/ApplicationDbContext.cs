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

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Spider Without Duty", ISBN = "123B12", Price = 10.99m, PublisherId=1 },
                new Book { Id = 2, Title = "Fortune of time", ISBN = "1212BC1212", Price = 11.99m , PublisherId = 2}
              );
            var bookList = new Book[]
            {
                new Book{ Id = 3, Title="Fake Sunday", ISBN="77652", Price=20.99m,PublisherId=2},
                new Book{ Id = 4, Title="Cookie Jar", ISBN="CC12B12", Price=25.99m, PublisherId=1},
                new Book{ Id = 5, Title="Cloudy Forest", ISBN="90392B33", Price=40.99m, PublisherId=1}
            };

            modelBuilder.Entity<Book>().HasData(bookList);
            modelBuilder.Entity<Publisher>().HasData(
                new Publisher { PublisherId = 1, Name = "Pub 1 Jimmy", Location = "Chicago" },
                new Publisher { PublisherId = 2, Name = "Pub 2 John", Location = "NewYork" },
                new Publisher { PublisherId = 3, Name = "Pub 3 Ben", Location = "Hawaii" }
                );
        }
    }
}
