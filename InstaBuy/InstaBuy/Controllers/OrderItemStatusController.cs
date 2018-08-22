using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InstaBuy.Models;

namespace InstaBuy.Controllers
{
    public class OrderItemStatusController : Controller
    {
        private OrderItemStatusDBContext db = new OrderItemStatusDBContext();

        // GET: OrderItemStatus
        public ActionResult Index()
        {
            return View(db.OrderItemStatuses.ToList());
        }

        // GET: OrderItemStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItemStatus orderItemStatus = db.OrderItemStatuses.Find(id);
            if (orderItemStatus == null)
            {
                return HttpNotFound();
            }
            return View(orderItemStatus);
        }

        // GET: OrderItemStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderItemStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderItemStatusID,OrderItemStatusCode,OrderItemStatusName")] OrderItemStatus orderItemStatus)
        {
            if (ModelState.IsValid)
            {
                db.OrderItemStatuses.Add(orderItemStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orderItemStatus);
        }

        // GET: OrderItemStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItemStatus orderItemStatus = db.OrderItemStatuses.Find(id);
            if (orderItemStatus == null)
            {
                return HttpNotFound();
            }
            return View(orderItemStatus);
        }

        // POST: OrderItemStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderItemStatusID,OrderItemStatusCode,OrderItemStatusName")] OrderItemStatus orderItemStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderItemStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderItemStatus);
        }

        // GET: OrderItemStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderItemStatus orderItemStatus = db.OrderItemStatuses.Find(id);
            if (orderItemStatus == null)
            {
                return HttpNotFound();
            }
            return View(orderItemStatus);
        }

        // POST: OrderItemStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderItemStatus orderItemStatus = db.OrderItemStatuses.Find(id);
            db.OrderItemStatuses.Remove(orderItemStatus);
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
