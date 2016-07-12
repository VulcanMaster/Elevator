using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class ElevatorDrivePower
    {
        //    мощность привода
        //0-1 kW
        //1-3 kW
        //3-5 kW
        //5-10 kW
        public int ElevatorDrivePowerID { get; set; }
        public string ElevatorDrivePowerValue { get; set; }
    }
}