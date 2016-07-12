using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Elevator.Web.Models.SQLModel.Dictionary;

namespace Elevator.Web.Models.SQLModel
{
    public class Invoice
    {
        public int InvoiceRecordID { get; set; }
        public string InvoiceNum { get; set; }
        public DateTime InvoiceDate { get; set; }
        public Client InvoiceClient { get; set; }
        public Location InvoiceSubjectLocation { get; set; }
        

    }
}