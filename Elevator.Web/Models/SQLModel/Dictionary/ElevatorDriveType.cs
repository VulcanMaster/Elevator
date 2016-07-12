using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class ElevatorDriveType
    {
        //    тип привода
        //WWF
        //2 speed
        //hidroblock
        public int ElevatorDriveTypeID { get; set; }
        public string ElevatorDriveTypeName { get; set; }
    }
}