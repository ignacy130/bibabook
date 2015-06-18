using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Bibabook.Implementation.DatabaseContext;
using Bibabook.Implementation.Models;
using Contract;
using Ninject;
using Bibabook.DAL;
using Bibabook.Filters;
using Bibabook.Models.ViewModels;

namespace Bibabook.Controllers
{

    public class AppUsersController : Controller
    {
        private DataBaseContext db = new DataBaseContext();

        IAppUserService _usersService;
        IAppUserSocialService _socialService;
        IKernel container = Container.Configuration.CONTAINER;

        public AppUsersController()
        {
            _usersService = container.Get<IAppUserService>();
            _socialService = container.Get<IAppUserSocialService>();
        }

        // GET: AppUsers
        [LoggedFilter]
        public ActionResult Index()
        {
            var logged = UserHelper.GetLogged(Session);
            return View(db.AppUsers.Where(x => x.Email != logged.Email).ToList());
        }

        // GET: AppUsers - friends
        [LoggedFilter]
        public ActionResult MyFriends()
        {
            var loggedId = UserHelper.GetLogged(Session).AppUserID;
            return View("PublicIndex", db.AppUsers.Single(x => x.AppUserID == loggedId).Friends.ToList());
        }

        // GET: AppUsers/Details/5
        [LoggedFilter]
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppUser appUser = db.AppUsers.Find(id);
            if (appUser == null)
            {
                return HttpNotFound();
            }
            return View(appUser);
        }

        // GET: AppUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterViewModel model)
        {

            using (DataBaseContext db = new DataBaseContext())
            {
                AppUser user = new AppUser
                {
                    AppUserID = Guid.NewGuid(),
                    Name = model.Name,
                    Surname = model.Surname,
                    Email = model.Email,
                    Hash = model.Password,
                    //Salt = null,
                    //CredentialsID = null,
                    Birthday = model.Birthday,
                    Sex = model.Sex,
                    Avatar = null,
                    Friends = null,
                    Notifications = null,
                    Events = null,
                    Posts = null
                };

                db.AppUsers.Add(user);
            }

            return RedirectToAction("Index");
        }


        [LoggedFilter]
        public ActionResult Search(string name)
        {
            var logged = UserHelper.GetLogged(Session);

            var items = db.AppUsers.Where(x => x.Name.Contains(name) || x.Surname.Contains(name)).Where(x => x.Email != logged.Email).ToList();
            if (!items.Any())
            {
                return RedirectToAction("Search", "AppEvents", new { @name = name });
            }

            return PartialView("PublicIndex", items);
        }

        [LoggedFilter]
        public ActionResult AddFriend(string id)
        {
            var userId = new Guid(id);
            var friend = db.AppUsers.Include(x => x.Friends).SingleOrDefault(x => x.AppUserID == userId);

            if (friend != null)
            {
                _socialService.FriendUsers(UserHelper.GetLogged(Session), friend);
            }

            return RedirectToAction("Friends", UserHelper.GetLogged(Session).Friends);
        }

        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            var logged = _usersService.Login(model.Email, model.Password);

            if (logged)
            {
                Session[UserHelper.USER_SESSION_KEY] = model.Email;
            }

            return View("Index");
        }

        // GET: AppUsers/Edit/5
        [LoggedFilter]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AppUser appUser = db.AppUsers.Find(id);

            if (appUser == null)
            {
                return HttpNotFound();
            }

            return View(appUser);
        }

        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [LoggedFilter]
        public ActionResult Edit(UserProfileViewModel model)
        {

            AppUser user = new AppUser
            {
                AppUserID = model.AppUserID,
                Name = model.Name,
                Surname = model.Surname,
                Email = model.Email,
                //Hash = model.Password,
                //Salt = null,
                //CredentialsID = null,
                Birthday = model.Birthday,
                Sex = model.Sex,
                Avatar = model.Avatar,
                Friends = model.Friends,
                Notifications = null,
                Events = model.Events,
            };


            db.Entry(user).State = EntityState.Modified;
            db.SaveChanges();


            return RedirectToAction("Index");
        }

        // GET: AppUsers/Delete/5
        [LoggedFilter]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AppUser appUser = db.AppUsers.Find(id);

            if (appUser == null)
            {
                return HttpNotFound();
            }

            return View(appUser);
        }

        // POST: AppUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [LoggedFilter]
        public ActionResult DeleteConfirmed(Guid id)
        {
            AppUser appUser = db.AppUsers.Find(id);
            db.AppUsers.Remove(appUser);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
