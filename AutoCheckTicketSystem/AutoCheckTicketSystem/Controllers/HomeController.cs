using AutoCheckTicketSystem.Models.Metadata;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCheckTicketSystem.Controllers
{
    public class HomeController : Controller
    {

        WebAppContext db = new WebAppContext();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var a = db.employee.ToList();
            return View();
        }
    }
}
