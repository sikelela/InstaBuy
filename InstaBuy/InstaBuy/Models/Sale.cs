using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace InstaBuy.Models
{
  public class Sale
  {
    public int OrderID { get; set; }
    public string SaleName { get; set; }
    public string SaleDescription { get; set; }
    public string TermsAndConditions { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public List<SaleProduct> SaleProducts { get; set; }
  }


  public class SaleDBContext : DbContext
  {
    public DbSet<Sale> Sales { get; set; }
  }
}