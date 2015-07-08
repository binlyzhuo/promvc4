using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProMvc4.Controllers
{
    public class RemoteController : AsyncController
    {
        //
        // GET: /Remote/

        public ActionResult Index()
        {
            return View();
        }

    }
}
