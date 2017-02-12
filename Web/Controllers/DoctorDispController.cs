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
    public class DoctorDispController : Controller
    {
        DoctorDispService a;
        //IDoctorService b;
        public DoctorDispController(DoctorDispService a)
        {
            this.a = a;
        }
        // GET: Hotel
        public ActionResult Index()
        {
            var l = a.getAlldisps();
            return View(l);
        }

        

               public ActionResult IndexBack()
        {
            var l = a.getAlldisps();
            return View(l);
        }

        // GET: Hotel/Details/5
        public ActionResult Details(int id)
        {
            doctordisponibility d = a.getdispById(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }

        // GET: Hotel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hotel/Create
        [HttpPost]
        public ActionResult Create(doctordisponibility h)
        {
            if (ModelState.IsValid)
            {
                a.adddisp(h);

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

        // GET: Hotel/Edit/5
        public ActionResult Edit(int id)
        {
            doctordisponibility h = a.getdispById(id);
            a.deletedispById(id);
            return View(h);
        }

        // POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, doctordisponibility h)
        {
            if (ModelState.IsValid)

                a.adddisp(h);

            return RedirectToAction("IndexBack");
        }

        // GET: Hotel/Delete/5
        public ActionResult Delete(int id)
        {
            a.deletedispById(id);
            var hs = a.getAlldisps();
            return RedirectToAction("IndexBack", hs);
        }

        // POST: Hotel/Delete/5
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
        //[HttpPost]
        //public ActionResult Index(string SearchString)
        //{
        //    var loans = a.getAlldisps;
        //    if (!String.IsNullOrEmpty(SearchString))
        //    {
        //        loans = loans.Where(l => l.account.Libelle.Contains(SearchString));
        //    }
        //    return View(loans);
        //}


    }
}
