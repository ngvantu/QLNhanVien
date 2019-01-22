using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCheckTicketSystem.Controllers
{
    public class TypeTicketController : Controller
    {
        WebAppContext db = new WebAppContext();

        // GET: TypeTicket
        public ActionResult Index()
        {
            return View(db.type.ToList());
        }
    }
}