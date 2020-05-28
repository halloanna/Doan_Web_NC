using DOAN_WEB_NC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace DOAN_WEB_NC.DAL
{
    public class SchoolContext:DbContext
    {
        public SchoolContext() : base("name=SchoolContext") { }

        public DbSet<User>  Users   { get; set; }
        public DbSet<HoSoHocSinh> HoSoHocSinhs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<ChiTiet_Lop_HocSinh> ChiTiet_Lop_HocSinhs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<BangDiemMonHoc> BangDiemMonHocs { get; set; }
        public DbSet<ChiTietBangDiemMonHoc> ChiTietBangDiemMonHocs { get; set; }

    }
}