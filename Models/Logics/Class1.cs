using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Sgml;

namespace BaseballAnalyze.Models.Logics
{
    public class ScreapingLogic
    {
        static public void GetBaseBallData()
        {
            XDocument xml;
            using (var sgml = new SgmlReader() { Href = "http://www.baseball-lab.jp/player/pitcher/9/2016" })
            {
                xml = XDocument.Load(sgml); // たった3行でHtml to Xml
            }
            using (var context = new BaseballDataContext()) {
                // Xboxの発売スケジュールからタイトルと発売日を抜き出してみる
                var ns = xml.Root.Name.Namespace;
                var query = xml.Descendants(ns + "table")
                    .First()
                    .Descendants(ns + "tr")
                    .Skip(1) // テーブル一行目は項目説明なので飛ばす
                    .Select(e => e.Elements(ns + "td").ToList())
                    .Select(es => new
                    {
                        PlayerId = int.Parse(es.First().Value),
                        PlayerName = es[1].Value,
                        Game = int.Parse(es[2].Value),
                        CompleteGame = int.Parse(es[3].Value),
                        Start = int.Parse(es[4].Value),
                        ShutOut = int.Parse(es[5].Value),
                        NoBB = int.Parse(es[6].Value),
                        Win = int.Parse(es[7].Value),
                        Lose = int.Parse(es[8].Value),
                        Save = int.Parse(es[9].Value),
                        Hold = int.Parse(es[10].Value),
                        HP = int.Parse(es[11].Value),
                        WinPercentage = Double.Parse(es[12].Value.Split(' ')[0]) + Double.Parse(es[12].Value.Split(' ')[1].Split('/')[0]) / 10,
                        Inning = double.Parse(es[13].Value),
                        Batmen = int.Parse(es[14].Value),
                        PlateAppearance = int.Parse(es[15].Value),
                        Hit = int.Parse(es[16].Value),
                        Homerun = int.Parse(es[17].Value),
                        BB = int.Parse(es[18].Value),
                        HitByPitch = int.Parse(es[19].Value),
                        K = int.Parse(es[20].Value),
                        WildPitch = int.Parse(es[21].Value),
                        Balk = int.Parse(es[22].Value),
                        Run = int.Parse(es[23].Value),
                        EarnedRun = int.Parse(es[24].Value),
                        ERA = Double.Parse(es[25].Value),
                        BBPerNine = Double.Parse(es[26].Value),
                        KPerNine = Double.Parse(es[27].Value),
                        KPerBB = Double.Parse(es[28].Value),
                        WHIP = Double.Parse(es[29].Value)
                    });
                foreach (var item in query)
                {
                    context.PitcherDatas.Add(new PitcherData()
                    {
                        PlayerId = item.PlayerId,
                        PlayerName = item.PlayerName,
                        Game = item.Game,
                        CompleteGame = item.CompleteGame,
                        Start = item.Start,
                        ShutOut = item.ShutOut,
                        NoBB = item.NoBB,
                        Win = item.Win,
                        Lose = item.Lose,
                        Save = item.Save,
                        Hold = item.Hold,
                        HP = item.HP,
                        WinPercentage = item.WinPercentage,
                        Inning = item.Inning,
                        Batmen = item.Batmen,
                        PlateAppearance = item.PlateAppearance,
                        Hit = item.Hit,
                        Homerun = item.Homerun,
                        BB = item.BB,
                        HitByPitch = item.HitByPitch,
                        K = item.K,
                        WildPitch = item.WildPitch,
                        Balk = item.Balk,
                        Run = item.Run,
                        EarnedRun = item.EarnedRun,
                        ERA = item.ERA,
                        BBPerNine = item.BBPerNine,
                        KPerNine = item.KPerNine,
                        KPerBB = item.KPerBB,
                        WHIP = item.WHIP
                    });
                }
                context.SaveChanges();
            }

        }
    }
}