using Bibabook.Implementation.DatabaseContext;
using Bibabook.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibabook.DAL
{
    public class UserHelper
    {
        public const string USER_SESSION_KEY = "Logged";

        public static AppUser GetLogged(HttpSessionStateBase session)
        {
            if (session == null)
            {
                throw new HttpException("Session is null!");
            }
            else if (session[USER_SESSION_KEY] == null)
            {
                //throw new KeyNotFoundException("No Client logged or wrong key!");
                return null;
            }
            var email = (String) session[USER_SESSION_KEY];
            return GetLogged(email);
        }

        private static AppUser GetLogged(string email)
        {
            AppUser c = null;
            using (DataBaseContext db = new DataBaseContext())
            {
                c = db.AppUsers.Include("Friends").Single(x => x.Email == email);
                return c;
            }
        }

        public static bool IsLogged(HttpSessionStateBase session)
        {
            try
            {
                return session[USER_SESSION_KEY] != null ? true : false;
            }
            catch (Exception)
            {
                return false;
            }
            
        }


    }
}