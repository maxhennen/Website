using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Solliciteren()
        {
            return View();
        }

        public ActionResult Studiekeuzeadvies()
        {
            return View();
        }

        public ActionResult Loopbaancoaching()
        {
            return View();
        }

        public ActionResult AfspraakMaken(string onderwerp, string naam, long telefoon, string email, string vraag)
        {
            MailMessage mail = new MailMessage(email,"max.hennen@planet.nl");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("hennenmax@gmail.com", "Eussenstraat52");
            smtp.Host = "smtp.gmail.com";
            mail.Subject = onderwerp;
            mail.Body = vraag;
            smtp.Send(mail);

            return RedirectToAction("Contact","Home");
        }
    }
}