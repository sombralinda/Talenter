using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Talenter.Models;

namespace Talenter.Controllers
{
    public class TalentoController : Controller
    {
        private TalenterEntities1 db = new TalenterEntities1();

        // GET: Talento
        public ActionResult Index()
        {
            var tALENTO = db.TALENTO.Include(t => t.RUBRO);
            return View(tALENTO.ToList());
        }

        // GET: Talento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALENTO tALENTO = db.TALENTO.Find(id);
            if (tALENTO == null)
            {
                return HttpNotFound();
            }
            return View(tALENTO);
        }

        // GET: Talento/Create
        public ActionResult Create()
        {
            ViewBag.ID_RUBRO = new SelectList(db.RUBRO, "ID_RUBRO", "DESCRIPCION");
            return View();
        }

        // POST: Talento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_TALENTO,ID_RUBRO,EMAIL,PASSWORD,NOMBRE,APELLIDO,CURRICULUM")] TALENTO tALENTO)
        {
           
                if (ModelState.IsValid)
                {
                  db.TALENTO.Add(tALENTO);
                    db.SaveChanges();
                    return RedirectToAction("Login", "Account");
                }
           
           
                
            ViewBag.ID_RUBRO = new SelectList(db.RUBRO, "ID_RUBRO", "DESCRIPCION", tALENTO.ID_RUBRO);
            return View(tALENTO);
        }

        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // GET: Talento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALENTO tALENTO = db.TALENTO.Find(id);
            if (tALENTO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_RUBRO = new SelectList(db.RUBRO, "ID_RUBRO", "DESCRIPCION", tALENTO.ID_RUBRO);
            return View(tALENTO);
        }

        // POST: Talento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_TALENTO,ID_RUBRO,EMAIL,PASSWORD,NOMBRE,APELLIDO,CURRICULUM")] TALENTO tALENTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tALENTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details", "Talento", new { id = tALENTO.ID_TALENTO });
            }
            ViewBag.ID_RUBRO = new SelectList(db.RUBRO, "ID_RUBRO", "DESCRIPCION", tALENTO.ID_RUBRO);
            return View(tALENTO);
        }

        // GET: Talento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TALENTO tALENTO = db.TALENTO.Find(id);
            if (tALENTO == null)
            {
                return HttpNotFound();
            }
            return View(tALENTO);
        }

        // POST: Talento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TALENTO tALENTO = db.TALENTO.Find(id);
            db.TALENTO.Remove(tALENTO);
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
