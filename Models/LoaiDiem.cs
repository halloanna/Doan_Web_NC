using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOAN_WEBNC.Models
{
    public class LoaiDiem
    {
        //Không cần tạo View Mieng / 15p /1tiet / thi/ chuyen can
        [Key]
        public string IDLoaiDiem { get; set; }
        public string TenLoai { get; set; }
        public ICollection<ChiTietDiem> ChiTietDiems { get; set; }
    }
}