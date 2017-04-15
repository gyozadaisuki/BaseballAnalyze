using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballAnalyze.Models
{
    public class BatterData
    {
        [Key,Column(Order = 0)]
        public int TeamId { get; set; }
        [Key, Column(Order = 1)]
        public int PlayerId { get; set; }
        [Key, Column(Order = 2)]
        public int Year { get; set; }
        [Key, Column(Order = 3)]
        public int TeamClass { get; set; }
        public string PlayerName { get; set; }
        public int Game { get; set; }
        public int PlateAppearance { get; set; }
        public int AtBat { get; set; }
        public int Run { get; set; }
        public int Hit { get; set; }
        public int Single { get; set; }
        public int Double { get; set; }
        public int Triple { get; set; }
        public int Homerun { get; set; }
        public int TotalBases { get; set; }
        public int RBI { get; set; }
        public int K { get; set; }
        public int BB { get; set; }
        public int IntentionalBB { get; set; }
        public int HitByPitch { get; set; }
        public int SacrificeHit { get; set; }
        public int SacrificeFly { get; set; }
        public int Steal { get; set; }
        public int CaughtStealing { get; set; }
        public int DoublePlay { get; set; }
        public int Error { get; set; }
        public double Average { get; set; }
        public double SLG { get; set; }
        public double OBP { get; set; }
        public double OPS { get; set; }
    }
}