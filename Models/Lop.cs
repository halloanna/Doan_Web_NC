using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOAN_WEB_NC.Models
{
    public class Lop
    {
        [Key]
        public int IDLop { get; set; }
        public int SiSo { get; set; }
        public int SLDat { get; set; }
        public int TiLe { get; set; }
        
        public ICollection<ChiTiet_Lop_HocSinh> ChiTiet_Lop_HocSinhs { get; set; }
        public ICollection<BangDiemMonHoc> BangDiemMonHocs { get; set; }
    }
}