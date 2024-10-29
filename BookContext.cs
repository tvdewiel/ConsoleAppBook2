using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBook2
{
    public class BookContext :DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=NB21-6CDPYD3\SQLEXPRESS;Initial Catalog=Book2_2024;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("BookInfo");
            modelBuilder.Entity<Book>().HasIndex(b => b.Title);
            modelBuilder.Entity<Book>()
                .HasOne(b => b.PriceOffer)
                .WithOne(p => p.Book)
                .HasForeignKey<PriceOffer>(b => b.BookISBN);
        }
    }
}
