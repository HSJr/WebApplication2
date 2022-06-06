using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01Controller.Controllers
{
    public class HomeController : Controller
    {

        //修飾詞 public公開 protected保護 private私有
        public string ShowAry() {
            int[] score = { 10, 80, 60, 55, 101 };
            int sum = 0;
            string s = "";
            foreach (int a in score) {
                sum += a;
                s += a + ",";
            }
            s += "總成績為:" + sum;
            return s;
        
        }


        public string ShowImage() {
            string show = "";
            for (int i = 1; i <= 8; i++) {
                show += "<a href='ShowImageIndex?index="+i+"'><img src='../images/" + i + ".jpg' width=300/></a>";
            }
            return show;
        
        }

        public string ShowImageIndex(int index) {
            string show = "";
            string[] name = { "櫻桃鴨", "鴨油高麗菜", "鴨油麻婆豆腐", "櫻桃鴨握壽司", "片皮鴨捲三星蔥", "三杯鴨", "櫻桃鴨片肉", "慢火白菜燉鴨湯" };
            //一般寫法
            //show = "<p style='text-align:center'><img src='../images/" + index + ".jpg' /><h3 style='text-align:center'>" + name[index-1]+"</h3></p>";

            //字串格式化寫法
            show = string.Format("<a href='ShowImageIndex?index={2}'><p style='text-align:center'><img src='../images/{0}.jpg' /><h3 style='text-align:center'>{1}</h3></p></a>", index, name[index - 1],index+1);

            show += "<br><a href='ShowImage'>回菜菜列表</a>";

            //show = "<img src='../images/" + index + ".jpg'>";
            return show;
        
        }


       
    }
}