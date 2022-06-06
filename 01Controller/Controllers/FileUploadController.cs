using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//要上傳檔案要引入System.IO
using System.IO;


namespace _01Controller.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase photo)
        {

            if (photo != null)
            {
                if (photo.ContentLength > 0 && photo.ContentLength <= 1048576)
                {
                    photo.SaveAs(Server.MapPath("~/photos/" + photo.FileName));
                    // "~/photos/"+photo.FileName
                    ViewBag.Message = "上傳成功";
                }
                else {
                    ViewBag.Message = "檔案過大上傳失敗";
                }
            }
            else {
                ViewBag.Message = "沒有上傳任何檔案";
            }
            return View();
        }

        public string ShowPhoto() {
            DirectoryInfo d = new DirectoryInfo(Server.MapPath("~/photos/"));
            FileInfo[] files=d.GetFiles();
            string show = "<a href='../FileUpLoad/Create'>回上傳頁面</a><hr>";

            foreach (FileInfo item in files) {
                show += "<img src='../photos/" + item.Name + "' width=300/>";
            }
            
            return show;
        }
    }
}