using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
using CapaNegocio.Entities;

namespace PryPlanEstudios.Controllers
{
    public class ESTUDIANTEsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ESTUDIANTEs
        public ActionResult Index()
        {
            return View(db.ESTUDIANTEs.ToList());
        }

        // GET: ESTUDIANTEs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTUDIANTE eSTUDIANTE = db.ESTUDIANTEs.Find(id);
            if (eSTUDIANTE == null)
            {
                return HttpNotFound();
            }
            return View(eSTUDIANTE);
        }

        // GET: ESTUDIANTEs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ESTUDIANTEs/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EST_ID,EST_CEDULA,EST_NOMBRES,EST_APELLIDOS,EST_FNACIMIENTO,EST_PLAN_ESTUDIO,PLA_ID,EST_EMAIL,EST_TEL_DOMICILIO,EST_TEL_CELULAR,EST_DIRECCION")] ESTUDIANTE eSTUDIANTE)
        {
            if (ModelState.IsValid)
            {
                db.ESTUDIANTEs.Add(eSTUDIANTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eSTUDIANTE);
        }

        // GET: ESTUDIANTEs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTUDIANTE eSTUDIANTE = db.ESTUDIANTEs.Find(id);
            if (eSTUDIANTE == null)
            {
                return HttpNotFound();
            }
            return View(eSTUDIANTE);
        }

        // POST: ESTUDIANTEs/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EST_ID,EST_CEDULA,EST_NOMBRES,EST_APELLIDOS,EST_FNACIMIENTO,EST_PLAN_ESTUDIO,PLA_ID,EST_EMAIL,EST_TEL_DOMICILIO,EST_TEL_CELULAR,EST_DIRECCION")] ESTUDIANTE eSTUDIANTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eSTUDIANTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eSTUDIANTE);
        }

        // GET: ESTUDIANTEs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ESTUDIANTE eSTUDIANTE = db.ESTUDIANTEs.Find(id);
            if (eSTUDIANTE == null)
            {
                return HttpNotFound();
            }
            return View(eSTUDIANTE);
        }

        // POST: ESTUDIANTEs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ESTUDIANTE eSTUDIANTE = db.ESTUDIANTEs.Find(id);
            db.ESTUDIANTEs.Remove(eSTUDIANTE);
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
