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

        public ActionResult Tarieven()
        {
            return View();
        }

        public ActionResult OverMij()
        {
            return View();
        }

        public ActionResult AfspraakMaken(string onderwerp, string naam, long telefoon, string email, string vraag)
        {
            string password = "MH-Coaching_2017";
            MailMessage mail = new MailMessage(email,"info@mh-coaching.nl");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 25;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("info@mh-coaching.nl", password);
            smtp.Host = "smtp.mijnhostingpartner.nl";
            mail.Subject = onderwerp;
            mail.Body = vraag;
            smtp.Send(mail);

            return RedirectToAction("Contact","Home");
        }
    }
}