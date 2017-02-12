using data.Infrastructure;
using data.Models;
using domain.Entities;
using service;
using System;
using Rotativa;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class InsuranceOfferController : Controller
    {
        InsuranceOfferService ause;
        private jpadbContext db = new jpadbContext();
        public InsuranceOfferController(InsuranceOfferService ause)
        {
            this.ause = ause;

        }
        // GET: InsuranceOffer
        public ActionResult Index()
        {
            var l = ause.Getoffers();
            return View(l);
        }
        public ActionResult Indexbackoffice()
        {
            var l = ause.Getoffers();
            return View(l);
        }



        public ActionResult ExportPDF()
        {
            return new ActionAsPdf("Index")
            {
                FileName= Server.MapPath("~/Content/Offer.pdf")


               };
           
        }

        // GET: InsuranceOffer/Details/5
        public ActionResult Details(int id)
        {
            insurance_offer m = db.insurance_offer.Find(id);
            if (m == null)
            {
                return HttpNotFound();
            }
            return View(m);


            insurance_offer p = new insurance_offer();
            p = ause.getOfferById(id);
            return View(p);
        }

        // GET: InsuranceOffer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InsuranceOffer/Create


        [HttpPost]
        public ActionResult Create(insurance_offer of)
        {
        if (ModelState.IsValid)
        {
            ause.CreateOffer(of);
            //ause.Save();
            return RedirectToAction("Indexbackoffice");

        }
        else

            return View();
        }

        // GET: InsuranceOffer/Edit/5
        public ActionResult Edit(int id)
        {
            {
                insurance_offer p = ause.getOfferById(id);
                ause.DeleteOfferById(id);
                return View(p);


            }

        }

        // POST: InsuranceOffer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, insurance_offer p)
        {


            if (ModelState.IsValid)
            {
                ause.CreateOffer(p);
                ause.Save();

            }
            return RedirectToAction("Index");

        }


        // GET: Offer/Delete/5
        public ActionResult Delete(int id)
        {
            ause.DeleteOfferById(id);
            var offers = ause.Getoffers();
            return RedirectToAction("index", offers);
        }

        // POST: InsuranceOffer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, insurance_offer of)
        {
            if (ModelState.IsValid)
            {
                ause.DeleteOffer(of);
                ause.Save();
                return RedirectToAction("Index");
            }


            else

                return View();
        }

    }
}
