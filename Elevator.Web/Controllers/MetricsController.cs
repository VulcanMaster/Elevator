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
    public class MetricsController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: Metrics
        public ActionResult Index()
        {
            return View(db.Metric.ToList());
        }

        // GET: Metrics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metric metric = db.Metric.Find(id);
            if (metric == null)
            {
                return HttpNotFound();
            }
            return View(metric);
        }

        // GET: Metrics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Metrics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MetricId,MetricFullName,MetricShortName")] Metric metric)
        {
            if (ModelState.IsValid)
            {
                db.Metric.Add(metric);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(metric);
        }

        // GET: Metrics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metric metric = db.Metric.Find(id);
            if (metric == null)
            {
                return HttpNotFound();
            }
            return View(metric);
        }

        // POST: Metrics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MetricId,MetricFullName,MetricShortName")] Metric metric)
        {
            if (ModelState.IsValid)
            {
                db.Entry(metric).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(metric);
        }

        // GET: Metrics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Metric metric = db.Metric.Find(id);
            if (metric == null)
            {
                return HttpNotFound();
            }
            return View(metric);
        }

        // POST: Metrics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Metric metric = db.Metric.Find(id);
            db.Metric.Remove(metric);
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
