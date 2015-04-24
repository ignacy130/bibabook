namespace Bibabook.Implementation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppEvents",
                c => new
                    {
                        AppEventID = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        AdultsOnly = c.Boolean(nullable: false),
                        TimeStart = c.DateTime(nullable: false),
                        TimeEnd = c.DateTime(nullable: false),
                        EntryFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsActive = c.Boolean(nullable: false),
                        Privacy = c.Int(nullable: false),
                        Background = c.String(),
                        EntityID = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        AppUser_AppUserID = c.Guid(),
                        Host_AppUserID = c.Guid(),
                        Place_PlaceID = c.Guid(),
                    })
                .PrimaryKey(t => t.AppEventID)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_AppUserID)
                .ForeignKey("dbo.AppUsers", t => t.Host_AppUserID)
                .ForeignKey("dbo.Places", t => t.Place_PlaceID)
                .Index(t => t.AppUser_AppUserID)
                .Index(t => t.Host_AppUserID)
                .Index(t => t.Place_PlaceID);
            
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        AppUserID = c.Guid(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        Sex = c.Int(nullable: false),
                        Avatar = c.String(),
                        EntityID = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Credentials_CredentialsID = c.Guid(),
                        AppUser_AppUserID = c.Guid(),
                        AppEvent_AppEventID = c.Guid(),
                    })
                .PrimaryKey(t => t.AppUserID)
                .ForeignKey("dbo.Credentials", t => t.Credentials_CredentialsID)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_AppUserID)
                .ForeignKey("dbo.AppEvents", t => t.AppEvent_AppEventID)
                .Index(t => t.Credentials_CredentialsID)
                .Index(t => t.AppUser_AppUserID)
                .Index(t => t.AppEvent_AppEventID);
            
            CreateTable(
                "dbo.Credentials",
                c => new
                    {
                        CredentialsID = c.Guid(nullable: false),
                        Hash = c.String(),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.CredentialsID);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NotificationID = c.Guid(nullable: false),
                        Json = c.String(maxLength: 3000),
                        Receivied = c.Boolean(nullable: false),
                        EntityID = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        AppUser_AppUserID = c.Guid(),
                    })
                .PrimaryKey(t => t.NotificationID)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_AppUserID)
                .Index(t => t.AppUser_AppUserID);
            
            CreateTable(
                "dbo.EventPosts",
                c => new
                    {
                        EventPostID = c.Guid(nullable: false),
                        Content = c.String(maxLength: 3000),
                        AppUser_AppUserID = c.Guid(),
                        AppEvent_AppEventID = c.Guid(),
                    })
                .PrimaryKey(t => t.EventPostID)
                .ForeignKey("dbo.AppUsers", t => t.AppUser_AppUserID)
                .ForeignKey("dbo.AppEvents", t => t.AppEvent_AppEventID)
                .Index(t => t.AppUser_AppUserID)
                .Index(t => t.AppEvent_AppEventID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Guid(nullable: false),
                        Content = c.String(maxLength: 3000),
                        EntityID = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Post_PostID = c.Guid(),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Posts", t => t.Post_PostID)
                .Index(t => t.Post_PostID);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        EmailID = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        RecipientEmail = c.String(),
                        Subject = c.String(),
                        Content = c.String(maxLength: 3000),
                    })
                .PrimaryKey(t => t.EmailID);
            
            CreateTable(
                "dbo.FriendInvitations",
                c => new
                    {
                        FriendInvitationID = c.Guid(nullable: false),
                        EntityID = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Recipient_AppUserID = c.Guid(),
                        Sender_AppUserID = c.Guid(),
                    })
                .PrimaryKey(t => t.FriendInvitationID)
                .ForeignKey("dbo.AppUsers", t => t.Recipient_AppUserID)
                .ForeignKey("dbo.AppUsers", t => t.Sender_AppUserID)
                .Index(t => t.Recipient_AppUserID)
                .Index(t => t.Sender_AppUserID);
            
            CreateTable(
                "dbo.GeoCoordinates",
                c => new
                    {
                        GeoCoordinateID = c.Guid(nullable: false),
                        Altitude = c.Double(nullable: false),
                        Course = c.Double(nullable: false),
                        HorizontalAccuracy = c.Double(nullable: false),
                        IsUnknown = c.Boolean(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Speed = c.Double(nullable: false),
                        VerticalAccuracy = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GeoCoordinateID);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        PlaceID = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(maxLength: 3000),
                        Capacity = c.Int(nullable: false),
                        EntityID = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                        Location_GeoCoordinateID = c.Guid(),
                        Owner_AppUserID = c.Guid(),
                    })
                .PrimaryKey(t => t.PlaceID)
                .ForeignKey("dbo.GeoCoordinates", t => t.Location_GeoCoordinateID)
                .ForeignKey("dbo.AppUsers", t => t.Owner_AppUserID)
                .Index(t => t.Location_GeoCoordinateID)
                .Index(t => t.Owner_AppUserID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostID = c.Guid(nullable: false),
                        Content = c.String(maxLength: 3000),
                        EntityID = c.Guid(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PostID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Post_PostID", "dbo.Posts");
            DropForeignKey("dbo.Places", "Owner_AppUserID", "dbo.AppUsers");
            DropForeignKey("dbo.Places", "Location_GeoCoordinateID", "dbo.GeoCoordinates");
            DropForeignKey("dbo.AppEvents", "Place_PlaceID", "dbo.Places");
            DropForeignKey("dbo.FriendInvitations", "Sender_AppUserID", "dbo.AppUsers");
            DropForeignKey("dbo.FriendInvitations", "Recipient_AppUserID", "dbo.AppUsers");
            DropForeignKey("dbo.EventPosts", "AppEvent_AppEventID", "dbo.AppEvents");
            DropForeignKey("dbo.AppEvents", "Host_AppUserID", "dbo.AppUsers");
            DropForeignKey("dbo.AppUsers", "AppEvent_AppEventID", "dbo.AppEvents");
            DropForeignKey("dbo.EventPosts", "AppUser_AppUserID", "dbo.AppUsers");
            DropForeignKey("dbo.Notifications", "AppUser_AppUserID", "dbo.AppUsers");
            DropForeignKey("dbo.AppUsers", "AppUser_AppUserID", "dbo.AppUsers");
            DropForeignKey("dbo.AppEvents", "AppUser_AppUserID", "dbo.AppUsers");
            DropForeignKey("dbo.AppUsers", "Credentials_CredentialsID", "dbo.Credentials");
            DropIndex("dbo.Places", new[] { "Owner_AppUserID" });
            DropIndex("dbo.Places", new[] { "Location_GeoCoordinateID" });
            DropIndex("dbo.FriendInvitations", new[] { "Sender_AppUserID" });
            DropIndex("dbo.FriendInvitations", new[] { "Recipient_AppUserID" });
            DropIndex("dbo.Comments", new[] { "Post_PostID" });
            DropIndex("dbo.EventPosts", new[] { "AppEvent_AppEventID" });
            DropIndex("dbo.EventPosts", new[] { "AppUser_AppUserID" });
            DropIndex("dbo.Notifications", new[] { "AppUser_AppUserID" });
            DropIndex("dbo.AppUsers", new[] { "AppEvent_AppEventID" });
            DropIndex("dbo.AppUsers", new[] { "AppUser_AppUserID" });
            DropIndex("dbo.AppUsers", new[] { "Credentials_CredentialsID" });
            DropIndex("dbo.AppEvents", new[] { "Place_PlaceID" });
            DropIndex("dbo.AppEvents", new[] { "Host_AppUserID" });
            DropIndex("dbo.AppEvents", new[] { "AppUser_AppUserID" });
            DropTable("dbo.Posts");
            DropTable("dbo.Places");
            DropTable("dbo.GeoCoordinates");
            DropTable("dbo.FriendInvitations");
            DropTable("dbo.Emails");
            DropTable("dbo.Comments");
            DropTable("dbo.EventPosts");
            DropTable("dbo.Notifications");
            DropTable("dbo.Credentials");
            DropTable("dbo.AppUsers");
            DropTable("dbo.AppEvents");
        }
    }
}
