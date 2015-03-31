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
    class SearchServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdvancedSearchHelper>().To<Implementation.SearchService.SearchHelpers.AdvancedSearchHelper>();
            Bind<ISearchCondition>().To<Implementation.SearchService.SearchHelpers.SearchCondition>();
            Bind<ISearchHelper>().To<Implementation.SearchService.SearchHelpers.SearchHelper>();
            Bind<ISearchParameters>().To<Implementation.SearchService.SearchHelpers.SearchParameters>();
            Bind<ISearchService>().To<Implementation.SearchService.SearchService>();
        }
    }
}