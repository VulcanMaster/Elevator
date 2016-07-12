using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Elevator.Web.Models.SQLModel.Dictionary;

namespace Elevator.Web.Models.SQLModel
{
    public class ElevatorType
    {
        //      название Типa
        //Вид ----------elevator View*
        //Производитель ----------elevator producer*
        //Подвеска  -------- elevator suspension*
        //тип привода ---drive type*
        //мощность привода -drive power*
        //Станция -controller*
        //Грузоподъемность - elevator capacity*
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public ElevatorView TypeView { get; set; }
        public ElevatorProducer TypeProducer { get; set; }
        public ElevatorDriveType TypeDriveType { get; set; }
        public ElevatorDrivePower TypeDrivePower { get; set; }
        public ElevatorController TypeController { get; set; }
        public ElevatorCapacity TypeCapacity { get; set; }
      }
}