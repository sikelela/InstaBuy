using System.Data.Entity;


namespace InstaBuy.Models
{
  public class OrderStatus
  {
    public int OrderStatusID { get; set; }
    public string OrderStatusCode { get; set; }
    public string OrderStatusName { get; set; }
  }

  public class OrderStatusDBContext : DbContext
  {
    public DbSet<OrderStatus> OrderStatuses { get; set; }
  }
}