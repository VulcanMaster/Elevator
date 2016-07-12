using System;

namespace Elevator.Web.Models.EE.Dictionary
{
    public class People
    {
        public int PeopleId { get; set; }
        public string FullName { get; set; }
        public string Area { get; set; }
        public string PersCode { get; set; }
        public string ContractNum { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public DateTime ElectricityAccessExpiryDate { get; set; }
        public DateTime ElevatorAccessExpiryDate { get; set; }
        public string Status { get; set; }
    }
}