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
    public class ElevatorProducersController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: ElevatorProducers
        public ActionResult Index()
        {
            return View(db.ElevatorProducer.ToList());
        }

        // GET: ElevatorProducers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorProducer elevatorProducer = db.ElevatorProducer.Find(id);
            if (elevatorProducer == null)
            {
                return HttpNotFound();
            }
            return View(elevatorProducer);
        }

        // GET: ElevatorProducers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElevatorProducers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ElevatorProducerId,ElevatorProducerName")] ElevatorProducer elevatorProducer)
        {
            if (ModelState.IsValid)
            {
                db.ElevatorProducer.Add(elevatorProducer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elevatorProducer);
        }

        // GET: ElevatorProducers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorProducer elevatorProducer = db.ElevatorProducer.Find(id);
            if (elevatorProducer == null)
            {
                return HttpNotFound();
            }
            return View(elevatorProducer);
        }

        // POST: ElevatorProducers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ElevatorProducerId,ElevatorProducerName")] ElevatorProducer elevatorProducer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elevatorProducer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elevatorProducer);
        }

        // GET: ElevatorProducers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorProducer elevatorProducer = db.ElevatorProducer.Find(id);
            if (elevatorProducer == null)
            {
                return HttpNotFound();
            }
            return View(elevatorProducer);
        }

        // POST: ElevatorProducers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ElevatorProducer elevatorProducer = db.ElevatorProducer.Find(id);
            db.ElevatorProducer.Remove(elevatorProducer);
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
