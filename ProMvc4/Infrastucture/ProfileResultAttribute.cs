using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProMvc4.Infrastucture
{
    public class ProfileResultAttribute:FilterAttribute,IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }
    }
}