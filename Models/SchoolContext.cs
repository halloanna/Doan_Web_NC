using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOAN_WEBNC.Models
{
    public class SchoolContext: DbContext
    {
        public SchoolContext()
        {
            SqlConnectionStringBuilder connectionBuilder = new SqlConnectionStringBuilder();
            connectionBuilder.DataSource = "(local)";
            connectionBuilder.InitialCatalog = "SchoolContext";
            connectionBuilder.IntegratedSecurity = true;
            this.Database.Connection.ConnectionString = connectionBuilder.ConnectionString;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<NamHoc> NamHocs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<LoaiDiem> LoaiDiems { get; set; }
        public DbSet<HocKy> HocKys { get; set; }
        public DbSet<DiemHS> DiemHocSinhs { get; set; }
        public DbSet<ChiTietDiem> ChiTietDiems { get; set; }
    }
}