using domain.Entities;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ConsultationController : Controller
    {
        ConsultationService a;
        DoctorDispService d;
        
        public ConsultationController(ConsultationService a)
        {
            this.a = a;
        }
        public  ConsultationController(ConsultationService a,DoctorDispService d)
        {
            this.d = d;
            this.a = a;
        }
        // GET: Hotel
        public ActionResult Index()
        {
            var l = a.getAllConsultations();
            return View(l);
        }


        public ActionResult Patientrequest()
        {
            var l = a.getAllConsultations();
            return View(l);
        }

        public ActionResult dispo()
        {
            var l = d.getAlldisps();
            return View(l);
        }
        public ActionResult IndexBack()
        {
            var l = a.getAllConsultations();
            return View(l);
        }

        // GET: Hotel/Details/5
        // GET: Forum/Details/5
        public ActionResult Details(int id)
        {
            demandeconsultationenligne d = a.getConsultationById(id);
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
        public ActionResult Create(demandeconsultationenligne h)
        {
            if (ModelState.IsValid)
            {
                a.addConsultation(h);

                //  return RedirectToAction("Index");
                return View();
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
            demandeconsultationenligne h = a.getConsultationById(id);
            a.deleteConsultationById(id);
            return View(h);
        }

        // POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, demandeconsultationenligne h)
        {
            if (ModelState.IsValid)

                a.addConsultation(h);

            return RedirectToAction("IndexBack");
        }

        // GET: Hotel/Delete/5
        public ActionResult Delete(int id)
        {
            a.deleteConsultationById(id);
            var hs = a.getAllConsultations();
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

        //Chat
        public ActionResult Chat()
        {
            return View();
        }
    }
}
