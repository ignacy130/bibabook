using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Bibabook.Implementation.Models;

namespace Bibabook.Implementation.DatabaseContext
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("BibabookDB")
        {
            Database.SetInitializer<DataBaseContext>(new DropCreateDatabaseAlways<DataBaseContext>());
        }

        public DbSet<AppEvent> AppEvents { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Credentials> Credentials { get; set; }
        public DbSet<Bibabook.Implementation.Models.EventPost> EventPosts { get; set; }
        public DbSet<FriendInvitation> FriendInvatations { get; set; }
        public DbSet<GeoCoordinate> GeoCoordinates { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Email> Emails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }


    }
}