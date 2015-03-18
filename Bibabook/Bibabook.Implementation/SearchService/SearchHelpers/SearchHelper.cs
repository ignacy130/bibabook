using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
namespace Bibabook.Implementation.SearchService.SearchHelpers
{
    public class SearchHelper:ISearchHelper
    {
        public IAppUser SearchUser(Guid appUserId)
        {
            throw new NotImplementedException();
        }

        public IAppEvent SearchEvent(Guid appEventId)
        {
            throw new NotImplementedException();
        }

        public INotification SearchNotification(Guid notificationId)
        {
            throw new NotImplementedException();
        }

        public IEventPost SearchPost(Guid eventPostId)
        {
            throw new NotImplementedException();
        }

        public IPostComment SearchComment(Guid postCommentId)
        {
            throw new NotImplementedException();
        }
    }
}
