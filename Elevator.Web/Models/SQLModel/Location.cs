using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Elevator.Web.Models.SQLModel.Dictionary;

namespace Elevator.Web.Models.SQLModel
{
    public class Location
    //    mestopolozenie
    //короткое название
    //Город*
    //Улица*   
    //№ Дома	
    //№ подъезда	
    //№ лифта(local) 
    //Код от подъезда 
    //контакт на месте
    
    {
        public int LocationId { get; set; }
        public string LocationShortName { get; set; }
        public LocationCity City { get; set; }
        public LocationStreet Street { get; set; }
        public string HomeNum { get; set; }
        public int HomeEntrance { get; set; }
        public string ElevatorLocalNum { get; set; }
        public string LocalCode { get; set; }
        public string LocalContact { get; set; }
    }
}