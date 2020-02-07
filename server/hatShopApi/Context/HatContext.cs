using System; 
using System.Collections.Generic; 
using Microsoft.EntityFrameworkCore; 
using Microsoft.EntityFrameworkCore.Sqlite; 

public class HatContext : DbContext {
    
    public DbSet<Hat> Hats { get; set; }
    public DbSet<CartItem> ShoppingCartItems { get; set; }
  //  public DbSet<ShoppingCart> ShoppingCart { get; set; }
    public DbSet<Order> OrderItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) 
        => options 
        .UseSqlite("Data Source=allthehats.db");
        
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      modelBuilder.Entity<Hat>().HasData(new Hat { Id = 1, hatName = "Hashtag Hat", hatPrice = 100, hatText = "Keep warm while tweeting", imgStr = "http://t0.gstatic.com/images?q=tbn%3AANd9GcRvO9UDf-3_pYJ8-krePNKiwm-D73OtdZan9ETILEIDwlQO18VxvZQgGZlaex4&usqp=CAc" });
      modelBuilder.Entity<Hat>().HasData(new Hat { Id = 2, hatName = "200", hatPrice = 100, hatText = "Let people know you are OK", imgStr = "http://t0.gstatic.com/images?q=tbn%3AANd9GcTBv6cqMX7yBTcT_GKOTFVLlx1QZd2oUYz4kVPzS6Y8_sWvKqOi14SfCbBiq00dlsE40jxh2yY&usqp=CAc" });
      modelBuilder.Entity<Hat>().HasData(new Hat { Id = 3, hatName = "new MyHat()", hatPrice = 100, hatText = "This is an instance of a hat", imgStr = "http://t0.gstatic.com/images?q=tbn%3AANd9GcQgqMJlq9uu9m9EVmm5ytER2-h68fXvFkBwdrjxwVMFzOY4v713l-VZVTsLPS8aS43O9TXkzsq-&usqp=CAc" });
      modelBuilder.Entity<Hat>().HasData(new Hat { Id = 4, hatName = "I Am Hat", hatPrice = 100, hatText = "This hat is self aware", imgStr = "http://t0.gstatic.com/images?q=tbn%3AANd9GcT8zZNXpCSXXRFd8bF5ED2jwQv6Iym_SExvExyBppUlv0574IMMSG9SRg3l3bA_P6Z774FE5e4P&usqp=CAc" });

      modelBuilder.Entity<Order>().HasData(new Order {OrderId = 1, Total = 100, Quantity = 1}); 
    }
}