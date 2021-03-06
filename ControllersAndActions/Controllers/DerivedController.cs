﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        public ActionResult Index()
        {
            string serverName = Server.MachineName;
            return View();
        }

        public ActionResult Dir()
        {
            return new CustomRedirectResult { Url="/Basic/Index" };
        }
    }
}
