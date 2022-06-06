using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _03Model.Models;

namespace _03Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string ShowAryDesc()
        {
            int[] score = { 78, 90, 20, 100, 66 };
            string show = "";
            //LinQ查詢運算式寫法
            //var result=from s in score
            //           orderby s descending
            //           select s;
            //LinQ
            var result = score.OrderByDescending(s => s);
                            //function(s){ return s}
            //SQL
            //select s from score order by s desc
            foreach(var item in result)
            {
                show += item+",";

            }

            return show;
        }

        public string ShowAryAsc()
        {
            int[] score = { 78, 90, 20, 100, 66 };
            string show = "";
            //LinQ查詢運算式寫法
            //var result = from s in score
            //             orderby s ascending//ascendin 可省略
            //             select s;


            //LinQ擴充方法的寫法
            //var result = score.OrderByDescending(s => s);
            var result = score.OrderBy(s=>s);
            //function(s){ return s}
            //SQL
            //select s from score order by s desc
            foreach (var item in result)
            {
                show += item + ",";
            }
            show += "<hr>";
            show += "成績平均" + result.Average();
            show += "<hr>";
            show += "成績總和" + result.Sum();

            return show;
        }

        public string LoginMember(string uid,string pwd) {
            Member member = new Member();
            //類別 物件 =建構子
            //食譜 菜名 =方法
            //member.UId = "tom";
            //member.Pwd = "123";
            //member.Name = "湯姆";
            //Member member2 = new Member();
            //member2.UId = "jsper";
            //member2.Pwd = "456";
            //member2.Name = "賈斯柏";
            //Member member3 = new Member();
            //member3.UId = "mary";
            //member3.Pwd = "789";
            //member3.Name = "瑪莉";

            Member[] members = new Member[] {
            new Member {UId ="tom", Pwd="123",Name ="湯姆"},
            new Member {UId ="jsper", Pwd="456",Name ="賈斯柏"},
            new Member {UId ="mary", Pwd="789",Name ="瑪莉"},
            };

            //sql
            //select * form members where UId="tom" and Name="湯姆"
            //LinQ
            //var result = (from m in members
            //             where m.UId == uid && m.Pwd == pwd
            //             select m).FirstOrDefault();
            var result=members.Where(m=>m.UId==uid && m.Pwd==pwd).FirstOrDefault();

            string show = "";
            if (result != null) {
                show = "歡迎" + result.Name + "進入本系統";
            } else { show = "帳號或密碼錯誤"; }

            return show;
        }
    }
}