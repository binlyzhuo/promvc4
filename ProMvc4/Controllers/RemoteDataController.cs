using ProMvc4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProMvc4.Controllers
{
    public class RemoteDataController : Controller
    {
        //
        // GET: /RemoteData/

        public ActionResult Index()
        {
            RemoteService service = new RemoteService();
            string data = service.GetRemoteData();
            return View((object)data);
        }



    }
}
