﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProMvc4.Infrastucture
{
    public class RangeExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is ArgumentOutOfRangeException)
            {
                //filterContext.Result = new RedirectResult("~/Common/RangeErrorPage.html");

                int val = (int)((ArgumentOutOfRangeException)filterContext.Exception).ActualValue;

                filterContext.Result = new ViewResult
                {
                    ViewName = "RangeError",
                    ViewData = new ViewDataDictionary<int>(val)
                };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}