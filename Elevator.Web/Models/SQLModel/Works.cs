using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Elevator.Web.Models.SQLModel.Dictionary;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class Works
    {
        public int WorkId { get; set; }
        public string WorkName { get; set; }
        public Metric WorkMetric { get; set; }
        public decimal WorkPricePerMetric { get; set; }
    }
}