using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace InstaBuy.Models
{
  public class Order
  {
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public string OrderNumber { get; set; }
    public int OrderType { get; set; }
    public DateTime OrderDate { get; set; }
    public int OrderStatusID { get; set; }
    public List<OrderDetail> OrderDetails { get; set; }
  }


  public class OrderDBContext : DbContext
  {
    public DbSet<Order> Orders { get; set; }
  }
}