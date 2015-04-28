using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Bibabook.Implementation.DatabaseContext;
using Bibabook.Implementation.Models;
using System.Text.RegularExpressions;
using System.Data.Entity;
using System.Web.Mvc;

namespace Bibabook.Implementation.AppUserService
{
    /// <summary>
    /// Odpowiedzialny za rejestracje, logowanie, role czy blokowanie uzytkowników
    /// </summary>
    public class UsersService : IAppUserService
    {
        private DataBaseContext context;


        public UsersService() { } // ten konstruktor stworzony tylko po to żeby test się nie sypał 
        public UsersService(DataBaseContext ctx)
        {
            this.context = ctx;
        }

        public bool CreateAccount(IAppUser user)
        {
            bool user_test = context.AppUsers.Any(u => u.Email == ((AppUser)user).Email); //weryfikacja po email czy juz ktos istnieje z takim mailem
            if ((user is AppUser) && user_test)
            {
                try
                {
                    context.AppUsers.Add((AppUser)user);
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }
        }

        public bool VerifyAccount(IAppUser appUser)
        {
            //czeka na modyfikację bazy danych
            throw new NotImplementedException();

        }

        public bool CloseAccount(IAppUser appUser)
        {
            //czeka na modyfikację bazy danych
            throw new NotImplementedException();
        }

        public bool BanUser(IAppUser appUser, DateTime expirationDate)
        {
            //czeka na modyfikację bazy danych
            throw new NotImplementedException();
        }

        public bool ChangeUserRole(IAppUser appUser, string roleName)
        {
            //czeka na modyfikację bazy danych
            throw new NotImplementedException();
        }

        public bool ChangeUserEmail(IAppUser appUser, string newEmail)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(newEmail) && appUser != null)
            {
                try
                {
                    AppUser user = context.AppUsers.Single(u => u.AppUserID == ((AppUser)appUser).AppUserID);
                    user.Email = newEmail;
                    context.Entry(appUser).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ChangeUserPassword(IAppUser appUser, string newPassword)
        {
            if (appUser != null)
            {
                try
                {
                    AppUser user = context.AppUsers.Single(u => u.AppUserID == ((AppUser)appUser).AppUserID);
                    user.Credentials.Hash = newPassword;
                    context.Entry(appUser).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }


        }

        public bool ChangeUserAvatar(IAppUser appUser, string newAvatarPath)
        {
            string pattern = @"(?i)\.(jpg)$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(newAvatarPath) && appUser != null)
            {
                try
                {
                    AppUser user = context.AppUsers.Single(u => u.AppUserID == ((AppUser)appUser).AppUserID);
                    user.Avatar = newAvatarPath;
                    context.Entry(appUser).State = EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
