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
    public class TotalPlantDescriptionModelsController : Controller
    {
        private PlantDatabaseContext db = new PlantDatabaseContext();

        // GET: TotalPlantDescriptionModels
        public ActionResult Index()
        {
            return View(db.TotalPlantDescriptionModels.ToList());
        }

        // GET: TotalPlantDescriptionModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TotalPlantDescriptionModel totalPlantDescriptionModel = db.TotalPlantDescriptionModels.Find(id);
            if (totalPlantDescriptionModel == null)
            {
                return HttpNotFound();
            }
            return View(totalPlantDescriptionModel);
        }

        // GET: TotalPlantDescriptionModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TotalPlantDescriptionModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlantDescriptionID,PlantCoreID,PlantCommonID,BloomColorID,PlantLeafArrID,LeafShapeID,LeafEdgeID")] TotalPlantDescriptionModel totalPlantDescriptionModel)
        {
            if (ModelState.IsValid)
            {
                db.TotalPlantDescriptionModels.Add(totalPlantDescriptionModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(totalPlantDescriptionModel);
        }

        // GET: TotalPlantDescriptionModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TotalPlantDescriptionModel totalPlantDescriptionModel = db.TotalPlantDescriptionModels.Find(id);
            if (totalPlantDescriptionModel == null)
            {
                return HttpNotFound();
            }
            return View(totalPlantDescriptionModel);
        }

        // POST: TotalPlantDescriptionModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlantDescriptionID,PlantCoreID,PlantCommonID,BloomColorID,PlantLeafArrID,LeafShapeID,LeafEdgeID")] TotalPlantDescriptionModel totalPlantDescriptionModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(totalPlantDescriptionModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(totalPlantDescriptionModel);
        }

        // GET: TotalPlantDescriptionModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TotalPlantDescriptionModel totalPlantDescriptionModel = db.TotalPlantDescriptionModels.Find(id);
            if (totalPlantDescriptionModel == null)
            {
                return HttpNotFound();
            }
            return View(totalPlantDescriptionModel);
        }

        // POST: TotalPlantDescriptionModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TotalPlantDescriptionModel totalPlantDescriptionModel = db.TotalPlantDescriptionModels.Find(id);
            db.TotalPlantDescriptionModels.Remove(totalPlantDescriptionModel);
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
