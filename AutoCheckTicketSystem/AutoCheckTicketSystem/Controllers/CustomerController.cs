using AutoCheckTicketSystem.Models.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCheckTicketSystem.Controllers
{
    public class CustomerController : Controller
    {
        WebAppContext db = new WebAppContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View(db.customer.ToList());
        }

        [HttpGet]
        public ActionResult Edit(int CusID)
        {
            Customer customer = db.customer.Where(x => x.CusID == CusID).SingleOrDefault();
            if (customer == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                //cập nhật.
                db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int CusID)
        {
            Customer customer = db.customer.Where(x => x.CusID == CusID).SingleOrDefault();
            db.customer.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            //them vao co so du lieu.
            if (ModelState.IsValid)
            {
                db.customer.Add(customer);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}