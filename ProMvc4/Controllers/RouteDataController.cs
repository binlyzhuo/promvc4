using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProMvc4.Controllers
{
    public class RouteDataController : AsyncController
    {
        //
        // GET: /RouteData/

        public async Task<ActionResult> Index()
        {
            return View();
        }

    }
}
