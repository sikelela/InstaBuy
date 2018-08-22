using System.Collections.Generic;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;
using InstaBuy.Models;
using InstaBuy.ViewModels;

namespace InstaBuy.Controllers
{
  public class OrdersController : Controller
  {
    private OrderDBContext db = new OrderDBContext();

    // GET: Orders
    public ActionResult Index(int id)
    {
      Order order = new Order();
      /*
      Pass Data to View :Option One 
      ViewData["Order"] = order;

      Pass Data to View :Option Two 
      ViewBag.Order = order;
      */

      /*Below is equivalent to
      var viewResult = new ViewResult();
      viewResult.ViewData.Model;
      */

      return View(order);
    }

    // GET: Orders
    [Route("orders/orderList/{pageIndex:regex(\\d{4}):range(1,12)}/{sortby}")]
    public ActionResult OrderList(int? pageIndex, string sortby)
    {
      if (!pageIndex.HasValue)
        pageIndex = 1;
      if (string.IsNullOrWhiteSpace(sortby))
        sortby = "OrderNumber";

      return Content(string.Format("Page: {0} Sort By {1}", pageIndex, sortby));
    }

    // GET: Customer Orders
    public ActionResult CustomerOrders()
    {
      Customer customer = new Customer()
      {
        CustomerID = 1,
        FirstName = "John",
        LastName = "Doe"
      };
      var orders = new List<Order>();
      orders.Add(new Order { CustomerID = 1, OrderNumber = "001" });
      orders.Add(new Order { CustomerID = 1, OrderNumber = "002" });

      var viewModel = new CustomerOrdersViewModel()
      {
        Customer = customer,
        Orders = orders
      };

      return View("CustomerOrders", viewModel);
    }

    // GET: Orders/Details/5
    public ActionResult Details(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Order order = db.Orders.Find(id);
      if (order == null)
      {
        return HttpNotFound();
      }
      return View(order);
    }

    // GET: Orders/Create
    public ActionResult Create()
    {
      return View();
    }

    // POST: Orders/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "OrderID,CustomerID,OrderNumber,OrderType,OrderDate,OrderStatusID")] Order order)
    {
      if (ModelState.IsValid)
      {
        db.Orders.Add(order);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      return View(order);
    }

    // GET: Orders/Edit/5
    public ActionResult Edit(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Order order = db.Orders.Find(id);
      if (order == null)
      {
        return HttpNotFound();
      }
      return View(order);
    }

    // POST: Orders/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "OrderID,CustomerID,OrderNumber,OrderType,OrderDate,OrderStatusID")] Order order)
    {
      if (ModelState.IsValid)
      {
        db.Entry(order).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(order);
    }

    // GET: Orders/Delete/5
    public ActionResult Delete(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Order order = db.Orders.Find(id);
      if (order == null)
      {
        return HttpNotFound();
      }
      return View(order);
    }

    // POST: Orders/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
      Order order = db.Orders.Find(id);
      db.Orders.Remove(order);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing)
      {
        db.Dispose();
      }
      base.Dispose(disposing);
    }
  }
}
