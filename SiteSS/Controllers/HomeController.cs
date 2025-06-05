using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteSS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Destaques()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Galeria()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Orcamento()
        {
           
            return View();
        }
    }
}