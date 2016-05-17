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
    public class LeafEdgeModelsController : Controller
    {
        private PlantDatabaseContext db = new PlantDatabaseContext();

        // GET: LeafEdgeModels
        public ActionResult Index()
        {
            return View(db.LeafEdgeModels.ToList());
        }

        // GET: LeafEdgeModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeafEdgeModel leafEdgeModel = db.LeafEdgeModels.Find(id);
            if (leafEdgeModel == null)
            {
                return HttpNotFound();
            }
            return View(leafEdgeModel);
        }

        // GET: LeafEdgeModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LeafEdgeModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LeafEdgeID,LeafEdges")] LeafEdgeModel leafEdgeModel)
        {
            if (ModelState.IsValid)
            {
                db.LeafEdgeModels.Add(leafEdgeModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(leafEdgeModel);
        }

        // GET: LeafEdgeModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeafEdgeModel leafEdgeModel = db.LeafEdgeModels.Find(id);
            if (leafEdgeModel == null)
            {
                return HttpNotFound();
            }
            return View(leafEdgeModel);
        }

        // POST: LeafEdgeModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LeafEdgeID,LeafEdges")] LeafEdgeModel leafEdgeModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(leafEdgeModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(leafEdgeModel);
        }

        // GET: LeafEdgeModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LeafEdgeModel leafEdgeModel = db.LeafEdgeModels.Find(id);
            if (leafEdgeModel == null)
            {
                return HttpNotFound();
            }
            return View(leafEdgeModel);
        }

        // POST: LeafEdgeModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LeafEdgeModel leafEdgeModel = db.LeafEdgeModels.Find(id);
            db.LeafEdgeModels.Remove(leafEdgeModel);
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
