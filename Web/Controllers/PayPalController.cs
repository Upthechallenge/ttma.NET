using PayPal.Api;
using System;
using System.Collections.Generic;

using System.Web.Mvc;

using System.Configuration;

using PayPalModule.Models;

namespace PayPalModule.Controllers
{
    [AllowAnonymous]
    public class PayPalController : Controller
    {
        public ActionResult RedirectFromPaypal()
        {
            return View();
        }
        public ActionResult CancelFromPaypal()
        {
            return View();
        }
        public ActionResult NotifyFromPaypal()
        {
            return View();
        }
        public ActionResult ValidateCommand(string product, string totalPrice)
        {
            bool useSandbox = Convert.ToBoolean(ConfigurationManager.AppSettings["IsSandbox"]);
            var paypal = new PayPalModel(useSandbox);
            paypal.item_name = product;
            paypal.amount = totalPrice;
            return View(paypal);
        }

        public ActionResult validate()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }



    }
}