using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCheckTicketSystem.Controllers
{
    public class HomeController : Controller
    {
        Models.Entities.Employee employee = new Models.Entities.Employee();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            return View();
        }
    }
}
