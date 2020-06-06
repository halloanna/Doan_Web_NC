using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DOAN_WEBNC.Models
{

    public class ChiTietDiem
    {
        [ForeignKey("DiemHS")]
        [Key, Column(Order = 1)]
        public string MaBangDiem { get; set; }
        [ForeignKey("LoaiDiem")]
        [Key, Column(Order = 2)]
        public string IDLoaiDiem { get; set; }
        [Key, Column(Order = 3)]
        public int LanThi { get; set; }
        [Required(ErrorMessage = "Điểm không được phép để trống")]
        [Range(0, 10, ErrorMessage = "Điểm phải nằm trong khoảng 0 - 10")]
        public double Diem { get; set; }

        public DiemHS DiemHS { get; set; }
        public LoaiDiem LoaiDiem { get; set; }
    }
}