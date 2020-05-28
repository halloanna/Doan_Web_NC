namespace DOAN_WEB_NC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _createNewDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BangDiemMonHocs",
                c => new
                    {
                        IDBangDiem = c.Int(nullable: false, identity: true),
                        IDMonHoc = c.Int(nullable: false),
                        IDLop = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDBangDiem)
                .ForeignKey("dbo.Lops", t => t.IDLop, cascadeDelete: true)
                .ForeignKey("dbo.MonHocs", t => t.IDMonHoc, cascadeDelete: true)
                .Index(t => t.IDMonHoc)
                .Index(t => t.IDLop);
            
            CreateTable(
                "dbo.ChiTietBangDiemMonHocs",
                c => new
                    {
                        IDChiTietBangDiemMonHoc = c.Int(nullable: false, identity: true),
                        IDBangDiemMonHoc = c.Int(nullable: false),
                        IDHocSinh = c.Int(nullable: false),
                        Diem15p = c.Single(nullable: false),
                        Diem1t = c.Single(nullable: false),
                        DiemTB = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IDChiTietBangDiemMonHoc)
                .ForeignKey("dbo.BangDiemMonHocs", t => t.IDBangDiemMonHoc, cascadeDelete: true)
                .ForeignKey("dbo.HoSoHocSinhs", t => t.IDHocSinh, cascadeDelete: true)
                .Index(t => t.IDBangDiemMonHoc)
                .Index(t => t.IDHocSinh);
            
            CreateTable(
                "dbo.HoSoHocSinhs",
                c => new
                    {
                        IDHocSinh = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        GioiTinh = c.Boolean(nullable: false),
                        Image = c.String(),
                        NgaySinh = c.DateTime(),
                        DiaChi = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.IDHocSinh);
            
            CreateTable(
                "dbo.ChiTiet_Lop_HocSinh",
                c => new
                    {
                        IDChiTiet_Lop_HocSinh = c.Int(nullable: false, identity: true),
                        IDHocSinh = c.Int(nullable: false),
                        IDLop = c.Int(nullable: false),
                        TBHKI = c.Single(nullable: false),
                        TBHKII = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IDChiTiet_Lop_HocSinh)
                .ForeignKey("dbo.HoSoHocSinhs", t => t.IDHocSinh, cascadeDelete: true)
                .ForeignKey("dbo.Lops", t => t.IDLop, cascadeDelete: true)
                .Index(t => t.IDHocSinh)
                .Index(t => t.IDLop);
            
            CreateTable(
                "dbo.Lops",
                c => new
                    {
                        IDLop = c.Int(nullable: false, identity: true),
                        SiSo = c.Int(nullable: false),
                        SLDat = c.Int(nullable: false),
                        TiLe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDLop);
            
            CreateTable(
                "dbo.MonHocs",
                c => new
                    {
                        IDMonHoc = c.Int(nullable: false, identity: true),
                        TenMonHoc = c.String(),
                    })
                .PrimaryKey(t => t.IDMonHoc);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        IDUser = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IDUser);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BangDiemMonHocs", "IDMonHoc", "dbo.MonHocs");
            DropForeignKey("dbo.BangDiemMonHocs", "IDLop", "dbo.Lops");
            DropForeignKey("dbo.ChiTietBangDiemMonHocs", "IDHocSinh", "dbo.HoSoHocSinhs");
            DropForeignKey("dbo.ChiTiet_Lop_HocSinh", "IDLop", "dbo.Lops");
            DropForeignKey("dbo.ChiTiet_Lop_HocSinh", "IDHocSinh", "dbo.HoSoHocSinhs");
            DropForeignKey("dbo.ChiTietBangDiemMonHocs", "IDBangDiemMonHoc", "dbo.BangDiemMonHocs");
            DropIndex("dbo.ChiTiet_Lop_HocSinh", new[] { "IDLop" });
            DropIndex("dbo.ChiTiet_Lop_HocSinh", new[] { "IDHocSinh" });
            DropIndex("dbo.ChiTietBangDiemMonHocs", new[] { "IDHocSinh" });
            DropIndex("dbo.ChiTietBangDiemMonHocs", new[] { "IDBangDiemMonHoc" });
            DropIndex("dbo.BangDiemMonHocs", new[] { "IDLop" });
            DropIndex("dbo.BangDiemMonHocs", new[] { "IDMonHoc" });
            DropTable("dbo.Users");
            DropTable("dbo.MonHocs");
            DropTable("dbo.Lops");
            DropTable("dbo.ChiTiet_Lop_HocSinh");
            DropTable("dbo.HoSoHocSinhs");
            DropTable("dbo.ChiTietBangDiemMonHocs");
            DropTable("dbo.BangDiemMonHocs");
        }
    }
}
