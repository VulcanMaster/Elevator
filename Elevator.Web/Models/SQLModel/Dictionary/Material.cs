using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel.Dictionary
{
    public class Material
    {
        public int MaterialId { get; set; }
        public string MaterialName { get; set; }
        public decimal MaterialBasePrice { get; set; }
    }
}