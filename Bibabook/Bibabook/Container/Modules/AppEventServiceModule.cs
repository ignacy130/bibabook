using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using Bibabook.Implementation;
using Contract;
using Bibabook.Implementation.AppEventService;

namespace Bibabook.Container.Modules
{
    class AppEventServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAppEventService>().To<EventsService>();
        }
    }
}