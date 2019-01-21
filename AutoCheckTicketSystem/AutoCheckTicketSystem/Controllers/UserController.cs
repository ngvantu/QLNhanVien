using AutoCheckTicketSystem.Models.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCheckTicketSystem.Controllers
{
    public class UserController : Controller
    {
        WebAppContext db = new WebAppContext();
        // GET: /User/
        public ActionResult Index()
        {
            var listUser = db.employee.ToList();
            return View(listUser);
        }

        [HttpGet]
        public ActionResult Edit(int EmployeeID)
        {
            Employee user = db.employee.Where(x => x.EmployeeID == EmployeeID).SingleOrDefault();
            if(user == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(user);
        }
	}
}