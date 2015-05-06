using Bibabook.Implementation.AppUserService;
using Contract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bibabook.Controllers
{
    public class HomeController : Controller
    {
        IAppUserSocialService _socialService;
        IKernel container = Container.Configuration.CONTAINER;
        
        public ActionResult Index(IAppUserSocialService socialService)
        {
            IAppUserSocialService aa = container.Get<IAppUserSocialService>();
            //IAppUser bb = new AppUser();
            //aa.SendFriendInvitation();
            _socialService = socialService;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            _socialService.
            return View();
        }
    }
}