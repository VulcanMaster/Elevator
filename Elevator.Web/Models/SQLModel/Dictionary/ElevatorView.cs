using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class ElevatorView
    {
        //      Вид оборудования
        //Лифт
        //Подъёмник
        //Элеватор
        //Эскалатор
        //Платформа
        //Люлька
        public int ElevatorViewID { get; set; }
        public string ElevatorViewName { get; set; }
    }
}