using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using Bibabook.Implementation;
using Contract;
using Bibabook.Implementation.AppUserService;

namespace Bibabook.Container.Modules
{
    class AppUserServiceModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IAppUserEmailService>().To<EmailService>(); TODO proper
            //appuseremailservice implementation - in accordance with contract
            Bind<IAppUserService>().To<UsersService>();
            Bind<IAppUserSocialService>().To<SocialService>();
        }
    }
}