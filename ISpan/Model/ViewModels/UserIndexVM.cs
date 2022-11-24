﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISpan.Model.ViewModels
{
        public class UserIndexVM
        {
            public int Id { get; set; }
            public string Account { get; set; }
            // public string Password { get; set; }

            public string Name { get; set; }
        }

        public class UserVM
        {
            public int Id { get; set; }

            //[Required(ErrorMessage = "帳號必填AAA")]
            public string Account { get; set; }


            //[Required(ErrorMessage = "密碼必填EEE")]
            //[EmailAddress(ErrorMessage ="Email格式有誤")]
            public string Password { get; set; }


            //[Required(ErrorMessage = "姓名必填TTTT")]
            //[StringLength(5, ErrorMessage = "姓名長度只能五個字")]
            public string Name { get; set; }
        
        }
}