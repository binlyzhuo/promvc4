using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProMvc4.Infrastucture
{
    public class CustomAuthAttribute:AuthorizeAttribute
    {
        private bool localAllowed;
        public CustomAuthAttribute(bool allowParam)
        {
            localAllowed = allowParam;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //return base.AuthorizeCore(httpContext);
            if(httpContext.Request.IsLocal)
            {
                return localAllowed;
            }
            else
            {
                return true;
            }
        }
    }
}