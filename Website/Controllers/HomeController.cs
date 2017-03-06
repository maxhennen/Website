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

        public ActionResult AfspraakMaken(string onderwerp, string naam, long telefoon, string email, string vraag)
        {
            MailMessage mail = new MailMessage(email, "max.hennen@planet.nl");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.kpnmail.nl";
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            client.Send(mail);
            return RedirectToAction("Contact","Home");
        }
    }
}