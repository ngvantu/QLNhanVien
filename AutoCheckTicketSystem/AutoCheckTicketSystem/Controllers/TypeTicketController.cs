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
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TypeTicket type)
        {
            //them vao co so du lieu.
            if (ModelState.IsValid)
            {
                db.type.Add(type);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
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

        [HttpPost]
        public ActionResult Edit(TypeTicket type)
        {
            if (ModelState.IsValid)
            {
                //cập nhật.
                db.Entry(type).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int TypeID)
        {
            TypeTicket type = db.type.Where(x => x.TypeID == TypeID).SingleOrDefault();
            db.type.Remove(type);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}