using System.Collections.Generic;
using InstaBuy.Models;


namespace InstaBuy.ViewModels
{
  public class CustomerOrdersViewModel
  {
    public Customer Customer { get; set; }
    public List<Order> Orders { get; set; }
  }
}