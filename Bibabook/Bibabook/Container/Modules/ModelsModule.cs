using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using Implementation;
using Contract;

namespace Bibabook.Container.Modules
{
    class ModelsModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAppEvent>().To<Implementation.Models.AppEvent>();
            Bind<IAppUser>().To<Implementation.Models.AppUser>();
            Bind<IEmail>().To<Implementation.Models.Email>();
            Bind<IEventPost>().To<Implementation.Models.EventPost>();
            Bind<INotification>().To<Implementation.Models.Notification>();
            Bind<IPostComment>().To<Implementation.Models.PostComment>();
        }
    }
}