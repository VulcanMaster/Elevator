using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel
{
    public class Person
    {
        public int PersonId { get; set; }
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