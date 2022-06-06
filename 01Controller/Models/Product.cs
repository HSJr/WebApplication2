using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01Controller.Models
{
    public class Product //商品實體
    {
        public string Pid { get; set; }//產品屬性
        public string PName { get; set; }
        public int Price { get; set; }


    }
}