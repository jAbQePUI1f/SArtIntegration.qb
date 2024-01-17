using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Models.Json
{
    public class InvoiceSyncRequest
    {
        public IntegratedInvoice[] IntegratedInvoices { get; set; }
        public class IntegratedInvoice
        {
            public bool SuccessfullyIntegrated { get; set; }
            public string InvoiceNumber { get; set; }
            public string RemoteInvoiceNumber { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
        
}
