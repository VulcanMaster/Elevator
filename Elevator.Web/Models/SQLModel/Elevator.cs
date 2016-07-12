using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Elevator.Web.Models.SQLModel.Dictionary;

namespace Elevator.Web.Models.SQLModel
{
    public class Elevator
        //  LIFT
        //Рег. № Лифта
        //год производства
        //Тип*
        //Механик* 
        //Клиент*  
        //Адрес*
        //Кол.Этажей
        //kol dverej kabiny
        //годовое ТО expDate
        //тек.состояние*
    {
        public int ElevatorId { get; set; }
        public string RegNum { get; set; }
        public DateTime ManufactureDate { get; set; }
        public ElevatorType TypeShortName { get; set; }
        public Mechanic ElevatorStuff { get; set; }
        public Client ElevatorOwner { get; set; }
        public Location ElevatorLocation { get; set; }
        public int StopsCount { get; set; }
        public int EntrancesCount { get; set; }
        public DateTime ExpireDate { get; set; }
        public ElevatorNowStatus NowStatus { get; set; }
    }
}