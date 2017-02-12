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
    public class TimetableController : Controller
    {
        TimetableService a;
        public TimetableController(TimetableService a)
        {
            this.a = a;
        }
        // GET: Timetable hedhi
        public ActionResult Index()
        {

            var l = a.getAllTimetable();
            return View(l);
        }
        public ActionResult IndexBack()
        {

            var l = a.getAllTimetable();
            return View(l);
        }

        // GET: Timetable/Details/5 /
        public ActionResult Details(int id)
        {
            timetable c = a.getTimetableById(id);
            if (c==null)
            { return HttpNotFound(); }
            return View(c);
        }

        // GET: Timetable/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Timetable/Create
        [HttpPost]
        public ActionResult Create(timetable h)
        {
            if (ModelState.IsValid)
            {
                a.addTimetable(h);

                return RedirectToAction("IndexBack");
            }


            else

                return View();
        }

        // GET: Timetable/Edit/5
        public ActionResult Edit(int id)
        {
            timetable h = a.getTimetableById(id);
            a.deleteTimetableById(id);
            return View(h);
        }

        // POST: Timetable/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, timetable h)
        { try {
                // if (ModelState.IsValid)

                //  a.addConge(h);

                return RedirectToAction("Index"); }
            catch { return View(); }
        }


        // GET: Timetable/Delete/5
        public ActionResult Delete(int id)
        {
            a.deleteTimetableById(id);
            var hs = a.getAllTimetable();
            return RedirectToAction("Index", hs);
        }

        // POST: Timetable/Delete/5
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

        public ActionResult ExportPDF()
        {
            return new ActionAsPdf("Index")
            {
                FileName = Server.MapPath("~/Content/Timetable.pdf")
            };

        }
    }

}
