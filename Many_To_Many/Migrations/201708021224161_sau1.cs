namespace Many_To_Many.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sau1 : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.Courses", newSchema: "Sau");
            MoveTable(name: "dbo.Stus", newSchema: "Sau");
            MoveTable(name: "dbo.StudentCourse", newSchema: "Sau");
        }
        
        public override void Down()
        {
            MoveTable(name: "Sau.StudentCourse", newSchema: "dbo");
            MoveTable(name: "Sau.Stus", newSchema: "dbo");
            MoveTable(name: "Sau.Courses", newSchema: "dbo");
        }
    }
}
