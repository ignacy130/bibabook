namespace Bibabook.Implementation.Migrations
{
    using Bibabook.Implementation.DatabaseContext;
    using Bibabook.Implementation.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Bibabook.Implementation.DatabaseContext.DataBaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Bibabook.Implementation.DatabaseContext.DataBaseContext context)
        {
            var db = new DataBaseContext();

            Credentials credentials = new Credentials();
            credentials.CredentialsID = Guid.NewGuid();
            credentials.Salt = "asdasd";
            credentials.Hash = "#####";

            //db.Credentials.Add(credentials);
            db.SaveChanges();
            AppUser appuser = new AppUser();
            appuser.AppUserID = Guid.NewGuid();

            appuser.Name = "Zbyszek";
            appuser.Surname = "Zbychowicz";
            appuser.Email = "zbyszek@gmail.com";
            //appuser.Credentials = credentials;
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

            //db.AppUsers.Add(appuser);
            db.SaveChanges();

            AppUser appuser1 = new AppUser();
            appuser1.AppUserID = Guid.NewGuid();

            appuser1.Name = "Daniel";
            appuser1.Surname = "Danielowicz";
            appuser1.Email = "daniel@gmail.com";
            //appuser1.Credentials = credentials;
            appuser1.Birthday = DateTime.Now.AddYears(-22);
            appuser1.Sex = Contract.Enums.Sex.Male;
            appuser1.Avatar = "awatar";
            appuser1.Friends = new List<AppUser> { };
            appuser1.Notifications = new List<Notification>();
            appuser1.Events = new List<AppEvent>();
            appuser1.Posts = new List<EventPost>();

            appuser1.Created = DateTime.Now;
            appuser1.Modified = DateTime.Now;
            appuser1.Deleted = false;

            //db.AppUsers.Add(appuser1);
            db.SaveChanges();

            EventPost eventpost = new EventPost();
            eventpost.EventPostID = Guid.NewGuid();
            eventpost.Content = "Super opis super miejsca gdzie trudno się dostać, bo jest na drugim końcu miasta";

            db.EventPosts.Add(eventpost);
            db.SaveChanges();

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

            //db.AppEvents.Add(appevent);
            db.SaveChanges();
            Comment comment = new Comment();

            comment.CommentID = Guid.NewGuid();
            comment.Content = "coś nowego opisanego tutaj wzbudzającego kontrowersje i cieszącego internetowych troli";

            comment.Created = DateTime.Now;
            comment.Modified = DateTime.Now;
            comment.Deleted = false;

            //db.Comments.Add(comment);
            db.SaveChanges();


            Email email = new Email();

            email.EmailID = Guid.NewGuid();
            email.Date = DateTime.Now.AddDays(-2);
            email.RecipientEmail = "zbyszek@gmail.com";
            email.Subject = "Ważny temat";
            email.Content = "Zawartość maila 123 !@#$$%^&*()_+łóęąśćźżżę";

            //db.Emails.Add(email);
            db.SaveChanges();
            GeoCoordinate geocoordinate = new GeoCoordinate() { Altitude = 1, Longitude = 1 };
            geocoordinate.GeoCoordinateID = Guid.NewGuid();
            //db.GeoCoordinates.Add(geocoordinate);
            db.SaveChanges();
            FriendInvitation friendinvitation = new FriendInvitation();

            friendinvitation.FriendInvitationID = Guid.NewGuid();
            friendinvitation.FriendInvitationID = Guid.NewGuid();
            friendinvitation.Sender = appuser;
            //friendinvitation.Recipient = new AppUser();//appuser2

            //db.FriendInvatations.Add(friendinvitation);
            db.SaveChanges();

            Notification notifcation = new Notification();

            notifcation.NotificationID = Guid.NewGuid();
            notifcation.Json = "Jakis JSON {obiekt} itp, nie mam pojecia jak je sie tworzy";
            notifcation.Receivied = false;

            notifcation.Created = DateTime.Now;
            notifcation.Modified = DateTime.Now;
            notifcation.Deleted = false;

            //db.Notifications.add();


            Place place = new Place();

            place.PlaceID = Guid.NewGuid();
            place.Name = "Dzika przystań na Kabatach";
            place.Description = "Najbardziej otwarta siedziba ze wszystkich";
            place.Owner = appuser;
            place.Location = geocoordinate;
            place.Capacity = 50;
            place.Events = new List<AppEvent>();

            place.Created = DateTime.Now;
            place.Modified = DateTime.Now;
            place.Deleted = false;

            db.Places.Add(place);
            db.SaveChanges();

            Post post = new Post();

            post.PostID = Guid.NewGuid();
            post.Content = "Jakiś komentarz o ambiwalentnym stosunku";
            post.Comments = new List<Comment> { comment };

            post.Created = DateTime.Now;
            post.Modified = DateTime.Now;
            post.Deleted = false;

            var asd = db.Posts.Add(post);


            var c = db.SaveChanges();
        }
    }
}
