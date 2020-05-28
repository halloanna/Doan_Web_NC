using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DOAN_WEB_NC.Models
{
    public class ChiTietBangDiemMonHoc
    {
        [Key]
        public int IDChiTietBangDiemMonHoc { get; set; }

        [ForeignKey("BangDiemMonHoc")]
        public int IDBangDiemMonHoc { get; set; }
        public BangDiemMonHoc BangDiemMonHoc { get; set; }

        [ForeignKey("HoSoHocSinh")]
        public int IDHocSinh { get; set; }
        public HoSoHocSinh HoSoHocSinh { get; set; }
        public float Diem15p { get; set; }
        public float Diem1t { get; set; }
        public float DiemTB { get; set; }
    }
}