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
    class PostCommentModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPostCommentService>().To<Implementation.PostComment.PostCommentService>();
        }
    }
}