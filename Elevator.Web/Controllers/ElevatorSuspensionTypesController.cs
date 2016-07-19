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
    public class ElevatorSuspensionTypesController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: ElevatorSuspensionTypes
        public ActionResult Index()
        {
            return View(db.ElevatorSuspensionType.ToList());
        }

        // GET: ElevatorSuspensionTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorSuspensionType elevatorSuspensionType = db.ElevatorSuspensionType.Find(id);
            if (elevatorSuspensionType == null)
            {
                return HttpNotFound();
            }
            return View(elevatorSuspensionType);
        }

        // GET: ElevatorSuspensionTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElevatorSuspensionTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ElevatorSuspensionTypeId,ElevatorSuspensionTypeName")] ElevatorSuspensionType elevatorSuspensionType)
        {
            if (ModelState.IsValid)
            {
                db.ElevatorSuspensionType.Add(elevatorSuspensionType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(elevatorSuspensionType);
        }

        // GET: ElevatorSuspensionTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorSuspensionType elevatorSuspensionType = db.ElevatorSuspensionType.Find(id);
            if (elevatorSuspensionType == null)
            {
                return HttpNotFound();
            }
            return View(elevatorSuspensionType);
        }

        // POST: ElevatorSuspensionTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ElevatorSuspensionTypeId,ElevatorSuspensionTypeName")] ElevatorSuspensionType elevatorSuspensionType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(elevatorSuspensionType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(elevatorSuspensionType);
        }

        // GET: ElevatorSuspensionTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ElevatorSuspensionType elevatorSuspensionType = db.ElevatorSuspensionType.Find(id);
            if (elevatorSuspensionType == null)
            {
                return HttpNotFound();
            }
            return View(elevatorSuspensionType);
        }

        // POST: ElevatorSuspensionTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ElevatorSuspensionType elevatorSuspensionType = db.ElevatorSuspensionType.Find(id);
            db.ElevatorSuspensionType.Remove(elevatorSuspensionType);
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
