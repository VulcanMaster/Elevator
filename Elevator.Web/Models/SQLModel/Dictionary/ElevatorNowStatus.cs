using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public  class ElevatorNowStatus
    {
       //       тек.состояние лифта
        //Эксплуатируется
        //Выключен
        //Ремонт
        //Необходимо уточнить
       public int ElevatorNowStatusID { get; set; }
       public string ElevatorNowStatusName { get; set; }
    }

    //public enum StatusList
    //{
    //  AtWork = 1,
    //    Vacation = 2
    //}
}