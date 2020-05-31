using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOAN_WEB_NC.Models
{
    public enum HocKy
    {
        HKI,
        HKII
    }
    public class NamHoc
    {
        [Key]
        public int  IDNamHoc { get; set; }
        public DateTime NamBD { get; set; }
        public DateTime NamKT { get; set; }
        public HocKy HocKy { get; set; }
        public ICollection<BangDiemMonHoc> BangDiemMonHocs { get; set; }
    }
}