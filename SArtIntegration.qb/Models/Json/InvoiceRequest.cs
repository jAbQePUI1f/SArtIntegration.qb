using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SArtIntegration.qb.Models.Enums.InvoiceTypes;

namespace SArtIntegration.qb.Models.Json
{
    public class InvoiceRequest
    {
        public InvoiceRequest() { }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string[] invoiceTypes { get; set; }
    }
}
