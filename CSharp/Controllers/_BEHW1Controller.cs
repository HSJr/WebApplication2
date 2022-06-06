using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class _BEHW1Controller : Controller
    {
        //ab+-*/%
        public void HW01() {
       
            int a = 42;
            float b = 2.5f;

            Response.Write("a=" + a + "</br>b=" + b + "</br>a+b=" + (a + b) + "</br>a-b=" + (a - b) + "</br>a*b=" + (a * b) + "</br>a/b=" + (a / b) + "</br>a%b=" + (a % b));
            //要注意隱含轉換的順序
        }

        //華氏＝攝氏*9/5+32
        public int HW02(int Celsius)
        {
            //溫度有小數點 要用float or double
            int Fahrenheit = Celsius * 9 / 5 + 32;
            return Fahrenheit;
        }

        //3.	設有兩個變數X與Y，其值為任何整數，試寫在不另宣告其他變數的情況下，交換X與Y的值的程式，
        //X與Y的值須由參數傳入。 (例X=3,Y=5，執行完您的程式後X=5,Y=3)

        public void HW03(int x, int y) {
            //^為位元運算的XOR
            //x=x^y;
            //y=x^y;
            //x=x^y;
            

            x +=y;
            y = x - y;
            x -=y;

            Response.Write("x=" + x + "y=" + y);
        }

        //4.	請利用switch敘述，分別試寫判斷成績等第之程式。90分以上為優等，80~89為甲等，70~79為乙等，60~69為丙等，
        //其餘為丁等，成績的值須由參數傳入(不必判斷值的合理性, 但亦不可另外搭配if 敘述句)。
        
        //JS



        public void HW04(uint score) {
            score = score / 10;
            switch (score) {
                case 7:
                    Response.Write("乙等");
                    break;
                case 8:
                    Response.Write("甲等");
                    break;
                case 6:
                    Response.Write("丙等");
                    break;
                case 5:
                    Response.Write("丁等");
                    break;
                case 4:
                    Response.Write("丁等");
                    break;
                case 3:
                    Response.Write("丁等");
                    break;
                case 2:
                    Response.Write("丁等");
                    break;
                case 1:
                    Response.Write("丁等");
                    break;
                case 0:
                    Response.Write("丁等");
                    break;

                default:
                    Response.Write("優等");
                    break;
            }
        }

        //5.	請利用回圈敘述寫一顯示1~Ｎ的整數中，不是5的倍數的程式，並輸出其結果，Ｎ的值須由參數傳入。
        public void HW05 (int n){
            for(int i=0; i<=n ;i++){                
                if(i%5 != 0){
                Response.Write(i+"</br>");
                } 
            }
        }

        //6.	請利用回圈敘述計算1~N的整數中，除了3倍數以外所有數的總合，並輸出其結果，Ｎ的值須由參數傳入。
        public int HW06(int n) {
            int sum=0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 != 0)
                {
                    sum += i;                    
                }
            }
            return sum;
        }


        //7.	請利用while敘述顯示出下方圖形，最後一列的＊數量為Ｎ，Ｎ的值須由參數傳入。(不可以使用巢狀回圈)
        public void HW07(int n) {
            string star="";
            int i = 0;
            while (i < n) {
                star += "*";
                Response.Write(star+"<br>");
                i++;
            }        
        }
        //8.	請利用回圈敘述寫一九九乘法表，並輸出其結果，畫面不限。
        public void HW08() {
            for (int i = 1; i <= 9; i++) {
                for (int j = 1; j <= 9; j++) {
                Response.Write(i+"*"+j+"="+i*j+"　");                
                }
                Response.Write("<br><hr>");                
            }            
        }

///*        public void Random01() */{
//            //int ran1=0;
//            //int ran2=0;
//            //int[] a = [1, 5, 3];

//            ////while (ran1 == ran2)
//            ////{
//            ////    ran1 = Math.Floor(Math.Random() * 30) + 1;
//            ////    ran2 = Math.Floor(Math.Random() * 30) + 1;
//            ////    Math.r
//            ////}

//            Response.Write("<h1>班會主持：" + ran1 + "</h1>" + "<h1>班會紀錄：" + ran2 + "</h2>");
//        }
    }
}