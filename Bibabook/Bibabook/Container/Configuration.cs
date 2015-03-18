using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;

namespace Bibabook.Container
{
    public class Configuration
    {
        private static IKernel Container;

        public static IKernel CONTAINER
        {
            get
            {
                if (Container == null)
                    Container = Create();
                return Container;
            }
        }

        private static IKernel Create()
        {
            var kernel = new StandardKernel(
               new Modules.AppEventServiceModule(),
               new Modules.AppUserServiceModule(),
               new Modules.EmailServiceModule(),
               new Modules.EventPostModule(),
               new Modules.InterfacesModule(),
               new Modules.ModelsModule(),
               new Modules.NotificationServiceModule(),
               new Modules.PostCommentModule(),
               new Modules.ReportServiceModule(),
               new Modules.SearchServiceModule()
                );
            return kernel;
        }
    }
}