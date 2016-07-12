namespace Elevator.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dictionaries : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionExpends",
                c => new
                    {
                        AdditionExpendId = c.Int(nullable: false, identity: true),
                        AddExpName = c.String(),
                        AddExpBasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.AdditionExpendId);
            
            CreateTable(
                "dbo.ClientsBanks",
                c => new
                    {
                        ClientsBankId = c.Int(nullable: false, identity: true),
                        ClientsBankName = c.String(),
                    })
                .PrimaryKey(t => t.ClientsBankId);
            
            CreateTable(
                "dbo.ElevatorCapacities",
                c => new
                    {
                        ElevatorCapacityId = c.Int(nullable: false, identity: true),
                        ElevatorCapacityValue = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorCapacityId);
            
            CreateTable(
                "dbo.ElevatorControllers",
                c => new
                    {
                        ElevatorControllerId = c.Int(nullable: false, identity: true),
                        ElevatorControllerName = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorControllerId);
            
            CreateTable(
                "dbo.ElevatorDrivePowers",
                c => new
                    {
                        ElevatorDrivePowerId = c.Int(nullable: false, identity: true),
                        ElevatorDrivePowerValue = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorDrivePowerId);
            
            CreateTable(
                "dbo.ElevatorDriveTypes",
                c => new
                    {
                        ElevatorDriveTypeId = c.Int(nullable: false, identity: true),
                        ElevatorDriveTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorDriveTypeId);
            
            CreateTable(
                "dbo.ElevatorNowStatus",
                c => new
                    {
                        ElevatorNowStatusId = c.Int(nullable: false, identity: true),
                        ElevatorNowStatusName = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorNowStatusId);
            
            CreateTable(
                "dbo.ElevatorProducers",
                c => new
                    {
                        ElevatorProducerId = c.Int(nullable: false, identity: true),
                        ElevatorProducerName = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorProducerId);
            
            CreateTable(
                "dbo.ElevatorSuspensionTypes",
                c => new
                    {
                        ElevatorSuspensionTypeId = c.Int(nullable: false, identity: true),
                        ElevatorSuspensionTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorSuspensionTypeId);
            
            CreateTable(
                "dbo.ElevatorTypes",
                c => new
                    {
                        ElevatorTypeId = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                        TypeCapacity_ElevatorCapacityId = c.Int(),
                        TypeController_ElevatorControllerId = c.Int(),
                        TypeDrivePower_ElevatorDrivePowerId = c.Int(),
                        TypeDriveType_ElevatorDriveTypeId = c.Int(),
                        TypeProducer_ElevatorProducerId = c.Int(),
                        TypeView_ElevatorViewId = c.Int(),
                    })
                .PrimaryKey(t => t.ElevatorTypeId)
                .ForeignKey("dbo.ElevatorCapacities", t => t.TypeCapacity_ElevatorCapacityId)
                .ForeignKey("dbo.ElevatorControllers", t => t.TypeController_ElevatorControllerId)
                .ForeignKey("dbo.ElevatorDrivePowers", t => t.TypeDrivePower_ElevatorDrivePowerId)
                .ForeignKey("dbo.ElevatorDriveTypes", t => t.TypeDriveType_ElevatorDriveTypeId)
                .ForeignKey("dbo.ElevatorProducers", t => t.TypeProducer_ElevatorProducerId)
                .ForeignKey("dbo.ElevatorViews", t => t.TypeView_ElevatorViewId)
                .Index(t => t.TypeCapacity_ElevatorCapacityId)
                .Index(t => t.TypeController_ElevatorControllerId)
                .Index(t => t.TypeDrivePower_ElevatorDrivePowerId)
                .Index(t => t.TypeDriveType_ElevatorDriveTypeId)
                .Index(t => t.TypeProducer_ElevatorProducerId)
                .Index(t => t.TypeView_ElevatorViewId);
            
            CreateTable(
                "dbo.ElevatorViews",
                c => new
                    {
                        ElevatorViewId = c.Int(nullable: false, identity: true),
                        ElevatorViewName = c.String(),
                    })
                .PrimaryKey(t => t.ElevatorViewId);
            
            CreateTable(
                "dbo.LocationCities",
                c => new
                    {
                        LocationCityId = c.Int(nullable: false, identity: true),
                        LocationCityName = c.String(),
                    })
                .PrimaryKey(t => t.LocationCityId);
            
            CreateTable(
                "dbo.LocationStreets",
                c => new
                    {
                        LocationStreetId = c.Int(nullable: false, identity: true),
                        LocationStreetName = c.String(),
                    })
                .PrimaryKey(t => t.LocationStreetId);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        MaterialName = c.String(),
                        MaterialBasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.MaterialId);
            
            CreateTable(
                "dbo.MechanicAreas",
                c => new
                    {
                        MechanicAreaId = c.Int(nullable: false, identity: true),
                        MechanicAreaName = c.String(),
                    })
                .PrimaryKey(t => t.MechanicAreaId);
            
            CreateTable(
                "dbo.MechanicStatus",
                c => new
                    {
                        MechanicStatusId = c.Int(nullable: false, identity: true),
                        MechanicStatusName = c.String(),
                    })
                .PrimaryKey(t => t.MechanicStatusId);
            
            CreateTable(
                "dbo.Metrics",
                c => new
                    {
                        MetricId = c.Int(nullable: false, identity: true),
                        MetricFullName = c.String(),
                        MetricShortName = c.String(),
                    })
                .PrimaryKey(t => t.MetricId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ElevatorTypes", "TypeView_ElevatorViewId", "dbo.ElevatorViews");
            DropForeignKey("dbo.ElevatorTypes", "TypeProducer_ElevatorProducerId", "dbo.ElevatorProducers");
            DropForeignKey("dbo.ElevatorTypes", "TypeDriveType_ElevatorDriveTypeId", "dbo.ElevatorDriveTypes");
            DropForeignKey("dbo.ElevatorTypes", "TypeDrivePower_ElevatorDrivePowerId", "dbo.ElevatorDrivePowers");
            DropForeignKey("dbo.ElevatorTypes", "TypeController_ElevatorControllerId", "dbo.ElevatorControllers");
            DropForeignKey("dbo.ElevatorTypes", "TypeCapacity_ElevatorCapacityId", "dbo.ElevatorCapacities");
            DropIndex("dbo.ElevatorTypes", new[] { "TypeView_ElevatorViewId" });
            DropIndex("dbo.ElevatorTypes", new[] { "TypeProducer_ElevatorProducerId" });
            DropIndex("dbo.ElevatorTypes", new[] { "TypeDriveType_ElevatorDriveTypeId" });
            DropIndex("dbo.ElevatorTypes", new[] { "TypeDrivePower_ElevatorDrivePowerId" });
            DropIndex("dbo.ElevatorTypes", new[] { "TypeController_ElevatorControllerId" });
            DropIndex("dbo.ElevatorTypes", new[] { "TypeCapacity_ElevatorCapacityId" });
            DropTable("dbo.Metrics");
            DropTable("dbo.MechanicStatus");
            DropTable("dbo.MechanicAreas");
            DropTable("dbo.Materials");
            DropTable("dbo.LocationStreets");
            DropTable("dbo.LocationCities");
            DropTable("dbo.ElevatorViews");
            DropTable("dbo.ElevatorTypes");
            DropTable("dbo.ElevatorSuspensionTypes");
            DropTable("dbo.ElevatorProducers");
            DropTable("dbo.ElevatorNowStatus");
            DropTable("dbo.ElevatorDriveTypes");
            DropTable("dbo.ElevatorDrivePowers");
            DropTable("dbo.ElevatorControllers");
            DropTable("dbo.ElevatorCapacities");
            DropTable("dbo.ClientsBanks");
            DropTable("dbo.AdditionExpends");
        }
    }
}
