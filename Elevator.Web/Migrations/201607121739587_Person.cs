namespace Elevator.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Person : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        PersonName = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
