using Bibabook.Implementation.AppUserService;
using Bibabook.Implementation.DatabaseContext;
using Bibabook.Implementation.Models;
using Contract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bibabook.DAL;
using Microsoft.AspNet.Identity.Owin;
using Bibabook.Filters;

namespace Bibabook.Controllers
{
    public class HomeController : Controller
    {
        private DataBaseContext db = new DataBaseContext();
        private ApplicationUserManager _userManager;
        IAppUserService _usersService;
        IKernel container = Container.Configuration.CONTAINER;
        [LoggedFilter]
        public ActionResult Index()
        {
            //IAppUserSocialService aa = container.Get<IAppUserSocialService>();
            //_socialService = aa;
            //IAppUser bb = new AppUser();
            //aa.FriendUsers(new AppUser(), new AppUser());


            if (UserHelper.IsLogged(Session))
            {
                ViewBag.user = "zalogowany";
            }
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
            //_socialService.
            return View();
        }
    }
}