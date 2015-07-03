using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ProMvc4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            //var httpMessage = await client.GetAsync("");
            return View();
        }

    }
}
