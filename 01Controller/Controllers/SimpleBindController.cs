using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01Controller.Controllers
{
    public class SimpleBindController : Controller
    {
        //Actoin
        // GET: SimpleBind
        public ActionResult Create()
        {
            //ViewBag.Date=DateTime.Now;
            return View();
        }


        [HttpPost]
        public ActionResult Create(string Pid,string PName,int Price)
        {
            ViewBag.Pid = Pid;
            ViewBag.PName = PName;
            ViewBag.Price = Price; 
            return View();
        }
    }
}