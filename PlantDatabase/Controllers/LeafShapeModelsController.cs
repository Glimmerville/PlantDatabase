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
    public class LeafShapeModelsController : Controller
    {
        private PlantDatabaseContext db = new PlantDatabaseContext();

        // GET: LeafShapeModels
        public ActionResult Index()
        {
            return View(db.LeafShapeModels.ToList());
        }

        // GET: LeafShapeModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeafShapeModel leafShapeModel = db.LeafShapeModels.Find(id);
            if (leafShapeModel == null)
            {
                return HttpNotFound();
            }
            return View(leafShapeModel);
        }

        // GET: LeafShapeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeafShapeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LeafShapeID,LeafShapeStyle")] LeafShapeModel leafShapeModel)
        {
            if (ModelState.IsValid)
            {
                db.LeafShapeModels.Add(leafShapeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leafShapeModel);
        }

        // GET: LeafShapeModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeafShapeModel leafShapeModel = db.LeafShapeModels.Find(id);
            if (leafShapeModel == null)
            {
                return HttpNotFound();
            }
            return View(leafShapeModel);
        }

        // POST: LeafShapeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LeafShapeID,LeafShapeStyle")] LeafShapeModel leafShapeModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leafShapeModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leafShapeModel);
        }

        // GET: LeafShapeModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeafShapeModel leafShapeModel = db.LeafShapeModels.Find(id);
            if (leafShapeModel == null)
            {
                return HttpNotFound();
            }
            return View(leafShapeModel);
        }

        // POST: LeafShapeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LeafShapeModel leafShapeModel = db.LeafShapeModels.Find(id);
            db.LeafShapeModels.Remove(leafShapeModel);
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
