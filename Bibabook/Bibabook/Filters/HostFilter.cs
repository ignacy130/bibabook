using Bibabook.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bibabook.Filters
{
    public class HostFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                var user = UserHelper.GetLogged(filterContext.HttpContext.Session);
                var vs = filterContext.RequestContext.RouteData.Values;
                var id = vs["id"];
                if (!user.Events.Select(x => x.AppEventID.ToString()).Contains(id))
                {
                    filterContext.Result = new RedirectResult("~/AppUsers/Unauthorized");
                }
            }
            catch (Exception)
            {
                filterContext.Result= new RedirectResult("~/AppUsers/Login");
            }
        }
    }
}