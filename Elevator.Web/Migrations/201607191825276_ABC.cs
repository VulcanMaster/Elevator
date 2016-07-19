namespace Elevator.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ABC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elevators",
                c => new
                    {
                        ElevatorsId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorsId);
            
            CreateTable(
                "dbo.ServiceBoards",
                c => new
                    {
                        ServiceBoardId = c.Int(nullable: false, identity: true),
                        IncidentDate = c.DateTime(nullable: false),
                        Elevator_ElevatorsId = c.Int(),
                    })
                .PrimaryKey(t => t.ServiceBoardId)
                .ForeignKey("dbo.Elevators", t => t.Elevator_ElevatorsId)
                .Index(t => t.Elevator_ElevatorsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceBoards", "Elevator_ElevatorsId", "dbo.Elevators");
            DropIndex("dbo.ServiceBoards", new[] { "Elevator_ElevatorsId" });
            DropTable("dbo.ServiceBoards");
            DropTable("dbo.Elevators");
        }
    }
}
