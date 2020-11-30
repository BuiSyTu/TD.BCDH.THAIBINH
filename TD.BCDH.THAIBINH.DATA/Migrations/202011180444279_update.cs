namespace TD.BCDH.THAIBINH.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NhiemVu", "NgayBaoCao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhiemVu", "NgayBaoCao", c => c.String());
        }
    }
}
