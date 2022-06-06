using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp.Controllers
{
    public class _BEHW2Controller : Controller
    {
        //        1.	質數判斷(必須用回圈，不得使用陣列)
        //請宣告一個整數變數，值由參數傳入，並判斷其是否為質數，若是，請在螢幕顯示「○○是質數」，
        //若不是，請在螢幕顯示「○○不是質數」。如例變數值為13，即顯示「13是質數」。(ps.質數的定義為除了1與本身之外，
        //沒有其他的因數存在)
        public string HW01(int n)
        {
            string a = "";
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    a = n + "不是質數";
                    return a;
                }
            }
            a = n + "是質數";
            return a;
        }
        //老師解法
        //        for (int i = 2; i<n; i++){
        //             if (n % i == 0){
        //                    return n + "不是質數";
        //             }
        //        }
        //        return n + "是質數";

        //2.	求最大公因數(必須用回圈，不得使用陣列)
        //請宣告兩個整數變數，值由參數傳入，求其兩數之最大公因數，並在螢幕顯示「○○與○○之最大公因數為○○」。
        //如例變數值為12及18，即顯示「 12及18 之最大公因數為6」（ps.最大公因數的定義為某幾個整數所共同擁有的最大因數）
        public string HW02(int a, int b)
        {
            //a%a--==0 b % b-- == 0;

            //第一種寫法
            int j = 0;
            if (a > b) j = a; else j = b;
            for (int i = j - 1; i > 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return a + "與" + b + "之最大公因數為" + i;
                }
            }
            return "1";


            //

            //1 = 4 % 3
            //第二種寫法
            //int n = 1;
            //while (n != 0)
            //{
            //    //餘數=被除數/除數
            //    n = a % b;
            //    if (n == 0)
            //    {
            //        return a + "與" + b + "之最大公因數是" + b;
            //    }
            //    a = b;
            //    b = n;
            //    //}
            //}
            //return "1";

            //老師解法
            //int M = m, N = n;
            //int z = 0;
            //while (M % N != 0) {
            //    z = M % N;
            //    M = N;
            //    N = z;
            //}
            //return m + "與" + n + "之最大公因數為" + z;
        }

        //        3.	迴文判斷(必須用回圈，不得使用陣列)
        //請宣告一個整數變數，值由參數傳入，判斷其是否為迴文，若是，請在螢幕顯示「○○○○是迴文」，
        //若不是，請在螢幕顯示「○○不是迴文」。如例變數值為12321，即顯示「12321是迴文」。
        //(ps.迴文的定義為一個數字，由左唸至右及由右唸至左時，皆一模一樣)

        public void HW03(int n)
        {
            //怎麼把數字倒過來??
            int m = n;
            int a = 0;
            int sum = 0; /*;123321*/
            while (m > 0) {            
            a=m % 10; /*n=123321 a=1*/
            m=m / 10; /*n=123321 b=12332*/   
            sum = sum * 10+a;
                //Response.Write(sum+"<br>");
            }
            if (sum == n)
            {
                Response.Write(n + "是迴文");
            }
            else {Response.Write(n+"不是迴文");    }

            //老師解法
            //int N = n, result = 0;
            //int q = 0, r = 0;


            //do
            //{
            //    r = N % 10;
            //    q = N / 10;
            //    N = q;

            //    result *= 10;
            //    result += r;
            //} while (q != 0);

            //if (n == result)
            //    return n + "是迴文";

            //return n + "不是迴文";

            //int i = 0;
            //while (n < 1)
            //{
            //    n
            //    i++;

            //}
            //Response.Write(i);
        }

    }

}

    
