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
    class EventPostModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEventPostService>().To<Implementation.EventPost.EventPostService>();
        }
    }
}