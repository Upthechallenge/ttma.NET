using domain.Entities;
using service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Web.Controllers
{
    public class InsuranceAgentController : Controller
    {
       
        IInsuranceOfferService ios;
        IStaffService ause;
        public InsuranceAgentController(IStaffService ause)
        {
            this.ause = ause;

        }
        public InsuranceAgentController()
        {
         

        }

        public InsuranceAgentController(IStaffService ause, IInsuranceOfferService ios)
        {
            this.ause = ause;
            this.ios = ios;

        }

        public ActionResult Statistiques()
        {
            int pn = ause.countStaff();
         
            int on = ios.countOffer();


          
            ViewBag.nbpacks = pn.ToString();
            ViewBag.nboffers = on.ToString();



            return View();
        }

        // GET: InsuranceAgent
        public ActionResult Index()
          {
              List<staff> users = ause.getAllUsers();
              List<staff> insuranceAgents = new List<staff>();
              foreach (staff u in users)
              {
                  if (u.DTYPE == "isinsurer")
                  {
                      insuranceAgents.Add(u);
                  }
              }

              return View(insuranceAgents);
          }

        // GET: InsuranceAgent/Details/5
        public ActionResult Details(int id)
         {
             ViewData["DetailInfo"] = id;
             foreach (staff u in ause.getAllUsers())
             {
                 if ((u.DTYPE == "isinsurer") && (u.id == id))
                 {
                     return View(u);
                 }
             }
             return Index();
         }

         // GET: InsuranceAgent/Create
         public ActionResult Create()
         {
             return View();
         }
       
         // POST: InsuranceAgent/Create
         [HttpPost]
         public ActionResult Create(staff a)
         {
             if (ModelState.IsValid)
             {
                 a.DTYPE = "isinsurer";


                 ause.AddUser(a);
                 return RedirectToAction("Index");
             }


                 return View();

         }
        [HttpPost]
        public ActionResult Createe(staff a)
        {
            if (ModelState.IsValid)
            {
                a.DTYPE = "isinsurer";


                ause.AddUser(a);
                return RedirectToAction("Index");
            }


            return View();

        }

        // GET: InsuranceAgent/Edit/5
        public ActionResult Edit(int id)
         {
             staff u = new staff();
             foreach (staff i in ause.getAllUsers())
             {
                 if (i.id == id)
                 {
                     u = i;

                 }

             }
             ause.DeleteUserById(id);

             return View(u);
         }

         // POST: InsuranceAgent/Edit/5
         [HttpPost]
         public ActionResult Edit(int id, staff u)
         {
             if (ModelState.IsValid)
             {
                 u.DTYPE = "isinsurer";


                 ause.AddUser(u);


             }
             List<staff> insurers = new List<staff>();
             foreach (staff v in ause.getAllUsers())
             {
                 if (v.DTYPE == "isdoctor")
                 {
                     insurers.Add(v);
                 }
             }
             return RedirectToAction("Index", insurers);
         }

         // GET: InsuranceAgent/Delete/5
         public ActionResult Delete(int id)
         {
            staff u = new staff();
            foreach (staff i in ause.getAllUsers())
             {
                 if (i.id == id)
                 {
                     u = i;
                 }
             }
            ause.DeleteUserById(id);


             return View(u);
         }

         // POST: InsuranceAgent/Delete/5
         [HttpPost]
         public ActionResult Delete(int id, staff u)
         {
             ause.DeleteUserById(id);
             List<staff> users = ause.getAllUsers();
             List<staff> insurers = new List<staff>();
             foreach (staff i in users)
             {
                 if (u.DTYPE == "isinsurer")
                 {
                     insurers.Add(i);
                 }
             }
             return RedirectToAction("Index", insurers);
         }
     }
    }
