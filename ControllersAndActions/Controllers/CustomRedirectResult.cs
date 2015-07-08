using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class CustomRedirectResult:ActionResult
    {
        public string Url;
        public override void ExecuteResult(ControllerContext context)
        {
            //throw new NotImplementedException();
            string fullUrl = UrlHelper.GenerateContentUrl(Url, context.HttpContext);
            context.HttpContext.Response.Redirect(fullUrl);

            //================
        }
    }
}