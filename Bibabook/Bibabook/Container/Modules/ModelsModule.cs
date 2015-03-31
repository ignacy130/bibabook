using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using Bibabook.Implementation;
using Contract;
using Bibabook.Implementation.Models;
using Bibabook.Models;

namespace Bibabook.Container.Modules
{
    class ModelsModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAppEvent>().To<AppEvent>();
            Bind<IAppUser>().To<AppUser>();
            Bind<IEmail>().To<Email>();
            Bind<IEventPost>().To<EventPost>();
            Bind<INotification>().To<Notification>();
            Bind<IPostComment>().To<Post>();
        }
    }
}