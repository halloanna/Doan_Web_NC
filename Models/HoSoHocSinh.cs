using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOAN_WEB_NC.Models
{
    public class HoSoHocSinh
    {
        [Key]
        public int IDHocSinh { get; set; }
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public string Image { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public ICollection<ChiTiet_Lop_HocSinh> ChiTiet_Lop_HocSinhs { get; set; }
        public ICollection<ChiTietBangDiemMonHoc> ChiTietBangDiemMonHocs { get; set; }
    }
}