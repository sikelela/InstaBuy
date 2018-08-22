using System.Collections.Generic;
using System.Data.Entity;

namespace InstaBuy.Models
{
  public class Product
  {
    public int ProductID { get; set; }
    public int ProducTypeID { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public string ShortDescription { get; set; }
    public string FullDescription { get; set; }
    public List<ProductImage> ProductImages { get; set; }
  }

  public class ProductDBContext : DbContext
  {
    public DbSet<Product> Products { get; set; }
  }
}
