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
    public class ElevatorDrivePowersController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: ElevatorDrivePowers
        public ActionResult Index()
        {
            return View(db.ElevatorDrivePower.ToList());
        }

        // GET: ElevatorDrivePowers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorDrivePower elevatorDrivePower = db.ElevatorDrivePower.Find(id);
            if (elevatorDrivePower == null)
            {
                return HttpNotFound();
            }
            return View(elevatorDrivePower);
        }

        // GET: ElevatorDrivePowers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElevatorDrivePowers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ElevatorDrivePowerId,ElevatorDrivePowerValue")] ElevatorDrivePower elevatorDrivePower)
        {
            if (ModelState.IsValid)
            {
                db.ElevatorDrivePower.Add(elevatorDrivePower);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elevatorDrivePower);
        }

        // GET: ElevatorDrivePowers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorDrivePower elevatorDrivePower = db.ElevatorDrivePower.Find(id);
            if (elevatorDrivePower == null)
            {
                return HttpNotFound();
            }
            return View(elevatorDrivePower);
        }

        // POST: ElevatorDrivePowers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ElevatorDrivePowerId,ElevatorDrivePowerValue")] ElevatorDrivePower elevatorDrivePower)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elevatorDrivePower).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elevatorDrivePower);
        }

        // GET: ElevatorDrivePowers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorDrivePower elevatorDrivePower = db.ElevatorDrivePower.Find(id);
            if (elevatorDrivePower == null)
            {
                return HttpNotFound();
            }
            return View(elevatorDrivePower);
        }

        // POST: ElevatorDrivePowers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ElevatorDrivePower elevatorDrivePower = db.ElevatorDrivePower.Find(id);
            db.ElevatorDrivePower.Remove(elevatorDrivePower);
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
