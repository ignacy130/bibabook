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
using System.Security.Cryptography;

namespace Bibabook.Implementation.AppUserService
{
    /// <summary>
    /// Odpowiedzialny za rejestracje, logowanie, role czy blokowanie uzytkowników
    /// </summary>
    public class UsersService : IAppUserService
    {
        private DataBaseContext context;


        public UsersService()
        {
            this.context = new DataBaseContext();
        }

        public bool CreateAccount(IAppUser user) // pamiętać że podany user musi mieć pola IsVerified=false,IsActive = true;
        {
            bool user_test = context.AppUsers.Any(u => u.Email == ((AppUser)user).Email); //weryfikacja po email czy juz ktos istnieje z takim mailem
            if ((user is AppUser) && user_test)
            {
                try
                {
                    string password = (user as AppUser).Credentials.Hash;       //pobranie hasła
                    Random los = new Random();
                    int salt = los.Next(0, 100);                                //wylosowanie soli
                    password = password + salt.ToString();                      //doklejenie soli
                    string hashedpassword = sha256_hash(password);              //zahaszowanie hasła
                    (user as AppUser).Credentials.Hash = hashedpassword;        //dodanie do bazy zahaszowanego hasła
                    (user as AppUser).Credentials.Salt = salt.ToString();       //dodanie do bazy soli 

                    context.AppUsers.Add((AppUser)user);                        // dodanie usera
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
            if (appUser is AppUser&&appUser!=null)
            {
                try
                {
                    AppUser user = context.AppUsers.Single(u => u.AppUserID == ((AppUser)appUser).AppUserID);
                    user.IsVerified = true;
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

        public bool CloseAccount(IAppUser appUser)
        {
            if (appUser is AppUser && appUser != null)
            {
                try
                {
                    AppUser user = context.AppUsers.Single(u => u.AppUserID == ((AppUser)appUser).AppUserID);
                    user.IsActive = false;
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

        public bool BanUser(IAppUser appUser, DateTime expirationDate)
        {
            //czeka na modyfikację bazy danych, brakuję jakiejś ważności konta w bazie
            throw new NotImplementedException(); 
        }

        public bool ChangeUserRole(IAppUser appUser, string roleName)
        {
            //czeka na modyfikację bazy danych, brakuje jakichkolwiek ról
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
                    AppUser user = context.AppUsers.Single(u => u.AppUserID == ((AppUser)appUser).AppUserID); //możliwe że będziemy szykali po e-mail
                    Random los = new Random();
                    int newSalt = los.Next(0, 100);                                //wylosowanie soli
                    newPassword = newPassword + newSalt.ToString();                //doklejenie soli
                    string hashedpassword = sha256_hash(newPassword);              //zahaszowanie hasła

                    user.Credentials.Hash = hashedpassword;
                    user.Credentials.Salt = newSalt.ToString();

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
        public static string sha256_hash(String value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return String.Join("", hash
                  .ComputeHash(Encoding.UTF8.GetBytes(value))
                  .Select(item => item.ToString("x2")));
            }
        } 
    }
}
