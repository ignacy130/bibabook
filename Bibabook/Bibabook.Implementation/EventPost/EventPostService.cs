using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Bibabook.Implementation.DatabaseContext;
using Bibabook.Implementation.Models;
namespace Bibabook.Implementation.EventPost
{
    public class EventPostService : IEventPostService
    {
        private DataBaseContext context;

        public EventPostService()
        {
            context = new DataBaseContext(); 
        }

        public bool Create(IEventPost eventPost)
        {
            try
            {

                context.EventPosts.Add(eventPost as Models.EventPost);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }

        }

        public bool Edit(IEventPost eventPost, string newContent)
        {

           
            //w modelu EventPost dodany author, czy sprawdzanie uzytkownika nie powinno byc na poziomie kontrolera ?
                try
                {
                    
                    Models.EventPost oldpost = context.EventPosts.First(x => x == eventPost);
                    oldpost.Content = newContent;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                    throw e;
                }

        }

        public bool AddPostComment(IEventPost eventPost, IPostComment postComment)
        {


            try
            {
                Models.EventPost postToComment = context.EventPosts.First(x => x == eventPost);
                context.Comments.Add(postComment as Comment);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
         




        }

        public bool Delete(IEventPost eventPost)
        {
            
                try
                {
                    
                    Models.EventPost postToRemove = context.EventPosts.First(x => x == eventPost);
                    context.EventPosts.Remove(postToRemove);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                    throw e;
                }
        }
    }
}
