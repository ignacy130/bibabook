using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
namespace Bibabook.Implementation.SearchService.SearchHelpers
{
    public class AdvancedSearchHelper : IAdvancedSearchHelper
    {
        public ICollection<IAppUser> SearchUsers(ISearchParameters searchParameters)
        {
            throw new NotImplementedException();
        }

        public ICollection<IAppEvent> SearchEvents(ISearchParameters searchParameters)
        {
            throw new NotImplementedException();
        }

        public ICollection<INotification> SearchNotifications(ISearchParameters searchParameters)
        {
            throw new NotImplementedException();
        }
    }
}
