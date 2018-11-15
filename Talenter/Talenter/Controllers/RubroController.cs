using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Talenter.Models;

namespace Talenter.Controllers
{
    public class RubroController : Controller
    {
        private TalenterEntities1 db = new TalenterEntities1();

        // GET: Rubro
        public ActionResult Index()
        {
            return View(db.RUBRO.ToList());
        }

        // GET: Rubro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RUBRO rUBRO = db.RUBRO.Find(id);
            if (rUBRO == null)
            {
                return HttpNotFound();
            }
            return View(rUBRO);
        }

        // GET: Rubro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rubro/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_RUBRO,DESCRIPCION")] RUBRO rUBRO)
        {
            if (ModelState.IsValid)
            {
                db.RUBRO.Add(rUBRO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rUBRO);
        }

        // GET: Rubro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RUBRO rUBRO = db.RUBRO.Find(id);
            if (rUBRO == null)
            {
                return HttpNotFound();
            }
            return View(rUBRO);
        }

        // POST: Rubro/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_RUBRO,DESCRIPCION")] RUBRO rUBRO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rUBRO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rUBRO);
        }

        // GET: Rubro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RUBRO rUBRO = db.RUBRO.Find(id);
            if (rUBRO == null)
            {
                return HttpNotFound();
            }
            return View(rUBRO);
        }

        // POST: Rubro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RUBRO rUBRO = db.RUBRO.Find(id);
            db.RUBRO.Remove(rUBRO);
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
