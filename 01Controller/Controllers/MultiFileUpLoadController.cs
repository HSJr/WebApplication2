using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01Controller.Controllers
{
    public class MultiFileUpLoadController : Controller
    {
        // GET: MultiFileUpLoad
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase[] photo)
        {

            
                for (int i = 0; i < photo.Length; i++) {
                if (photo[i] != null)
                {
                    if (photo[i].ContentLength > 0 && photo[i].ContentLength <= 1048576)
                    {
                        photo[i].SaveAs(Server.MapPath("~/photos/" + photo[i].FileName));
                        // "~/photos/"+photo.FileName
                        ViewBag.Message = "上傳成功";
                    }
                    else
                    {
                        ViewBag.Message = "檔案過大上傳失敗";
                    }
                }            else
            {
                ViewBag.Message = "部分檔案上傳";
            }
                }
                

            return View();
        }

        public string ShowPhoto()
        {
            DirectoryInfo d = new DirectoryInfo(Server.MapPath("~/photos/"));
            FileInfo[] files = d.GetFiles();
            string show = "<a href='../MultiFileUpLoad/Create'>回上傳頁面</a><hr>";

            foreach (FileInfo item in files)
            {
                show += "<img src='../photos/" + item.Name + "' width=300/>";
            }

            return show;
        }
    }
}