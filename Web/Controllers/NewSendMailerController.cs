using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class NewSendMailerController : Controller
    {
        //
        // GET: Offer/NewSendMailer/
        public ActionResult Indexx()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Indexx(Web.Models.MailModel _objModelMail)
        {
            if (ModelState.IsValid)
            {
                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(_objModelMail.To);
                mail.From = new MailAddress(_objModelMail.From);
                mail.Subject = _objModelMail.Subject;
                string Body = _objModelMail.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("ttma.esprit@gmail.com", "22207556");// Enter seders User name and password
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Indexx", _objModelMail);
            }
            else
            {
                return View();
            }
        }
    }
}