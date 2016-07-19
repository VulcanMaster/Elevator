using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Elevator.Web.Models;
using Elevator.Web.Models.EE.Operational;

namespace Elevator.Web.Controllers
{
    public class ServiceBoardsController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: ServiceBoards
        public ActionResult Index()
        {
            var serviceBoard = db.ServiceBoard.Include(s => s.Elevator);
            return View(serviceBoard.ToList());
        }

        // GET: ServiceBoards/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceBoard serviceBoard = db.ServiceBoard.Find(id);
            if (serviceBoard == null)
            {
                return HttpNotFound();
            }
            return View(serviceBoard);
        }

        // GET: ServiceBoards/Create
        public ActionResult Create()
        {
            ViewBag.ElevatorsId = new SelectList(db.Elevator, "ElevatorsId", "Name");
            return View();
        }

        // POST: ServiceBoards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServiceBoardId,IncidentDate,ElevatorsId")] ServiceBoard serviceBoard)
        {
            if (ModelState.IsValid)
            {
                db.ServiceBoard.Add(serviceBoard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ElevatorsId = new SelectList(db.Elevator, "ElevatorsId", "Name", serviceBoard.ElevatorsId);
            return View(serviceBoard);
        }

        // GET: ServiceBoards/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceBoard serviceBoard = db.ServiceBoard.Find(id);
            if (serviceBoard == null)
            {
                return HttpNotFound();
            }
            ViewBag.ElevatorsId = new SelectList(db.Elevator, "ElevatorsId", "Name", serviceBoard.ElevatorsId);
            return View(serviceBoard);
        }

        // POST: ServiceBoards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServiceBoardId,IncidentDate,ElevatorsId")] ServiceBoard serviceBoard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceBoard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ElevatorsId = new SelectList(db.Elevator, "ElevatorsId", "Name", serviceBoard.ElevatorsId);
            return View(serviceBoard);
        }

        // GET: ServiceBoards/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceBoard serviceBoard = db.ServiceBoard.Find(id);
            if (serviceBoard == null)
            {
                return HttpNotFound();
            }
            return View(serviceBoard);
        }

        // POST: ServiceBoards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceBoard serviceBoard = db.ServiceBoard.Find(id);
            db.ServiceBoard.Remove(serviceBoard);
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
