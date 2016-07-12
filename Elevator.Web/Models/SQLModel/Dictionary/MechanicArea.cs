using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class MechanicArea
    {
        //    Район приписки механника
        //Riga
        //Riga Galezers
        //Riga TV Tower
        //Jelgava
        //Liepaja
        public int MechanicAreaID { get; set; }
        public string MechanicAreaName { get; set; }
    }
}