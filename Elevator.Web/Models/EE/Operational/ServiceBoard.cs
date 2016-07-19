using Elevator.Web.Models.EE.Dictionary;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Elevator.Web.Models.EE.Operational
{
    public class ServiceBoard
    {
        public int ServiceBoardId { get; set; }
        public DateTime IncidentDate { get; set; }

        public int ElevatorsId { get; set; }

        [ForeignKey("ElevatorsId")]
        public virtual Elevators Elevator { get; set; }
    }
}