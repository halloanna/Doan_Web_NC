namespace DOAN_WEB_NC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _AddTable_NamHoc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NamHocs",
                c => new
                    {
                        IDNamHoc = c.Int(nullable: false, identity: true),
                        NamBD = c.DateTime(nullable: false),
                        NamKT = c.DateTime(nullable: false),
                        HocKy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDNamHoc);
            
            AddColumn("dbo.BangDiemMonHocs", "IDNamHoc", c => c.Int(nullable: false));
            CreateIndex("dbo.BangDiemMonHocs", "IDNamHoc");
            AddForeignKey("dbo.BangDiemMonHocs", "IDNamHoc", "dbo.NamHocs", "IDNamHoc", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BangDiemMonHocs", "IDNamHoc", "dbo.NamHocs");
            DropIndex("dbo.BangDiemMonHocs", new[] { "IDNamHoc" });
            DropColumn("dbo.BangDiemMonHocs", "IDNamHoc");
            DropTable("dbo.NamHocs");
        }
    }
}
