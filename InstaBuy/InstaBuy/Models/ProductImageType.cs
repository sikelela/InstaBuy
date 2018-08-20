using System.Data.Entity;

namespace InstaBuy.Models
{
  public class ProductImageType
  {
    public int ProductImageTypeID { get; set; }
    public string ProductImageTypeName { get; set; }
  }

  public class ProductImageTypeDBContext : DbContext
  {
    public DbSet<ProductImageType> ProductImageTypes { get; set; }
  }
}