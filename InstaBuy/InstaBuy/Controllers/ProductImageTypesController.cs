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
    public class ProductImageTypesController : Controller
    {
        private ProductImageTypeDBContext db = new ProductImageTypeDBContext();

        // GET: ProductImageTypes
        public ActionResult Index()
        {
            return View(db.ProductImageTypes.ToList());
        }

        // GET: ProductImageTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductImageType productImageType = db.ProductImageTypes.Find(id);
            if (productImageType == null)
            {
                return HttpNotFound();
            }
            return View(productImageType);
        }

        // GET: ProductImageTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductImageTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductImageTypeID,ProductImageTypeName")] ProductImageType productImageType)
        {
            if (ModelState.IsValid)
            {
                db.ProductImageTypes.Add(productImageType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productImageType);
        }

        // GET: ProductImageTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductImageType productImageType = db.ProductImageTypes.Find(id);
            if (productImageType == null)
            {
                return HttpNotFound();
            }
            return View(productImageType);
        }

        // POST: ProductImageTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductImageTypeID,ProductImageTypeName")] ProductImageType productImageType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productImageType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productImageType);
        }

        // GET: ProductImageTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductImageType productImageType = db.ProductImageTypes.Find(id);
            if (productImageType == null)
            {
                return HttpNotFound();
            }
            return View(productImageType);
        }

        // POST: ProductImageTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductImageType productImageType = db.ProductImageTypes.Find(id);
            db.ProductImageTypes.Remove(productImageType);
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
