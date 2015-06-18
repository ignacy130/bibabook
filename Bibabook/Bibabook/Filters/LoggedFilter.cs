using Bibabook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bibabook.Filters
{
    public class LoggedFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                var user = UserHelper.GetLogged(filterContext.HttpContext.Session);
            }
            catch (Exception)
            {
                filterContext.Result= new RedirectResult("~/AppUsers/Login");
            }
        }
    }
}