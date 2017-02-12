using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class QuizzController : Controller
    {
        // GET: Quizz
        public ActionResult Quizz()
        {
            return View();
        }
    }
}