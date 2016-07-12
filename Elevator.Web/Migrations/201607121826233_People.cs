namespace Elevator.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class People : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PeopleId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Area = c.String(),
                        PersCode = c.String(),
                        ContractNum = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        ElectricityAccessExpiryDate = c.DateTime(nullable: false),
                        ElevatorAccessExpiryDate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.PeopleId);
            
            //DropTable("dbo.People");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Area = c.String(),
                        PersCode = c.String(),
                        ContractNum = c.String(),
                        Mobile = c.String(),
                        Phone = c.String(),
                        ElectricityAccessExpiryDate = c.DateTime(nullable: false),
                        ElevatorAccessExpiryDate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
            DropTable("dbo.People");
        }
    }
}
