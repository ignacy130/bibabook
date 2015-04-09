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
            throw new NotImplementedException();
        }

        public bool InviteUser(IAppEvent appEvent, IAppUser sender, IAppUser recipient)
        {
            throw new NotImplementedException();
        }

        public bool InviteUser(IAppEvent appEvent, IAppUser sender, ICollection<IAppUser> recipients)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
