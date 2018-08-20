using System.Data.Entity;

namespace InstaBuy.Models
{
  public class OrderDetail
  {
    public int OrderDetailID { get; set; }
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public int OrderItemStatusID { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }

  }

  public class OrderDetailDBContext : DbContext
  {
    public DbSet<OrderDetail> OrderDetails { get; set; }
  }
}