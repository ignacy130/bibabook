using Bibabook.Implementation.DatabaseContext;
using Bibabook.Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DodanieBazy
{
    class Program
    {
        static void Main(string[] args)
        {

            /*entity
                    public DateTime Created { get; set; }
                    public DateTime Modified { get; set; }
                    public bool Deleted { get; set; }
            */
            var db = new DataBaseContext();

            Credentials credentials = new Credentials();
            credentials.Salt = "asdasd";
            credentials.Hash = "#####";

            db.Credentials.Add(credentials);

            AppUser appuser = new AppUser();
            appuser.AppUserID = Guid.NewGuid();

            appuser.Name = "Zbyszek";
            appuser.Surname = "Zbychowicz";
            appuser.Email = "zbyszek@gmail.com";
            appuser.Credentials = credentials;
            appuser.Birthday = DateTime.Now.AddYears(-20);
            appuser.Sex = Contract.Enums.Sex.Male;
            appuser.Avatar = "sciezkadoawatara";
            appuser.Friends = new List<AppUser> { };
            appuser.Notifications = new List<Notification>();
            appuser.Events = new List<AppEvent>();
            appuser.Posts = new List<EventPost>();

            appuser.Created = DateTime.Now;
            appuser.Modified = DateTime.Now;
            appuser.Deleted = false;

            db.AppUsers.Add(appuser);

            EventPost eventpost = new EventPost();
            eventpost.Content = "Super opis super miejsca gdzie trudno się dostać, bo jest na drugim końcu miasta";

            db.EventPosts.Add(eventpost);


            AppEvent appevent = new AppEvent();
            appevent.AppEventID = Guid.NewGuid();
            appevent.Name = "Nazwa Wydarzenia";
            appevent.Description = "Opis tego wydarzenia";
            appevent.AdultsOnly = true;
            appevent.TimeStart = DateTime.Now;
            appevent.TimeEnd = DateTime.Now.AddHours(3);
            appevent.Host = appuser;
            appevent.Guests = new List<AppUser> { appuser };
            appevent.Posts = new List<EventPost> { eventpost };
            appevent.EntryFee = 1m;
            appevent.IsActive = true;
            appevent.Privacy = Contract.Enums.Privacy.Public;
            appevent.Background = "tło";

            appevent.Created = DateTime.Now;
            appevent.Modified = DateTime.Now;
            appevent.Deleted = false;

            db.AppEvents.Add(appevent);







            GeoCoordinate model = new GeoCoordinate() { Altitude = 1, Longitude = 1 };

            db.GeoCoordinates.Add(model);
            db.SaveChanges();
        }
    }
}
