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
            return View("List", db.AppUsers.Single(x => x.AppUserID == loggedId).Friends.ToList());
        }

        // GET: AppUsers/Details/5
        [LoggedFilter]
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppUser appUser = db.AppUsers.Include(x => x.Events).Single(x => x.AppUserID == id);
            if (appUser == null)
            {
                return HttpNotFound();
            }

            AppUser activeUser = UserHelper.GetLogged(Session);
            ViewBag.IsSelf = appUser.AppUserID == activeUser.AppUserID;
            ViewBag.IsFriend = activeUser.Friends.Any(t => t.AppUserID == appUser.AppUserID);

            return View("Profile", appUser);
        }

        // GET: AppUsers/Create
        public ActionResult Register()
        {
            return View("Register");
        }

        // POST: AppUsers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            AppUser user = new AppUser
            {
                AppUserID = Guid.NewGuid(), Name = model.Name, Surname = model.Surname, 
                Email = model.Email, Birthday = model.Birthday, Sex = model.Sex, Hash = model.Password
            };
            _usersService.CreateAccount(user);
            Session[UserHelper.USER_SESSION_KEY] = user.Email;

            return RedirectToAction("Index", "Home");
        }

        

        [LoggedFilter]
        public ActionResult AddFriend(string id)
        {
            var g = new Guid(id);
            var friend = db.AppUsers.Include(x=>x.Friends).SingleOrDefault(x => x.AppUserID == g);
            if (friend != null)
            {
                _socialService.FriendUsers(UserHelper.GetLogged(Session), friend);
            }
            return View("List", UserHelper.GetLogged(Session).Friends);
        }

        [LoggedFilter]
        public ActionResult RemoveFriend(string id)
        {
            var g = new Guid(id);
            var friend = db.AppUsers.Include(x => x.Friends).SingleOrDefault(x => x.AppUserID == g);
            if (friend != null)
            {
                _socialService.UnfriendUsers(UserHelper.GetLogged(Session), friend);
            }
            return View("List", UserHelper.GetLogged(Session).Friends);
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
            if(logged)
            {
                Session[UserHelper.USER_SESSION_KEY] = model.Email;
            }
            return RedirectToAction("Index", "Home");
        }

        [LoggedFilter]
        public ActionResult LogOut()
        {
            Session[UserHelper.USER_SESSION_KEY] = null;
            return RedirectToAction("Index", "Home");
        }

        // GET: AppUsers/Edit/5
        [LoggedFilter]
        public ActionResult Edit(Guid? id)
        {
            if (id == null || id != UserHelper.GetLogged(Session).AppUserID)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppUser appUser = db.AppUsers.Find(id);
            if (appUser == null)
            {
                return HttpNotFound();
            }

            EditProfileViewModel model = new EditProfileViewModel
            {
                AppUserID = appUser.AppUserID,
                Name = appUser.Name,
                Surname = appUser.Surname,
                Birthday = appUser.Birthday,
                Sex = appUser.Sex
            };

            return View("EditProfile", model);
        }

        // POST: AppUsers/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [LoggedFilter]
        public ActionResult Edit(EditProfileViewModel model)
        {
            AppUser appUser = db.AppUsers.Find(model.AppUserID);
            if (appUser != null)
            {
                appUser.Name = model.Name;
                appUser.Surname = model.Surname;
                appUser.Sex = model.Sex;
                appUser.Birthday = model.Birthday;
                db.Entry(appUser).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.IsSelf = true;
                ViewBag.IsFriend = false;
                return View("Profile", appUser);
            }

            return View("EditProfile", model);
        }

        //// GET: AppUsers/Delete/5
        //[LoggedFilter]
        //public ActionResult Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AppUser appUser = db.AppUsers.Find(id);
        //    if (appUser == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(appUser);
        //}

        //// POST: AppUsers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //[LoggedFilter]
        //public ActionResult DeleteConfirmed(Guid id)
        //{
        //    AppUser appUser = db.AppUsers.Find(id);
        //    db.AppUsers.Remove(appUser);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
