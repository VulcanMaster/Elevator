using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class ElevatorSuspensionType
    {
        //    Подвеска
        //Нет
        //Прямая
        //Полиспас 1/2
        //Полиспас выжимной  1/2
        //Полиспас 1/4
        //Полиспас выжимной  1/2
        public int ElevatorSuspensionTypeID { get; set; }
        public string ElevatorSuspensionTypeName { get; set; }
    }
}