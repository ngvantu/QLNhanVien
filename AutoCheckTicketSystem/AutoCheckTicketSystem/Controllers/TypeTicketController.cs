using AutoCheckTicketSystem.Models.Metadata;
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

        [HttpGet]
        public ActionResult Edit(int TypeID)
        {
            TypeTicket type = db.type.Where(x => x.TypeID == TypeID).SingleOrDefault();
            if (type == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(type);
        }
    }
}