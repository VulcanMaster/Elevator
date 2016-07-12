using System.Data.Entity;
using Elevator.Web.Models.EE.Dictionary;

namespace Elevator.Web.Models
{
    public class AbSqlContext : DbContext
    {
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<AdditionExpend> AdditionExpend { get; set; }
        public virtual DbSet<ClientsBank> ClientsBank { get; set; }
        public virtual DbSet<ElevatorCapacity> ElevatorCapacity { get; set; }
        public virtual DbSet<ElevatorController> ElevatorController { get; set; }
        public virtual DbSet<ElevatorDrivePower> ElevatorDrivePower { get; set; }
        public virtual DbSet<ElevatorDriveType> ElevatorDriveType { get; set; }
        public virtual DbSet<ElevatorNowStatus> ElevatorNowStatus { get; set; }
        public virtual DbSet<ElevatorProducer> ElevatorProducer { get; set; }
        public virtual DbSet<ElevatorSuspensionType> ElevatorSuspensionType { get; set; }
        public virtual DbSet<ElevatorType> ElevatorType { get; set; }
        public virtual DbSet<ElevatorView> ElevatorView { get; set; }
        public virtual DbSet<LocationCity> LocationCity { get; set; }
        public virtual DbSet<LocationStreet> LocationStreet { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<MechanicArea> MechanicArea { get; set; }
        public virtual DbSet<MechanicStatus> MechanicStatus { get; set; }
        public virtual DbSet<Metric> Metric { get; set; }
    }
}