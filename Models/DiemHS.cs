using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DOAN_WEBNC.Models
{
    public class DiemHS
    {
        [Key]
        public string MaBangDiem { get; set; }
        [ForeignKey("HocSinh")]
        [Required(ErrorMessage = "Học sinh không được để trống")]
        public string MaHocSinh { get; set; }
        public HocSinh HocSinh { get; set; }
        [ForeignKey("MonHoc")]
        [Required(ErrorMessage = "Môn học không được để trống")]
        public string MaMonHoc { get; set; }
        public MonHoc MonHoc { get; set; }
        [ForeignKey("HocKy")]
        [Required(ErrorMessage = "Học kỳ không được để trống")]
        public string IDHocKy { get; set; }
        public HocKy HocKy { get; set; }
        public ICollection<ChiTietDiem> ChiTietDiems{ get; set; }
    }
}