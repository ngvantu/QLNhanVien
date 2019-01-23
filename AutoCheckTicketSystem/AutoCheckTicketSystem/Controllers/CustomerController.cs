using AutoCheckTicketSystem.Models.Metadata;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;

namespace AutoCheckTicketSystem.Controllers
{
    public class CustomerController : Controller
    {
        WebAppContext db = new WebAppContext();
        // GET: Customer
        public ActionResult Index(int? page)
        {
            int pageNum = (page ?? 1);
            int pageSize = 1;      // sô customer trên 1 trang
            return View(db.customer.OrderBy(n=>n.CusID).ToPagedList(pageNum, pageSize));
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