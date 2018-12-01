namespace EnittyFrameworkFluentApiApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullDuplexConfiguration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        Location = c.String(),
                        TeacherId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        StandardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Standards", t => t.StandardId)
                .Index(t => t.StandardId);
            
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        StandartId = c.Int(nullable: false, identity: true),
                        StandardName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StandartId);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(),
                        TeacherType = c.String(),
                        StandardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Standards", t => t.StandardId)
                .Index(t => t.StandardId);
            
            CreateTable(
                "dbo.StudentAddresses",
                c => new
                    {
                        StudentAddressId = c.Int(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        City = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.StudentAddressId)
                .ForeignKey("dbo.Students", t => t.StudentAddressId)
                .Index(t => t.StudentAddressId);
            
            CreateTable(
                "dbo.StudentCourse",
                c => new
                    {
                        StudentRefId = c.Int(nullable: false),
                        CourseRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentRefId, t.CourseRefId })
                .ForeignKey("dbo.Students", t => t.StudentRefId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.CourseRefId, cascadeDelete: true)
                .Index(t => t.StudentRefId)
                .Index(t => t.CourseRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.StudentAddresses", "StudentAddressId", "dbo.Students");
            DropForeignKey("dbo.Students", "StandardId", "dbo.Standards");
            DropForeignKey("dbo.Teachers", "StandardId", "dbo.Standards");
            DropForeignKey("dbo.StudentCourse", "CourseRefId", "dbo.Courses");
            DropForeignKey("dbo.StudentCourse", "StudentRefId", "dbo.Students");
            DropIndex("dbo.StudentCourse", new[] { "CourseRefId" });
            DropIndex("dbo.StudentCourse", new[] { "StudentRefId" });
            DropIndex("dbo.StudentAddresses", new[] { "StudentAddressId" });
            DropIndex("dbo.Teachers", new[] { "StandardId" });
            DropIndex("dbo.Students", new[] { "StandardId" });
            DropIndex("dbo.Courses", new[] { "TeacherId" });
            DropTable("dbo.StudentCourse");
            DropTable("dbo.StudentAddresses");
            DropTable("dbo.Teachers");
            DropTable("dbo.Standards");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
