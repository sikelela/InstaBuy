using System.Data.Entity;

namespace InstaBuy.Models
{
  public class Invoice
  {
    public int CustomerID { get; set; }
    public int Gender { get; set; }
    public string FirstName { get; set; }
  }


  public class InvoiceDBContext : DbContext
  {
    public DbSet<Invoice> Invoices { get; set; }
  }
}