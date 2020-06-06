using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DOAN_WEBNC.Models
{
    public class HocSinh
    {
        [Key]
        public string IDHocSinh { get; set; }
        [Required(ErrorMessage = "Tên Học Sinh không được để trống")]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "Giới tính không được để trống")]
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.ImageUrl)]

        public Lop Lop { get; set; }
        public string IDLop { get; set; }

        public string Image { get; set; }
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }

    }
}