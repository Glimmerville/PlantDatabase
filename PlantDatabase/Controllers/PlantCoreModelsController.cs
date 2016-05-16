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
    public class PlantCoreModelsController : Controller
    {
        private PlantDatabaseContext db = new PlantDatabaseContext();

        // GET: PlantCoreModels
        public ActionResult Index()
        {
            return View(db.PlantCoreModels.ToList());
        }

        // GET: PlantCoreModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantCoreModel plantCoreModel = db.PlantCoreModels.Find(id);
            if (plantCoreModel == null)
            {
                return HttpNotFound();
            }
            return View(plantCoreModel);
        }

        // GET: PlantCoreModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlantCoreModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlantCoreID")] PlantCoreModel plantCoreModel)
        {
            if (ModelState.IsValid)
            {
                db.PlantCoreModels.Add(plantCoreModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plantCoreModel);
        }

        // GET: PlantCoreModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantCoreModel plantCoreModel = db.PlantCoreModels.Find(id);
            if (plantCoreModel == null)
            {
                return HttpNotFound();
            }
            return View(plantCoreModel);
        }

        // POST: PlantCoreModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlantCoreID")] PlantCoreModel plantCoreModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plantCoreModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plantCoreModel);
        }

        // GET: PlantCoreModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantCoreModel plantCoreModel = db.PlantCoreModels.Find(id);
            if (plantCoreModel == null)
            {
                return HttpNotFound();
            }
            return View(plantCoreModel);
        }

        // POST: PlantCoreModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlantCoreModel plantCoreModel = db.PlantCoreModels.Find(id);
            db.PlantCoreModels.Remove(plantCoreModel);
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
