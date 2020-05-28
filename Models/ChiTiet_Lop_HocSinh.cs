using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DOAN_WEB_NC.Models
{
    public class ChiTiet_Lop_HocSinh
    {
        [Key]
        public int IDChiTiet_Lop_HocSinh { get; set; }
        //hosinh
        [ForeignKey("HoSoHocSinh")]
        public int IDHocSinh { get; set; }
        public HoSoHocSinh HoSoHocSinh { get; set; }

        //lop
        [ForeignKey("Lop")]
        public int IDLop { get; set; }
        public Lop Lop { get; set; }

        public float TBHKI { get; set; }
        public float TBHKII { get; set; }
   
    }
}