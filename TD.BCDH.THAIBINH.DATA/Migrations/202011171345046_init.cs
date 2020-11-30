namespace TD.BCDH.THAIBINH.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhiemVuKetQua",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IdVanBan = c.String(),
                        DonViXuLy = c.String(),
                        NguoiXuLy = c.String(),
                        SoKiHieu = c.String(),
                        LoaiVanBan = c.String(),
                        NguoiKy = c.String(),
                        TrichYeu = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NhiemVu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IdVanBan = c.String(),
                        SoKyHieu = c.String(),
                        TrichYeu = c.String(),
                        TenNhiemVu = c.String(),
                        DonViXuLy = c.String(),
                        NgayBanHanh = c.DateTime(),
                        NgayBaoCao = c.String(),
                        NgayXuLy = c.DateTime(),
                        NguoiPhuTrach = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VanBanDen",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IdVanBan = c.String(),
                        SoKyHieu = c.String(),
                        TrichYeu = c.String(),
                        CoQuanBanHanh = c.String(),
                        NgayBanHanh = c.DateTime(),
                        DonViNhan = c.String(),
                        NgayNhan = c.DateTime(),
                        TrangThai = c.String(),
                        NgayXuLyXong = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VanBanDi",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IdVanBan = c.String(),
                        DonViNhan = c.String(),
                        SoKiHieu = c.String(),
                        TrichYeu = c.String(),
                        NgayKy = c.DateTime(),
                        LoaiVanBan = c.String(),
                        SoVanBan = c.String(),
                        CoQuanBanHanh = c.String(),
                        NguoiKy = c.String(),
                        NguoiSoanThao = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VanBanDi");
            DropTable("dbo.VanBanDen");
            DropTable("dbo.NhiemVu");
            DropTable("dbo.NhiemVuKetQua");
        }
    }
}
