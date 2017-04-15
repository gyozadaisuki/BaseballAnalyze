using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseballAnalyze.Models
{
    public class PitcherData
    {
        [Key, Column(Order = 0)]
        public int TeamId { get; set; }
        [Key, Column(Order = 1)]
        public int PlayerId { get; set; }
        [Key, Column(Order = 2)]
        public int Year { get; set; }
        [Key, Column(Order = 3)]
        public int TeamClass { get; set; }
        public string PlayerName { get; set; }
        public int Game { get; set; }
        public int CompleteGame { get; set; }
        public int Start { get; set; }
        public int ShutOut { get; set; }
        public int NoBB { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Save { get; set; }
        public int Hold { get; set; }
        public int HP { get; set; }
        public double WinPercentage { get; set; }
        public double Inning { get; set; }
        public int Batmen { get; set; }
        public int PlateAppearance { get; set; }
        public int Hit { get; set; }
        public int Homerun { get; set; }
        public int BB { get; set; }
        public int HitByPitch { get; set; }
        public int K { get; set; }
        public int WildPitch { get; set; }
        public int Balk { get; set; }
        public double Run { get; set; }
        public double EarnedRun { get; set; }
        public double ERA { get; set; }
        public double BBPerNine { get; set; }
        public double KPerNine { get; set; }
        public double KPerBB { get; set; }
        public double WHIP { get; set; }

    }
}