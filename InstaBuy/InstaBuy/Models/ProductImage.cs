using System.Data.Entity;

namespace InstaBuy.Models
{
  public class ProductImage
  {
    public int ProductImageID { get; private set; }
    public int ProductID { get; private set; }
    public int ProductImageTypeID { get; private set; }
    public byte[] Image { get; set; }
  }

  public class ProductImageDBContext : DbContext
  {
    public DbSet<ProductImage> ProductImages { get; set; }
  }
}