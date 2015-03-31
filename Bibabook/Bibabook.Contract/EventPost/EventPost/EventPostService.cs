using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
namespace Bibabook.Implementation.EventPost
{
    public class EventPostService : IEventPostService
    {
        public bool Create(IEventPost eventPost)
        {
            throw new NotImplementedException();
        }

        public bool Edit(IEventPost eventPost, string newContent)
        {
            throw new NotImplementedException();
        }

        public bool AddPostComment(IEventPost eventPost, IPostComment postComment)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IEventPost eventPost)
        {
            throw new NotImplementedException();
        }
    }
}
