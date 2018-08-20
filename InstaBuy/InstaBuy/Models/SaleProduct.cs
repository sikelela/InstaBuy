using System.Data.Entity;

namespace InstaBuy.Models
{
  public class SaleProduct
  {
    public int SaleProductID { get; set; }
    public int SaleID { get; set; }
    public int ProductID { get; set; }
    public int Quantity { get; set; }
    public double Discount { get; set; }

  }

  public class SaleProductDBContext : DbContext
  {
    public DbSet<SaleProduct> SaleProducts { get; set; }
  }
}