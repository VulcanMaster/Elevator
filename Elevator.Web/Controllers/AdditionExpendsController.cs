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
    public class AdditionExpendsController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: AdditionExpends
        public ActionResult Index()
        {
            return View(db.AdditionExpend.ToList());
        }

        // GET: AdditionExpends/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionExpend additionExpend = db.AdditionExpend.Find(id);
            if (additionExpend == null)
            {
                return HttpNotFound();
            }
            return View(additionExpend);
        }

        // GET: AdditionExpends/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdditionExpends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AdditionExpendId,AddExpName,AddExpBasePrice")] AdditionExpend additionExpend)
        {
            if (ModelState.IsValid)
            {
                db.AdditionExpend.Add(additionExpend);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(additionExpend);
        }

        // GET: AdditionExpends/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionExpend additionExpend = db.AdditionExpend.Find(id);
            if (additionExpend == null)
            {
                return HttpNotFound();
            }
            return View(additionExpend);
        }

        // POST: AdditionExpends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdditionExpendId,AddExpName,AddExpBasePrice")] AdditionExpend additionExpend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(additionExpend).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(additionExpend);
        }

        // GET: AdditionExpends/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdditionExpend additionExpend = db.AdditionExpend.Find(id);
            if (additionExpend == null)
            {
                return HttpNotFound();
            }
            return View(additionExpend);
        }

        // POST: AdditionExpends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdditionExpend additionExpend = db.AdditionExpend.Find(id);
            db.AdditionExpend.Remove(additionExpend);
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
