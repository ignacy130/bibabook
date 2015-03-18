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
    class AppUserServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAppUserEmailService>().To<Implementation.AppUserService.AppUserEmailService>();
            Bind<IAppUserService>().To<Implementation.AppUserService.AppUserService>();
            Bind<IAppUserSocialService>().To<Implementation.AppUserService.AppUserSocialService>();
        }
    }
}