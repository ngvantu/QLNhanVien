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
            var listUser = db.employee.Where(x=>x.IsUsed == true).ToList();
            return View(listUser);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee user)
        {
            //them vao co so du lieu.
            if (ModelState.IsValid)
            {
                //luu ten cua file.
                //var fileName = Path.GetFileName(fileUpload.FileName);
                //luu duong dan cua file.
                //var path = Path.Combine(Server.MapPath("~/HinhAnhSP"), fileName);
                //kiem tra hinh anh da ton tai chua.
                //if (System.IO.File.Exists(path))
                //{
                //    ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                //}
                //else
                //{
                //    fileUpload.SaveAs(path);
                //}
                //sach.AnhBia = fileUpload.FileName;
                db.employee.Add(user);
                db.SaveChanges();
            }
            return View();
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
            ViewBag.ImageID = user.ImageID;
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(Employee user)
        {
            if(ModelState.IsValid)
            {
                //cập nhật.
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public ActionResult Delete(int EmployeeID)
        {
            Employee user = db.employee.Where(x => x.EmployeeID == EmployeeID).SingleOrDefault();
            user.IsUsed = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}