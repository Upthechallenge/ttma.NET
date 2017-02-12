using domain.Entities;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DemandeController : Controller
    {
        DemandeService a;
        public DemandeController(DemandeService a)
        {
            this.a = a;
        }
        // GET: Demande
        public ActionResult Index()
        {
            var l = a.getAllDemande();
            return View(l);
        }

        // GET: Demande/Details/5
        public ActionResult Details(int id)
        {
            demande d = a.getDemandeById(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        //// GET: Demande/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Demande/Create
        //[HttpPost]
        //public ActionResult Create(demande h)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        a.addDemande(h);

        //        return RedirectToAction("Index");
        //    }


        //    else

        //        return View();
        //}

        // GET: Demande/Create Demande
        public ActionResult CreateDemande()
        {
            return View();
        }

        // POST: Demande/Create
        [HttpPost]
        public ActionResult CreateDemande(demande h)
        {
            if (ModelState.IsValid)
            {
                a.addDemande(h);

                return RedirectToAction("Index");
            }


            else

                return View();
        }
        public ActionResult google(string address)
        {
            return
    View((object)(address));
        }

        // GET: Demande/Edit/5
        public ActionResult Edit(int id)
        {
            demande h = a.getDemandeById(id);
            a.deleteDemandeById(id);
            return View(h);
        }

        // POST: Demande/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, demande h)
        {
            if (ModelState.IsValid)

                a.addDemande(h);

            return RedirectToAction("Index");
        }

        // GET: Demande/Delete/5
        public ActionResult Delete(int id)
        {
            a.deleteDemandeById(id);
            var hs = a.getAllDemande();
            return RedirectToAction("Index", hs);
        }

        // POST: Demande/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Demande Back
        public ActionResult IndexBack()
        {
            var l = a.getAllDemande();
            return View(l);
        }


        // GET: Demande/Edit/5
        public ActionResult EditAdmin(int id)
        {
            demande h = a.getDemandeById(id);
            a.deleteDemandeById(id);
            return View(h);
        }

        // POST: Demande/EditAdmin/5
        [HttpPost]
        public ActionResult EditAdmin(int id, demande h)
        {
            if (ModelState.IsValid)

                a.addDemande(h);

            return RedirectToAction("Index");
        }


    }
}
