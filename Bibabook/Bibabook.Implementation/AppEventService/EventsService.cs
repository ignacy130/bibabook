using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Bibabook.Implementation.DatabaseContext;
using Bibabook.Implementation.Models;
namespace Bibabook.Implementation.AppEventService
{
    /// <summary>
    /// Odpowiedzialny za obsluge (dodawanie, edycje, dodawanie uczestnikow) wydarzen
    /// </summary>
    public class EventsService :IAppEventService
    {
        private DataBaseContext context;

        
        public EventsService()
        {
            this.context = new DataBaseContext();
        }

        public bool Create(IAppEvent appEvent)
        {
            var e = (AppEvent)appEvent;
            e.Host = context.AppUsers.Single(x => x.AppUserID == e.Host.AppUserID);
            e.Created = DateTime.Now;
            e.Modified = DateTime.Now;
            context.AppEvents.Add(e);
            e.Host.Events.Add(e);
            context.Entry(e.Host).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return true;
        }

        public bool Cancel(IAppEvent appEvent)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IAppEvent appEvent)
        {
            var ee = context.Entry((AppEvent)appEvent).Entity;
            context.AppEvents.Remove(ee);
            context.SaveChanges();
            return true;
        }

        public bool InviteUser(IAppEvent appEvent, IAppUser sender, IAppUser recipient)
        {
            var ee = context.Entry((AppEvent)appEvent).Entity;
            ee.Guests.Add((AppUser)recipient);
            context.SaveChanges();
            return true;
        }

        public bool InviteUser(IAppEvent appEvent, IAppUser sender, ICollection<IAppUser> recipients)
        {
            var eventEntry = context.Entry((AppEvent)appEvent).Entity;
            foreach (var item in recipients)
            {
                eventEntry.Guests.Add((AppUser)item);
            }
            context.SaveChanges();
            return true;
        }

        public bool EnrollUser(IAppEvent appEvent, IAppUser appUser)
        {
            var e = context.AppEvents.Single(x => x.AppEventID == ((AppEvent)appEvent).AppEventID);
            var u = context.AppUsers.Single(x => x.AppUserID == ((AppUser)appUser).AppUserID);
            e.Guests.Add((AppUser)u);
            context.Entry(e).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            u.Events.Add(e); //dodane przez hubert pietruczuk
            context.Entry(u).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return true;
        }

        public bool RemoveUser(IAppEvent appEvent, IAppUser appUser)
        {
            var e = context.AppEvents.Single(x => x.AppEventID == ((AppEvent)appEvent).AppEventID);
            var u = context.AppUsers.Single(x => x.AppUserID == ((AppUser)appUser).AppUserID);
            e.Guests.Remove((AppUser)u);
            u.Events.Remove(e);
            context.Entry(e).State = System.Data.Entity.EntityState.Modified;
            context.Entry(u).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return true;
        }

        public bool RemoveUser(IAppEvent appEvent, ICollection<IAppUser> appUsers)
        {
            throw new NotImplementedException();
        }

        public bool ForbidUser(IAppEvent appEvent, IAppUser appUser)
        {
            throw new NotImplementedException();
        }

        public bool AllowUser(IAppEvent appEvent, IAppUser appUser)
        {
            throw new NotImplementedException();
        }

        public bool AddEventPost(IAppEvent appEvent, IEventPost eventPost)
        {
            var ee = context.Entry((AppEvent)appEvent).Entity;
            ee.Posts.Add((Models.EventPost)eventPost);
            context.SaveChanges();
            return true;
        }
    }
}
