﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseballAnalyze.Models.Logics;

namespace BaseballAnalyze.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ScreapingLogic.GetBaseBallData();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}