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
    public class ClientsBanksController : Controller
    {
        private AbSqlContext db = new AbSqlContext();

        // GET: ClientsBanks
        public ActionResult Index()
        {
            return View(db.ClientsBank.ToList());
        }

        // GET: ClientsBanks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientsBank clientsBank = db.ClientsBank.Find(id);
            if (clientsBank == null)
            {
                return HttpNotFound();
            }
            return View(clientsBank);
        }

        // GET: ClientsBanks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientsBanks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ClientsBankId,ClientsBankName")] ClientsBank clientsBank)
        {
            if (ModelState.IsValid)
            {
                db.ClientsBank.Add(clientsBank);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientsBank);
        }

        // GET: ClientsBanks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientsBank clientsBank = db.ClientsBank.Find(id);
            if (clientsBank == null)
            {
                return HttpNotFound();
            }
            return View(clientsBank);
        }

        // POST: ClientsBanks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ClientsBankId,ClientsBankName")] ClientsBank clientsBank)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientsBank).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientsBank);
        }

        // GET: ClientsBanks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientsBank clientsBank = db.ClientsBank.Find(id);
            if (clientsBank == null)
            {
                return HttpNotFound();
            }
            return View(clientsBank);
        }

        // POST: ClientsBanks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClientsBank clientsBank = db.ClientsBank.Find(id);
            db.ClientsBank.Remove(clientsBank);
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
