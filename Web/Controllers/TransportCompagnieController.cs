using domain.Entities;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class TransportCompagnieController : Controller
    {
        TransportCompagnieService a;
        public TransportCompagnieController(TransportCompagnieService a)
        {
            this.a = a;
        }
        // GET: TransportCompagnie
        public ActionResult Index()
        {
            var l = a.getAllTransportCompagnie();
            return View(l);
        }


        // GET: TransportCompagnie Back
        public ActionResult IndexBack()
        {
            var l = a.getAllTransportCompagnie();
            return View(l);
        }

        // GET: TransportCompagnie/Details/5
        public ActionResult Details(int id)
        {
            transportcompagnie d = a.getTransportCompagnieById(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        // GET: TransportCompagnie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransportCompagnie/Create
        [HttpPost]
        public ActionResult Create(transportcompagnie h)
        {
            if (ModelState.IsValid)
            {
                a.addTransportCompagnie(h);

                return RedirectToAction("IndexBack");
            }


            else

                return View();
        }
        public ActionResult google(string address)
        {
            return
    View((object)(address));
        }

        // GET: TransportCompagnie/Edit/5
        public ActionResult Edit(int id)
        {
            transportcompagnie h = a.getTransportCompagnieById(id);
            a.deleteTransportCompagnieById(id);
            return View(h);
        }

        // POST: TransportCompagnie/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, transportcompagnie h)
        {
            if (ModelState.IsValid)

                a.addTransportCompagnie(h);

            return RedirectToAction("IndexBack");
        }

        // GET: TransportCompagnie/Delete/5
        public ActionResult Delete(int id)
        {
            a.deleteTransportCompagnieById(id);
            var hs = a.getAllTransportCompagnie();
            return RedirectToAction("IndexBack", hs);
        }

        // POST: TransportCompagnie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("IndexBack");
            }
            catch
            {
                return View();
            }
        }
        ////search
        //[HttpPost]
        //public ActionResult Index(string SearchString)
        //{
        //    var loans = a.getTransportCompagnieById(id);
        //    if (!String.IsNullOrEmpty(SearchString))
        //    {
        //        loans = loans.Where(l => l.account.Libelle.Contains(SearchString));
        //    }
        //    return View(loans);
        //}

        public ActionResult Statistiques()
        {
            int pn = a.countAllair();
            int hn = a.countAllmarine();
            int cn = a.countAllroutier();
            

            ViewBag.nbaire = hn.ToString();
            ViewBag.nbmarine = pn.ToString();
            ViewBag.nbroutier = cn.ToString();
            
            return View();
        }

       
    }
}
