using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PlantDatabase.Models;

namespace PlantDatabase.Controllers
{
    public class BloomColorModelsController : Controller
    {
        private PlantDatabaseContext db = new PlantDatabaseContext();

        // GET: BloomColorModels
        public ActionResult Index()
        {
            return View(db.BloomColors.ToList());
        }

        // GET: BloomColorModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloomColorModel bloomColorModel = db.BloomColors.Find(id);
            if (bloomColorModel == null)
            {
                return HttpNotFound();
            }
            return View(bloomColorModel);
        }

        // GET: BloomColorModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BloomColorModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BloomColorID,FlowerColor")] BloomColorModel bloomColorModel)
        {
            if (ModelState.IsValid)
            {
                db.BloomColors.Add(bloomColorModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloomColorModel);
        }

        // GET: BloomColorModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloomColorModel bloomColorModel = db.BloomColors.Find(id);
            if (bloomColorModel == null)
            {
                return HttpNotFound();
            }
            return View(bloomColorModel);
        }

        // POST: BloomColorModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BloomColorID,FlowerColor")] BloomColorModel bloomColorModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloomColorModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloomColorModel);
        }

        // GET: BloomColorModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloomColorModel bloomColorModel = db.BloomColors.Find(id);
            if (bloomColorModel == null)
            {
                return HttpNotFound();
            }
            return View(bloomColorModel);
        }

        // POST: BloomColorModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BloomColorModel bloomColorModel = db.BloomColors.Find(id);
            db.BloomColors.Remove(bloomColorModel);
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
