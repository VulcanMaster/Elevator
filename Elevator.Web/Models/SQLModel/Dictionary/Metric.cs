using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class Metric
    {
        public int MetricId { get; set; }
        public string MetricFullName { get; set; }
        public string MetricShortName { get; set; }
    }
}