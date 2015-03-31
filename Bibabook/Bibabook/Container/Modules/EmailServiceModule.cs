using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using Ninject.Modules;
using Bibabook.Implementation;
using Contract;

namespace Bibabook.Container.Modules
{
    class EmailServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEmailService>().To<Implementation.EmailService.EmailService>();

        }
    }
}