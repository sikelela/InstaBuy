using System.Data.Entity;

namespace InstaBuy.Models
{
  public class Customer
  {
    public int CustomerID { get; set; }
    public int Gender { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string LoginName { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string AddressLine3 { get; set; }
    public string AddressLine4 { get; set; }
    public string AddressCode { get; set; }
    public string AddressCity { get; set; }
    public int ProvinceID { get; set; }
    public int CountryID { get; set; }
  }

  public class CustomerDBContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
  }
}