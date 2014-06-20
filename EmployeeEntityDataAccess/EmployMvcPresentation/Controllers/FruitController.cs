using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployMvcPresentation.Models;

namespace EmployMvcPresentation.Controllers
{
    public class FruitController : Controller
    {
        private FruitContext db = new FruitContext();

        //
        // GET: /Fruit/

        public ActionResult Index()
        {
            return View(db.Fruits.ToList());
        }

        //
        // GET: /Fruit/Details/5

        public ActionResult Details(int id = 0)
        {
            FruitModel fruitmodel = db.Fruits.Find(id);
            if (fruitmodel == null)
            {
                return HttpNotFound();
            }
            return View(fruitmodel);
        }

        //
        // GET: /Fruit/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Fruit/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FruitModel fruitmodel)
        {
            if (ModelState.IsValid)
            {
                db.Fruits.Add(fruitmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(fruitmodel);
        }

        //
        // GET: /Fruit/Edit/5

        public ActionResult Edit(int id = 0)
        {
            FruitModel fruitmodel = db.Fruits.Find(id);
            if (fruitmodel == null)
            {
                return HttpNotFound();
            }
            return View(fruitmodel);
        }

        //
        // POST: /Fruit/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FruitModel fruitmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fruitmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(fruitmodel);
        }

        //
        // GET: /Fruit/Delete/5

        public ActionResult Delete(int id = 0)
        {
            FruitModel fruitmodel = db.Fruits.Find(id);
            if (fruitmodel == null)
            {
                return HttpNotFound();
            }
            return View(fruitmodel);
        }

        //
        // POST: /Fruit/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FruitModel fruitmodel = db.Fruits.Find(id);
            db.Fruits.Remove(fruitmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}