using GeneralStore.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GeneralStore.MVC.Controllers
{
    public class ProductController : Controller
    {

        // Add the application DB Context (link to the database)

        private ApplicationDbContext _db = new ApplicationDbContext();
        
        // GET: Product
        public ActionResult Index()
        {
            // See below (modifying ApplicationDbContext class)

            return View(_db.Products.ToList());
        }

        // GET: Product
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product
        [HttpPost]
        public ActionResult Create (Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        // GET : Delete
        // Product/Delete/{id}
        public ActionResult Delete (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST : Delete
        // Product/Delete/{id}
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Product product = _db.Products.Find(id);
            _db.Products.Remove(product);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET : Edit
        // Product/Edit/{id}
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = _ db.Products.Find(id);
            if(product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST : Edit
        // Product/Edit/{id]
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("index");
            }
            return View(product);
        }
    }
}