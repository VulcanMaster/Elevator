using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Elevator.Web.Models.SQLModel
{
    public class DBController : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }
}