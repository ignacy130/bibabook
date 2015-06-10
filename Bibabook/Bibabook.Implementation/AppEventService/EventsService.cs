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


        public EventsService() { } // ten konstruktor stworzony tylko po to żeby test się nie sypał 
        public EventsService(DataBaseContext ctx)
        {
            this.context = ctx;
        }

        public bool Create(IAppEvent appEvent)
        {
            context.AppEvents.Add((AppEvent)appEvent);
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
            var ee = context.Entry((AppEvent)appEvent).Entity;
            foreach (var item in recipients)
            {
                ee.Guests.Add((AppUser)item);
            }
            context.SaveChanges();
            return true;
        }

        public bool EnrollUser(IAppEvent appEvent, IAppUser appUser)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUser(IAppEvent appEvent, IAppUser appUser)
        {
            throw new NotImplementedException();
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
