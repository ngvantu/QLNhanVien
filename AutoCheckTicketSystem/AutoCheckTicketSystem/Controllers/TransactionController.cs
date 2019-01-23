using AutoCheckTicketSystem.Models.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoCheckTicketSystem.Controllers
{
    public class TransactionController : Controller
    {
        WebAppContext db = new WebAppContext();
        // GET: Transaction
        public ActionResult Index()
        {
            List<Transaction> listTrans = db.transactions.ToList();
           
            return View(listTrans);
        }

        //string[] GetType(List<Transaction> List)
        //{
        //    TypeTicket type = db.type.Where(x => x.TypeID == typeID);
        //    return type.TypeName;
        //}
    }
}