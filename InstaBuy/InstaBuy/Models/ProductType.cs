using System.Data.Entity;

namespace InstaBuy.Models
{
  public class ProductType
  {
    public int ProductTypeID { get; set; }
    public string ProductTypeName { get; set; }
  }

  public class ProductTypeDBContext : DbContext
  {
    public DbSet<ProductType> ProductTypes { get; set; }
  }
}