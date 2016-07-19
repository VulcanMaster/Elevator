using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Elevator.Web.Models;
using Elevator.Web.Models.EE.Dictionary;

namespace Elevator.Web.Controllers
{
    public class ElevatorsController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: Elevators
        public ActionResult Index()
        {
            return View(db.Elevator.ToList());
        }

        // GET: Elevators/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elevators elevators = db.Elevator.Find(id);
            if (elevators == null)
            {
                return HttpNotFound();
            }
            return View(elevators);
        }

        // GET: Elevators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Elevators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ElevatorsId,Name")] Elevators elevators)
        {
            if (ModelState.IsValid)
            {
                db.Elevator.Add(elevators);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elevators);
        }

        // GET: Elevators/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elevators elevators = db.Elevator.Find(id);
            if (elevators == null)
            {
                return HttpNotFound();
            }
            return View(elevators);
        }

        // POST: Elevators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ElevatorsId,Name")] Elevators elevators)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elevators).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elevators);
        }

        // GET: Elevators/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Elevators elevators = db.Elevator.Find(id);
            if (elevators == null)
            {
                return HttpNotFound();
            }
            return View(elevators);
        }

        // POST: Elevators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Elevators elevators = db.Elevator.Find(id);
            db.Elevator.Remove(elevators);
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
