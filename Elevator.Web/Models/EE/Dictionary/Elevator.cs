using Elevator.Web.Models.EE.Operational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.EE.Dictionary
{
    public class Elevators
    {
        public int ElevatorsId { get; set; }
        public string Name { get; set; }

        public Elevators()
        {
            ServiceBoardList = new List<ServiceBoard>();
        }

        public virtual ICollection<ServiceBoard> ServiceBoardList { get; set; }
    }
}