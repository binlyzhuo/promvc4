using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProMvc4.Infrastucture
{
    public class ProfileActionAttribute:FilterAttribute,IActionFilter
    {
        private Stopwatch timer;
        public void OnActionExecuting(ActionExecutingContext context)
        {
            timer = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();
            if(filterContext.Exception==null)
            {
                filterContext.HttpContext.Response.Write(string.Format("action executing time:{0}",timer.Elapsed.TotalSeconds));
            }
        }
    }
}