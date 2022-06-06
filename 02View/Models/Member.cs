using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _02View.Models
{
    public class Member
    {
        /*需引入using System.ComponentModel;才能使用下面定義*/
        [DisplayName("使用者帳號")]/*寫在UserId上面，定義UserId在網頁上的顯示*/
        
        [Required] /*寫在UserId上面，定義UserId為必填欄位*/
        public string UserId { get; set; }

        [DisplayName("使用者密碼")]
        public string Pwd { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}