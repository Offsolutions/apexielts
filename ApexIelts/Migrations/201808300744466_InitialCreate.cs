namespace ApexIelts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Accountid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Mobile = c.String(),
                        Usename = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Accountid);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Albumid = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(),
                        Image = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Albumid);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        Albumid = c.Int(nullable: false),
                        Thumbnail = c.String(),
                        Images = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryId)
                .ForeignKey("dbo.Albums", t => t.Albumid, cascadeDelete: true)
                .Index(t => t.Albumid);
            
            CreateTable(
                "dbo.AssignTests",
                c => new
                    {
                        Assignid = c.Int(nullable: false, identity: true),
                        Studentid = c.Int(nullable: false),
                        Ieltsid = c.Int(nullable: false),
                        Image = c.String(),
                        date = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Assignid)
                .ForeignKey("dbo.IeltsTests", t => t.Ieltsid, cascadeDelete: true)
                .ForeignKey("dbo.StudentDetails", t => t.Studentid, cascadeDelete: true)
                .Index(t => t.Studentid)
                .Index(t => t.Ieltsid);
            
            CreateTable(
                "dbo.IeltsTests",
                c => new
                    {
                        Ieltsid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Categoryid = c.Int(nullable: false),
                        TestType = c.String(),
                        Image = c.String(),
                        Url = c.String(),
                        Audio = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Ieltsid)
                .ForeignKey("dbo.Categories", t => t.Categoryid, cascadeDelete: true)
                .Index(t => t.Categoryid);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Categoryid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Categoryid);
            
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        Studentid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FatherName = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Gender = c.String(),
                        DOB = c.DateTime(),
                        Image = c.String(),
                        Address = c.String(),
                        Qualification = c.String(),
                        CourseType = c.String(),
                        RollNo = c.String(),
                        JoiningDate = c.DateTime(),
                        UserName = c.String(),
                        Password = c.String(),
                        date = c.DateTime(nullable: false),
                        Status = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Studentid);
            
            CreateTable(
                "dbo.Clientlogoes",
                c => new
                    {
                        Clientid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Image = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Clientid);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Contactid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(),
                        Mobile = c.String(),
                        Email = c.String(),
                        Address = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Contactid);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        Featureid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ShortDescription = c.String(),
                        Image = c.String(),
                        date = c.DateTime(nullable: false),
                        Thumbnail = c.String(),
                        Keyword = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.Featureid);
            
            CreateTable(
                "dbo.Logoes",
                c => new
                    {
                        Logoid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Image = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Logoid);
            
            CreateTable(
                "dbo.news",
                c => new
                    {
                        Newsid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ShortDescription = c.String(),
                        Image = c.String(),
                        Thumbnail = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Newsid);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Serviceid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        ShortDescription = c.String(),
                        Image = c.String(),
                        date = c.DateTime(nullable: false),
                        Thumbnail = c.String(),
                        Keyword = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.Serviceid);
            
            CreateTable(
                "dbo.sliders",
                c => new
                    {
                        Sliderid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Image = c.String(),
                        url = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Sliderid);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        Testid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Image = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Testid);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        Videoid = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Image = c.String(),
                        Url = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Videoid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AssignTests", "Studentid", "dbo.StudentDetails");
            DropForeignKey("dbo.IeltsTests", "Categoryid", "dbo.Categories");
            DropForeignKey("dbo.AssignTests", "Ieltsid", "dbo.IeltsTests");
            DropForeignKey("dbo.Galleries", "Albumid", "dbo.Albums");
            DropIndex("dbo.IeltsTests", new[] { "Categoryid" });
            DropIndex("dbo.AssignTests", new[] { "Ieltsid" });
            DropIndex("dbo.AssignTests", new[] { "Studentid" });
            DropIndex("dbo.Galleries", new[] { "Albumid" });
            DropTable("dbo.Videos");
            DropTable("dbo.Testimonials");
            DropTable("dbo.sliders");
            DropTable("dbo.Services");
            DropTable("dbo.news");
            DropTable("dbo.Logoes");
            DropTable("dbo.Features");
            DropTable("dbo.Contacts");
            DropTable("dbo.Clientlogoes");
            DropTable("dbo.StudentDetails");
            DropTable("dbo.Categories");
            DropTable("dbo.IeltsTests");
            DropTable("dbo.AssignTests");
            DropTable("dbo.Galleries");
            DropTable("dbo.Albums");
            DropTable("dbo.Accounts");
        }
    }
}
