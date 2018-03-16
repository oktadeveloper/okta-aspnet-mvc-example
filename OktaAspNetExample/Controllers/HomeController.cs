﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OktaAspNetExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var claim = HttpContext.GetOwinContext().Authentication.User.FindFirst("name");
            ViewBag.Username = (claim != null) ? claim.Value : string.Empty;

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