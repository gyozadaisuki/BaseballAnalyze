namespace BaseballAnalyze.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBatterData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BatterDatas",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        TeamClass = c.Int(nullable: false),
                        Game = c.Int(nullable: false),
                        PlateAppearance = c.Int(nullable: false),
                        AtBat = c.Int(nullable: false),
                        Run = c.Int(nullable: false),
                        Hit = c.Int(nullable: false),
                        Single = c.Int(nullable: false),
                        Double = c.Int(nullable: false),
                        Triple = c.Int(nullable: false),
                        Homerun = c.Int(nullable: false),
                        TotalBases = c.Int(nullable: false),
                        RBI = c.Int(nullable: false),
                        K = c.Int(nullable: false),
                        BB = c.Int(nullable: false),
                        IntentionalBB = c.Int(nullable: false),
                        HitByPitch = c.Int(nullable: false),
                        SacrificeHit = c.Int(nullable: false),
                        SacrificeFly = c.Int(nullable: false),
                        Steal = c.Int(nullable: false),
                        CaughtStealing = c.Int(nullable: false),
                        DoublePlay = c.Int(nullable: false),
                        Error = c.Int(nullable: false),
                        Average = c.Double(nullable: false),
                        SLG = c.Double(nullable: false),
                        OBP = c.Double(nullable: false),
                        OPS = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamId, t.PlayerId, t.Year, t.TeamClass });
            
            CreateTable(
                "dbo.PitcherDatas",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        PlayerId = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        TeamClass = c.Int(nullable: false),
                        Game = c.Int(nullable: false),
                        CompleteGame = c.Int(nullable: false),
                        Start = c.Int(nullable: false),
                        ShutOut = c.Int(nullable: false),
                        NoBB = c.Int(nullable: false),
                        Win = c.Int(nullable: false),
                        Lose = c.Int(nullable: false),
                        Save = c.Int(nullable: false),
                        Hold = c.Int(nullable: false),
                        HP = c.Int(nullable: false),
                        WinPercentage = c.Int(nullable: false),
                        Inning = c.Int(nullable: false),
                        Batmen = c.Int(nullable: false),
                        PlateAppearance = c.Int(nullable: false),
                        Hit = c.Int(nullable: false),
                        Homerun = c.Int(nullable: false),
                        BB = c.Int(nullable: false),
                        HitByPitch = c.Int(nullable: false),
                        K = c.Int(nullable: false),
                        WildPitch = c.Int(nullable: false),
                        Balk = c.Int(nullable: false),
                        Run = c.Double(nullable: false),
                        EarnedRun = c.Double(nullable: false),
                        ERA = c.Double(nullable: false),
                        BBPerNine = c.Double(nullable: false),
                        KPerNine = c.Double(nullable: false),
                        KPerBB = c.Double(nullable: false),
                        WHIP = c.Double(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamId, t.PlayerId, t.Year, t.TeamClass });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PitcherDatas");
            DropTable("dbo.BatterDatas");
        }
    }
}
