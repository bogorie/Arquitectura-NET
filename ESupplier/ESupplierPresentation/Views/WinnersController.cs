using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ESupplierPresentation.Models;

namespace ESupplierPresentation.Views
{
    public class WinnersController : Controller
    {
        private esupplierEntities db = new esupplierEntities();

        // GET: Winners
        public ActionResult Index()
        {
            // TODO Consumir servicio!!
            return View(db.Winners.ToList());
        }

        // GET: Winners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // TODO Consumir servicio!!
            Winners winners = db.Winners.Find(id);
            if (winners == null)
            {
                return HttpNotFound();
            }
            return View(winners);
        }

        // GET: Winners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Winners/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "document,name,type")] Winners winners)
        {
            if (ModelState.IsValid)
            {
                // TODO Consumir servicio!!
                db.Winners.Add(winners);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(winners);
        }

        // GET: Winners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // TODO Consumir servicio!!
            Winners winners = db.Winners.Find(id);
            if (winners == null)
            {
                return HttpNotFound();
            }
            return View(winners);
        }

        // POST: Winners/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "document,name,type")] Winners winners)
        {
            if (ModelState.IsValid)
            {
                // TODO Consumir servicio!!
                db.Entry(winners).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(winners);
        }

        // GET: Winners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // TODO Consumir servicio!!
            Winners winners = db.Winners.Find(id);
            if (winners == null)
            {
                return HttpNotFound();
            }
            return View(winners);
        }

        // POST: Winners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            // TODO Consumir servicio!!
            Winners winners = db.Winners.Find(id);
            db.Winners.Remove(winners);
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
