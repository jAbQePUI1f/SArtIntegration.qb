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
