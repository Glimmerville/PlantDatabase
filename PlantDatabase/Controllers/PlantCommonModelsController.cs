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
    public class PlantCommonModelsController : Controller
    {
        private PlantDatabaseContext db = new PlantDatabaseContext();

        // GET: PlantCommonModels
        public ActionResult Index()
        {
            return View(db.PlantCommonModels.ToList());
        }

        // GET: PlantCommonModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantCommonModel plantCommonModel = db.PlantCommonModels.Find(id);
            if (plantCommonModel == null)
            {
                return HttpNotFound();
            }
            return View(plantCommonModel);
        }

        // GET: PlantCommonModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlantCommonModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlantCommonID,PlantCommon,PlantCoreID")] PlantCommonModel plantCommonModel)
        {
            if (ModelState.IsValid)
            {
                db.PlantCommonModels.Add(plantCommonModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plantCommonModel);
        }

        // GET: PlantCommonModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantCommonModel plantCommonModel = db.PlantCommonModels.Find(id);
            if (plantCommonModel == null)
            {
                return HttpNotFound();
            }
            return View(plantCommonModel);
        }

        // POST: PlantCommonModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlantCommonID,PlantCommon,PlantCoreID")] PlantCommonModel plantCommonModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plantCommonModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plantCommonModel);
        }

        // GET: PlantCommonModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantCommonModel plantCommonModel = db.PlantCommonModels.Find(id);
            if (plantCommonModel == null)
            {
                return HttpNotFound();
            }
            return View(plantCommonModel);
        }

        // POST: PlantCommonModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlantCommonModel plantCommonModel = db.PlantCommonModels.Find(id);
            db.PlantCommonModels.Remove(plantCommonModel);
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
