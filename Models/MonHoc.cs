using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace DOAN_WEB_NC.Models
{
    public class MonHoc
    {
        [Key]
        public int IDMonHoc { get; set; }
        public string TenMonHoc { get; set; }

        public ICollection<BangDiemMonHoc> BangDiemMonHocs { get; set; }
    }
}