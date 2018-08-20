using System.Data.Entity;


namespace InstaBuy.Models
{
  public class OrderItemStatus
  {
    public int OrderTypeID { get; set; }
    public string OrderItemStatusCode { get; set; }
    public string OrderItemStatusName { get; set; }
  }

  public class OrderItemStatusDBContext : DbContext
  {
    public DbSet<OrderItemStatus> OrderItemStatuses { get; set; }
  }
}