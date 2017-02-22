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
    public class DoctorController : Controller
    {
        DoctorService a;
       // IDoctorService b;
        public DoctorController(DoctorService a)
        {
            this.a = a;
        }
        // GET: Hotel
        public ActionResult Index()
        {
            var l = a.getAllDoctors();
            return View(l);
        }

        

               public ActionResult IndexBack()
        {
            var l = a.getAllDoctors();
            return View(l);
        }

        // GET: Hotel/Details/5
        public ActionResult Details(int id)
        {
            doctor d = a.getDoctorById(id);
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
        public ActionResult Create(doctor h)
        {
            if (ModelState.IsValid)
            {
                a.addDoctor(h);

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
            doctor h = a.getDoctorById(id);
            a.deleteDoctorById(id);
            return View(h);
        }

        // POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, doctor h)
        {
            if (ModelState.IsValid)

                a.addDoctor(h);

            return RedirectToAction("IndexBack");
        }

        // GET: Hotel/Delete/5
        public ActionResult Delete(int id)
        {
            a.deleteDoctorById(id);
            var hs = a.getAllDoctors();
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




        public ActionResult Statisticsdoctors()
        {
            ViewData["ADHD"] = a.countDoctors();
            ViewData["Neurophysicology"] = a.countDoctors();
            ViewData["Eating_disorder"] = a.countDoctors();
            ViewData["Trauma"] = 0;
            ViewData["Phobias"] = 5;
            ViewData["Sexology"] = 8;

            return View();
        }


        public ActionResult Statistiques()
        {
            int pn = a.countDoctors();
            //int hn = hs.countHotels();
            //int cn = cs.countClinics();
            //int on = ios.countOffer();


            ViewBag.nbhotels = pn.ToString();
            //ViewBag.nbpacks = pn.ToString();
            //ViewBag.nbclinics = cn.ToString();
            //ViewBag.nboffers = on.ToString();



            return View();
        }
    }
}
