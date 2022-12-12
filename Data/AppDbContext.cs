using  _278Project.Models;
using Microsoft.EntityFrameworkCore;
namespace _278Project.Data;

public class AppDbContext: DbContext{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}

    public DbSet<User> Users {get;set;}=null!;
    public DbSet<Product> Products{get;set;}=null!;
    public DbSet<Cart> Carts{get;set;}=null!;
    public DbSet<WishList> WishLists{get;set;}=null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Cart>().HasKey(c=>new{c.UserId, c.ProductId});
        modelBuilder.Entity<WishList>().HasKey(c=>new{c.UserId, c.ProductId});
    }
}
