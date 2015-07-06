using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ProMvc4.Infrastucture;

namespace ProMvc4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        //[Authorize]
        [ProfileAction]
        public ActionResult Index()
        {
            //HttpClient client = new HttpClient();
            //var httpMessage = await client.GetAsync("");

            string controllerName = (string)RouteData.Values["controller"];
            return View();
        }


        public RedirectToRouteResult MyActionResult()
        {
            return RedirectToRoute(new {Controller="Home",Action="Index" });
        }

        public HttpStatusCodeResult StatusCode()
        {
            return new HttpStatusCodeResult(500, "System error!!");
        }

        public ActionResult Result()
        {
            return View();
        }

        [CustomAuth(true)]
        public string Hello()
        {
            return "Hello mvc4 project!";
        }

        //[RangeException]
        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException), View = "RangeError")]
        public string Range(int id)
        {
            if(id>100)
            {
                return string.Format("The id value is {0}",id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id",id,"");
            }
        }

        public ViewResult RangeError()
        {
            return View();
        }
    }
}
