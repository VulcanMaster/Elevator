using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class MechanicStatus
    {
        //      статус механика
        //Дежурный
        //Штатный
        //Выходной
        //Отпуск
        public int MechanicStatusID { get; set; }
        public string MechanicStatusName { get; set; }
    }
}