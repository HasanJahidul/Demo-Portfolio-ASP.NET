﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Portfolio()
        {
            return View();
        }
        public ActionResult Bio()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Info()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult References()
        {
            return View();
        }
    }
}