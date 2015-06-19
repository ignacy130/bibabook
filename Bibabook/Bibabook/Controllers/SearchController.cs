using Bibabook.DAL;
using Bibabook.Filters;
using Bibabook.Implementation.DatabaseContext;
using Bibabook.Models;
using Contract;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bibabook.Controllers
{
    public class SearchController : Controller
    {
        DataBaseContext db = new DataBaseContext();

        IAppUserService _usersService;
        IAppUserSocialService _socialService;
        IKernel container = Container.Configuration.CONTAINER;

        // GET: Search
        [LoggedFilter]
        public ActionResult Search(string name)
        {
            var logged = UserHelper.GetLogged(Session);
            var users = db.AppUsers.Where(x => x.Name.Contains(name) || x.Surname.Contains(name)).Where(x => x.Email != logged.Email).ToList();
            var events = db.AppEvents.Where(x => x.Name.Contains(name) || x.Description.Contains(name)).ToList();
            var results = new List<SearchItemViewModel>();
            foreach (var item in users)
            {
                results.Add(
                    new SearchItemViewModel()
                    {
                        Id = item.AppUserID,
                        Name = item.Name + " " + item.Surname,
                        Type = AppType.AppUser
                    });
            }
            foreach (var item in events)
            {
                results.Add(
                    new SearchItemViewModel()
                    {
                        Id = item.AppEventID,
                        Name = item.Name,
                        Type = AppType.AppEvent
                    });
            }
            return PartialView("Results", results);
        }
    }
}