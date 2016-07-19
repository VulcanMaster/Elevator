namespace Elevator.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DEF : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServiceBoards", "Elevator_ElevatorsId", "dbo.Elevators");
            DropIndex("dbo.ServiceBoards", new[] { "Elevator_ElevatorsId" });
            RenameColumn(table: "dbo.ServiceBoards", name: "Elevator_ElevatorsId", newName: "ElevatorsId");
            AlterColumn("dbo.ServiceBoards", "ElevatorsId", c => c.Int(nullable: false));
            CreateIndex("dbo.ServiceBoards", "ElevatorsId");
            AddForeignKey("dbo.ServiceBoards", "ElevatorsId", "dbo.Elevators", "ElevatorsId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceBoards", "ElevatorsId", "dbo.Elevators");
            DropIndex("dbo.ServiceBoards", new[] { "ElevatorsId" });
            AlterColumn("dbo.ServiceBoards", "ElevatorsId", c => c.Int());
            RenameColumn(table: "dbo.ServiceBoards", name: "ElevatorsId", newName: "Elevator_ElevatorsId");
            CreateIndex("dbo.ServiceBoards", "Elevator_ElevatorsId");
            AddForeignKey("dbo.ServiceBoards", "Elevator_ElevatorsId", "dbo.Elevators", "ElevatorsId");
        }
    }
}
