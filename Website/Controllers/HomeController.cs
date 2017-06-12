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

        public ActionResult AfspraakMaken(string onderwerp, string naam, string telefoon, string email, string vraag)
        {
            string password = "MH-Coaching_2017";
            MailMessage mail = new MailMessage(email,"info@mh-coaching.nl");
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 25;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential("info@mh-coaching.nl", password);
            smtp.Host = "smtp.mijnhostingpartner.nl";
            mail.IsBodyHtml = false;
            mail.Subject = onderwerp;

            mail.Body = "Hoi Marielle," + Environment.NewLine + "Een nieuwe afspraak van " + naam + " over " + onderwerp + Environment.NewLine + "Vraag: " +
                vraag + Environment.NewLine + "Telefoon: " + telefoon + Environment.NewLine + "Email: " + email + Environment.NewLine + "Met vriendelijke groet " + naam;

            smtp.Send(mail);

            return RedirectToAction("Contact","Home");
        }
    }
}