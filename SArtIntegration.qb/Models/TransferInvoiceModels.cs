using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Models
{
    public  class TransferInvoiceModels
    {
        public required string CustomerName { get; set; }
        public required string TxnDate { get; set; }
        public required string InvoiceNumber { get; set; }
        public required string BillAddr { get; set; }
        public required string TermsName { get; set; }
        public string? DueDate { get; set; }
        public required List<InvoiceLineModels> LineModels { get; set; }
    }
    public class InvoiceLineModels
    {
        public required string ItemName { get; set; }
        public required string ItemDesc { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class ResponseInvoiceModels
    {
        public string  TxnId  { get; set; }
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string StatusSeverity { get; set; }
    }
}
