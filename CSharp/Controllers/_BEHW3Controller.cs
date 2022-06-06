using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class _BEHW3Controller : Controller
    {
        //1.	試寫一撲克牌發牌程式，將52張牌發給四玩家，每家共13張，並利用poker_img資料夾裡的素材來顯示撲克牌。
        //(ps.每次發牌均需為不同結果)
        //陣列放入poker
        //打亂陣列
        //取出poker
        //public int Ran()
        //{
        //    //int number = 0;
        //    //Random r = new Random();//鑄造亂數物件
        //    //number = r.Next(1,53);
        //    //return number;

        //    //int[] poker = new int[53];
        //    ////放入poker
        //    //for (int i = 0; i < 51; i++) {

        //    //    poker[i] = number

        //    //}
        //    ////打亂poker           
            
        //}

        public void DealCard() {
            int number =0;
            Random r = new Random();
            string q = "";

            //將撲克牌放入poker[]陣列
            string[] poker = new string[52];
            for (int i = 0; i < poker.Length; i++) {
                poker[i] = (i + 1).ToString();
                Response.Write("<img src='../poker_img/" + poker[i] + ".gif'/>");
            }

            Response.Write("<hr/>");
            //

            //將poker[]亂數交換
            for (int i = 0; i < poker.Length; i++) {
                number = r.Next(52);                
                q = poker[i];
                poker[i] = poker[number];
                poker[number] = q;
            }
            foreach (var item in poker) {
                Response.Write("<img src='../poker_img/" +item + ".gif'/>");
            }
            Response.Write("<hr />");
            //

            //創建p1~p4[]代表四個玩家
            string[] p1 = new string[13];
            string[] p2 = new string[13];
            string[] p3 = new string[13];
            string[] p4 = new string[13];

            //每個玩家派發13次牌，每次取poker[]1~4，利用int k+= 4變數來推進每輪的poker，
            int k = 0;
            for (int j = 0; j < p1.Length; j++)
            {
                p1[j] = poker[k];
                p2[j] = poker[k + 1];
                p3[j] = poker[k + 2];
                p4[j] = poker[k + 3];
                k += 4;

            }

            Response.Write("<br />" + "第一位");
            foreach (var item in p1)
            {
                Response.Write("<img src='../poker_img/" + item + ".gif'/>");
            }

            Response.Write("<br />" + "第二位");
            foreach (var item in p2)
            {
                Response.Write("<img src='../poker_img/" + item + ".gif'/>");
            }

            Response.Write("<br />" + "第三位");
            foreach (var item in p3)
            {
                Response.Write("<img src='../poker_img/" + item + ".gif'/>");
            }

            Response.Write("<br />" + "第四位");
            foreach (var item in p4)
            {
                Response.Write("<img src='../poker_img/" + item + ".gif'/>");
            }

            ////參考解法 利用餘數不會大於除數的原理，將poker循環分配給四個玩家
            //string p1="", p2="", p3="", p4="";
            //string result = "";
            //for (int i = 0; i < poker.Length; i++) {
            //    result = "<img src='../poker_img/" + poker[i] + ".gif' />";
            //    switch (i % 4) {
            //        case 0:
            //            p1 += result ;
            //            break;
            //        case 1:
            //            p2 += result;
            //            break;
            //        case 2:
            //            p3 += result;
            //            break;
            //        case 3:
            //            p4 += result;
            //            break;
            //    }
            //}
            //Response.Write("<br />玩家一"+p1+"<br />");
            //Response.Write("玩家二" + p2 + "<br />");
            //Response.Write("玩家三" + p3 + "<br />");
            //Response.Write("玩家四" + p4 );


        }
    }
}