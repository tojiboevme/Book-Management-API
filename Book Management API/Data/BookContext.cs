using Microsoft.EntityFrameworkCore;
using BookManagementAPI.Models; // Adjust according to your project structure

namespace BookManagementAPI.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}