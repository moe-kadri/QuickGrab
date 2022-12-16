using _278Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace _278Project.Data;



public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    // public DbSet<User> Users { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Cart> Carts { get; set; } = null!;
    public DbSet<WishList> WishLists { get; set; } = null!;

    public DbSet<Order> Orders { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Cart>().HasKey(c => new { c.UserName, c.ProductId });

        modelBuilder.Entity<Cart>()
        .HasOne(ba => ba.product)
        .WithMany(b => b.Carts)
        .HasForeignKey(ba => ba.ProductId);
        // one-to-many relationship between Author and BookAuthor
        modelBuilder.Entity<Cart>()
        .HasOne(ba => ba.user)
        .WithMany(a => a.Carts)
        .HasForeignKey(ba => ba.UserName);





        modelBuilder.Entity<WishList>().HasKey(c => new { c.Id, c.ProductId });
        modelBuilder.Entity<WishList>()
        .HasOne(ba => ba.product)
        .WithMany(b => b.WishLists)
        .HasForeignKey(ba => ba.ProductId);
        // one-to-many relationship between Author and BookAuthor
        modelBuilder.Entity<WishList>()
        .HasOne(ba => ba.user)
        .WithMany(a => a.WishLists)
        .HasForeignKey(ba => ba.Id);
    }


}
