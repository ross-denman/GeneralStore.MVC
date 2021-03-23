using GeneralStore.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}