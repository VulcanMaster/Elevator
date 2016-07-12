using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Elevator.Web.Models.SQLModel.Dictionary;

namespace Elevator.Web.Models.SQLModel
{
    public class Mechanic
        //      Имя 
        //Тел.Рабочий
        //Тел.Приватный
        //п.код Район	
        //№ договора (дата заключения договора +№)
        //Доступ эл безопасности до(дата)
        //Доступ опасн.оборудования до (дата)
        //статус(id статуса)
        //jpg link
        
    {
        public int MechanicId { get; set; }
        public string MechanicName { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string PersCode { get; set; }
        public string MechanicContractNum { get; set; }
        public DateTime ElectricityAccessExpiryDate { get; set; }
        public DateTime ElevatorAccessExpiryDate { get; set; }
        public MechanicStatus Status { get; set; }
        public MechanicArea Area { get; set; }
        public string PhotoLink { get; set; }
    }
}