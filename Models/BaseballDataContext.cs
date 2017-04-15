using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BaseballAnalyze.Models
{
    public class BaseballDataContext : System.Data.Entity.DbContext
    {
        public DbSet<BatterData> BatterDatas { get; set; }
        public DbSet<PitcherData> PitcherDatas { get; set; }
    }
}