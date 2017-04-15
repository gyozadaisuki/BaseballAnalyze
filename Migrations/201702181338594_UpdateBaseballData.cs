namespace BaseballAnalyze.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBaseballData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BatterDatas", "PlayerName", c => c.String());
            AddColumn("dbo.PitcherDatas", "PlayerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PitcherDatas", "PlayerName");
            DropColumn("dbo.BatterDatas", "PlayerName");
        }
    }
}
