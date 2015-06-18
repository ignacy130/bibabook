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

namespace Bibabook.Controllers
{
    public class HomeController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        IAppUserService _usersService;
        IKernel container = Container.Configuration.CONTAINER;
        
        public ActionResult Index()
        {
            //IAppUserSocialService aa = container.Get<IAppUserSocialService>();
            //_socialService = aa;
            //IAppUser bb = new AppUser();
            //aa.FriendUsers(new AppUser(), new AppUser());
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