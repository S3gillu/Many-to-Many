namespace Many_To_Many.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sau3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Sau.Courses", "CourseName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("Sau.Courses", "CourseName", c => c.String());
        }
    }
}
