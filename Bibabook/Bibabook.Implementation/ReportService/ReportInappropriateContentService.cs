using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
namespace Bibabook.Implementation.ReportService
{
    public class ReportInappropriateContentService : IReportInappropriateContentService
    {

        public void ReportEvent(IAppEvent userReporting, IAppEvent eventReported, ReportReason reason)
        {
            throw new NotImplementedException();
        }

        public void ReportPost(IAppEvent userReporting, IEventPost postReported, ReportReason reason)
        {
            throw new NotImplementedException();
        }

        public void ReportComment(IAppEvent userReporting, IPostComment postComment, ReportReason reason)
        {
            throw new NotImplementedException();
        }
    }
}
