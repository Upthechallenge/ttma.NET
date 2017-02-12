using domain.Entities;
using Rotativa;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class OfferController : Controller
    {
        OfferService a;
        public OfferController(OfferService a)
        {
            this.a = a;
        }
        // GET: Hotel
        public ActionResult Index()
        {
            var l = a.getAllOffers();
            return View(l);
        }
        public ActionResult IndexBack()
        {
            var l = a.getAllOffers();
            return View(l);
        }
        // GET: Hotel/Details/5
        public ActionResult Details(int id)
        {

            operation  d = a.getOfferById(id);
            if (d == null)
            {
                return HttpNotFound();
            }
            return View(d);
        }
        public ActionResult DetailsofferChosen(int id)
        {

            operation d = a.getOfferById(id);
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
        public ActionResult Create(operation h)
        {
            if (ModelState.IsValid)
            {
                a.addOffer(h);

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
            operation h = a.getOfferById(id);
            a.deleteOfferById(id);
            return View(h);
        }

        // POST: Hotel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, operation h)
        {
            if (ModelState.IsValid)

                a.addOffer(h);

            return RedirectToAction("IndexBack");
        }

        // GET: Hotel/Delete/5
        public ActionResult Delete(int id)
        {
            a.deleteOfferById(id);
            var hs = a.getAllOffers();
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

        public ActionResult Statistiques()
        {
            int bs = a.countAllbreastSurgery();
            int fs = a.countAllFaceSurgery();
            int ts = a.countAllSurgeryteeth();
            int ps = a.countAllSurgeryplastic();
            int ins = a.countAllintimateSurgery();
            int gb = a.countAllgastricsBand();


            ViewBag.nbbreast = bs.ToString();
            ViewBag.nbface = fs.ToString();
            ViewBag.nbteeth = ts.ToString();
            ViewBag.nbplas = ps.ToString();
            ViewBag.nbins = ins.ToString();
            ViewBag.nbgb = gb.ToString();


            return View();
        }




        public ActionResult ExportPDF()
        {
            return new ActionAsPdf("Index")
            {
                FileName = Server.MapPath("~/Content/Offers.pdf")
            };

        }


    }


}
