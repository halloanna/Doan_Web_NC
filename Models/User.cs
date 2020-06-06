using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOAN_WEBNC.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên người dùng không được để trống")]
        public string UserName { get; set; }
        [DataType(DataType.Password, ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }
    }
}