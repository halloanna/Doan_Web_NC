namespace DOAN_WEBNC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _CreateDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDiems",
                c => new
                    {
                        MaBangDiem = c.String(nullable: false, maxLength: 128),
                        IDLoaiDiem = c.String(nullable: false, maxLength: 128),
                        LanThi = c.Int(nullable: false),
                        Diem = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaBangDiem, t.IDLoaiDiem, t.LanThi })
                .ForeignKey("dbo.DiemHS", t => t.MaBangDiem, cascadeDelete: true)
                .ForeignKey("dbo.LoaiDiems", t => t.IDLoaiDiem, cascadeDelete: true)
                .Index(t => t.MaBangDiem)
                .Index(t => t.IDLoaiDiem);
            
            CreateTable(
                "dbo.DiemHS",
                c => new
                    {
                        MaBangDiem = c.String(nullable: false, maxLength: 128),
                        MaHocSinh = c.String(nullable: false, maxLength: 128),
                        MaMonHoc = c.String(nullable: false, maxLength: 128),
                        IDHocKy = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MaBangDiem)
                .ForeignKey("dbo.HocKies", t => t.IDHocKy, cascadeDelete: true)
                .ForeignKey("dbo.HocSinhs", t => t.MaHocSinh, cascadeDelete: true)
                .ForeignKey("dbo.MonHocs", t => t.MaMonHoc, cascadeDelete: true)
                .Index(t => t.MaHocSinh)
                .Index(t => t.MaMonHoc)
                .Index(t => t.IDHocKy);
            
            CreateTable(
                "dbo.HocKies",
                c => new
                    {
                        IDHocKy = c.String(nullable: false, maxLength: 128),
                        TenHocKy = c.Int(nullable: false),
                        IDNamHoc = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IDHocKy)
                .ForeignKey("dbo.NamHocs", t => t.IDNamHoc)
                .Index(t => t.IDNamHoc);
            
            CreateTable(
                "dbo.NamHocs",
                c => new
                    {
                        IDNamHoc = c.String(nullable: false, maxLength: 128),
                        TenNamHoc = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IDNamHoc);
            
            CreateTable(
                "dbo.HocSinhs",
                c => new
                    {
                        IDHocSinh = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        DiaChi = c.String(),
                        Email = c.String(),
                        IDLop = c.String(maxLength: 128),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.IDHocSinh)
                .ForeignKey("dbo.Lops", t => t.IDLop)
                .Index(t => t.IDLop);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        IDLop = c.String(nullable: false, maxLength: 128),
                        TenLop = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IDLop);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        IDMonHoc = c.String(nullable: false, maxLength: 128),
                        TenMonHoc = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IDMonHoc);
            
            CreateTable(
                "dbo.LoaiDiems",
                c => new
                    {
                        IDLoaiDiem = c.String(nullable: false, maxLength: 128),
                        TenLoai = c.String(),
                    })
                .PrimaryKey(t => t.IDLoaiDiem);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietDiems", "IDLoaiDiem", "dbo.LoaiDiems");
            DropForeignKey("dbo.ChiTietDiems", "MaBangDiem", "dbo.DiemHS");
            DropForeignKey("dbo.DiemHS", "MaMonHoc", "dbo.MonHocs");
            DropForeignKey("dbo.DiemHS", "MaHocSinh", "dbo.HocSinhs");
            DropForeignKey("dbo.HocSinhs", "IDLop", "dbo.Lops");
            DropForeignKey("dbo.DiemHS", "IDHocKy", "dbo.HocKies");
            DropForeignKey("dbo.HocKies", "IDNamHoc", "dbo.NamHocs");
            DropIndex("dbo.HocSinhs", new[] { "IDLop" });
            DropIndex("dbo.HocKies", new[] { "IDNamHoc" });
            DropIndex("dbo.DiemHS", new[] { "IDHocKy" });
            DropIndex("dbo.DiemHS", new[] { "MaMonHoc" });
            DropIndex("dbo.DiemHS", new[] { "MaHocSinh" });
            DropIndex("dbo.ChiTietDiems", new[] { "IDLoaiDiem" });
            DropIndex("dbo.ChiTietDiems", new[] { "MaBangDiem" });
            DropTable("dbo.Users");
            DropTable("dbo.LoaiDiems");
            DropTable("dbo.MonHocs");
            DropTable("dbo.Lops");
            DropTable("dbo.HocSinhs");
            DropTable("dbo.NamHocs");
            DropTable("dbo.HocKies");
            DropTable("dbo.DiemHS");
            DropTable("dbo.ChiTietDiems");
        }
    }
}
