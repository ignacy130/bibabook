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
    class InterfacesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISearchable>().To<Implementation.Interfaces.Searchable>();
        }
    }
}