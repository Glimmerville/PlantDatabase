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
    public class PlantLeafArrModelsController : Controller
    {
        private PlantDatabaseContext db = new PlantDatabaseContext();

        // GET: PlantLeafArrModels
        public ActionResult Index()
        {
            return View(db.PlantLeafArrModels.ToList());
        }

        // GET: PlantLeafArrModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantLeafArrModel plantLeafArrModel = db.PlantLeafArrModels.Find(id);
            if (plantLeafArrModel == null)
            {
                return HttpNotFound();
            }
            return View(plantLeafArrModel);
        }

        // GET: PlantLeafArrModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlantLeafArrModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlantLeafArrID,PlantLeafArr")] PlantLeafArrModel plantLeafArrModel)
        {
            if (ModelState.IsValid)
            {
                db.PlantLeafArrModels.Add(plantLeafArrModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plantLeafArrModel);
        }

        // GET: PlantLeafArrModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantLeafArrModel plantLeafArrModel = db.PlantLeafArrModels.Find(id);
            if (plantLeafArrModel == null)
            {
                return HttpNotFound();
            }
            return View(plantLeafArrModel);
        }

        // POST: PlantLeafArrModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlantLeafArrID,PlantLeafArr")] PlantLeafArrModel plantLeafArrModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plantLeafArrModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plantLeafArrModel);
        }

        // GET: PlantLeafArrModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlantLeafArrModel plantLeafArrModel = db.PlantLeafArrModels.Find(id);
            if (plantLeafArrModel == null)
            {
                return HttpNotFound();
            }
            return View(plantLeafArrModel);
        }

        // POST: PlantLeafArrModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlantLeafArrModel plantLeafArrModel = db.PlantLeafArrModels.Find(id);
            db.PlantLeafArrModels.Remove(plantLeafArrModel);
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
