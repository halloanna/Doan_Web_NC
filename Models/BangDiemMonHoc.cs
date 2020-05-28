using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace DOAN_WEB_NC.Models
{
    public class BangDiemMonHoc
    {
        [Key]
        public int IDBangDiem { get; set; }


        [ForeignKey("MonHoc")]
        public int IDMonHoc { get; set; }
        public MonHoc MonHoc { get; set; }

        [ForeignKey("Lop")]
        public int IDLop { get; set; }
        public Lop Lop { get; set; }

        public ICollection<ChiTietBangDiemMonHoc> ChiTietBangDiemMonHocs { get; set; }
    }
}