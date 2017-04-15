namespace BaseballAnalyze.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePitcherData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PitcherDatas", "WinPercentage", c => c.Double(nullable: false));
            AlterColumn("dbo.PitcherDatas", "Inning", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PitcherDatas", "Inning", c => c.Int(nullable: false));
            AlterColumn("dbo.PitcherDatas", "WinPercentage", c => c.Int(nullable: false));
        }
    }
}
