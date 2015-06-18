using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using Bibabook.Implementation.Models;
using Bibabook.Implementation.DatabaseContext;
using System.Data.Entity;

namespace Bibabook.Implementation.AppUserService
{
    /// <summary>
    /// Odpowiedzialny za wysylanie zaproszen do grona znajomych oraz dodawanie i usuwanie znajomych
    /// </summary>
    public class SocialService : IAppUserSocialService
    {
        INotificationService _notificationService;
        DataBaseContext _context;
        public SocialService()
        {

        }

        public SocialService(INotificationService notificationService)
        {
            _context = new DataBaseContext();
            _notificationService = notificationService;
        }

        public bool SendFriendInvitation(IAppUser sender, IAppUser receiver)
        {
            
            FriendInvitation fi = new FriendInvitation()
            {
                Created = DateTime.Now,
                Deleted = false,
                EntityID = new Guid(),
                FriendInvitationID = new Guid(),
                Modified = DateTime.Now,
                Recipient = (AppUser)receiver,
                Sender = (AppUser)sender
            };
            _context.FriendInvatations.Add(fi);
            
            Notification n = new Notification()
            {
                Created = DateTime.Now,
                Deleted = false,
                EntityID = new Guid(),
                Json = "",
                Modified = DateTime.Now,
                NotificationID = new Guid(),
                Receivied = false
            };
            
            var au = (AppUser)receiver;
            _notificationService.Create(n);

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool FriendUsers(IAppUser firstUser, IAppUser secondUser)
        {
            var fu = (AppUser)firstUser;
            var su = (AppUser)secondUser;
            fu = _context.AppUsers.Single(x => x.AppUserID == fu.AppUserID);
            su = _context.AppUsers.Single(x => x.AppUserID == su.AppUserID);

            fu.Friends.Add(su);
            su.Friends.Add(fu);
            _context.Entry(fu).State = EntityState.Modified;
            _context.Entry(su).State = EntityState.Modified;
            
            if (_context.FriendInvatations.Any(x => (x.Sender.EntityID == su.EntityID && x.Recipient.EntityID == fu.EntityID) || ( x.Sender.EntityID == fu.EntityID && x.Recipient.EntityID == su.EntityID)))
            {
                var invs = _context.FriendInvatations.Where(x => (x.Sender.EntityID == su.EntityID && x.Recipient.EntityID == fu.EntityID) || (x.Sender.EntityID == fu.EntityID && x.Recipient.EntityID == su.EntityID));
                foreach (FriendInvitation invit in invs)
                {
                    invit.Deleted = true;
                    invit.Modified = DateTime.Now;
                    _context.Entry(invit).State = EntityState.Modified;
                }
            }
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public bool UnfriendUsers(IAppUser firstUser, IAppUser secondUser)
        {
            var fu = (AppUser)firstUser;
            var su = (AppUser)secondUser;

            su.Friends.Remove(su);
            su.Friends.Remove(fu);
            _context.Entry(fu).State = EntityState.Modified;
            _context.Entry(su).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
