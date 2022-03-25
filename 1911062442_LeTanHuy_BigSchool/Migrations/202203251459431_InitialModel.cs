namespace _1911062442_LeTanHuy_BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            AddColumn("dbo.Courses", "IsCanceled", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Courses", "LecturerId");
            AddForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "LecturerId" });
            AlterColumn("dbo.Courses", "LecturerId", c => c.String(maxLength: 128));
            DropColumn("dbo.Courses", "IsCanceled");
            CreateIndex("dbo.Courses", "LecturerId");
            AddForeignKey("dbo.Courses", "LecturerId", "dbo.AspNetUsers", "Id");
        }
    }
}
