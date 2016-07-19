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
    public class LocationCitiesController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: LocationCities
        public ActionResult Index()
        {
            return View(db.LocationCity.ToList());
        }

        // GET: LocationCities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationCity locationCity = db.LocationCity.Find(id);
            if (locationCity == null)
            {
                return HttpNotFound();
            }
            return View(locationCity);
        }

        // GET: LocationCities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LocationCities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocationCityId,LocationCityName")] LocationCity locationCity)
        {
            if (ModelState.IsValid)
            {
                db.LocationCity.Add(locationCity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(locationCity);
        }

        // GET: LocationCities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationCity locationCity = db.LocationCity.Find(id);
            if (locationCity == null)
            {
                return HttpNotFound();
            }
            return View(locationCity);
        }

        // POST: LocationCities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocationCityId,LocationCityName")] LocationCity locationCity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locationCity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(locationCity);
        }

        // GET: LocationCities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocationCity locationCity = db.LocationCity.Find(id);
            if (locationCity == null)
            {
                return HttpNotFound();
            }
            return View(locationCity);
        }

        // POST: LocationCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LocationCity locationCity = db.LocationCity.Find(id);
            db.LocationCity.Remove(locationCity);
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
