using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;

namespace Bookstore.Data;

public class BookstoreDb(DbContextOptions<BookstoreDb> options) : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Order>()
            .OwnsMany(e => e.OrderItems);
    }
}