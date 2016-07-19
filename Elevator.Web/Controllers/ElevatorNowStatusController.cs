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
    public class ElevatorNowStatusController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: ElevatorNowStatus
        public ActionResult Index()
        {
            return View(db.ElevatorNowStatus.ToList());
        }

        // GET: ElevatorNowStatus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorNowStatus elevatorNowStatus = db.ElevatorNowStatus.Find(id);
            if (elevatorNowStatus == null)
            {
                return HttpNotFound();
            }
            return View(elevatorNowStatus);
        }

        // GET: ElevatorNowStatus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElevatorNowStatus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ElevatorNowStatusId,ElevatorNowStatusName")] ElevatorNowStatus elevatorNowStatus)
        {
            if (ModelState.IsValid)
            {
                db.ElevatorNowStatus.Add(elevatorNowStatus);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elevatorNowStatus);
        }

        // GET: ElevatorNowStatus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorNowStatus elevatorNowStatus = db.ElevatorNowStatus.Find(id);
            if (elevatorNowStatus == null)
            {
                return HttpNotFound();
            }
            return View(elevatorNowStatus);
        }

        // POST: ElevatorNowStatus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ElevatorNowStatusId,ElevatorNowStatusName")] ElevatorNowStatus elevatorNowStatus)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elevatorNowStatus).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elevatorNowStatus);
        }

        // GET: ElevatorNowStatus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorNowStatus elevatorNowStatus = db.ElevatorNowStatus.Find(id);
            if (elevatorNowStatus == null)
            {
                return HttpNotFound();
            }
            return View(elevatorNowStatus);
        }

        // POST: ElevatorNowStatus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ElevatorNowStatus elevatorNowStatus = db.ElevatorNowStatus.Find(id);
            db.ElevatorNowStatus.Remove(elevatorNowStatus);
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
