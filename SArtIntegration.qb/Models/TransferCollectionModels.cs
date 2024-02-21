namespace SArtIntegration.qb.Models
{
    public  class TransferCollectionModels
    {
        public required string CustomerName { get; set; }
        public required string TxnDate { get; set; }
        public required string Number { get; set; }
        public decimal TotalAmount { get; set; }
        public string? PaymentMethodName { get; set; }
        public string? AppliedTxnID { get; set; }
        public decimal AppliedPaymentAmount { get; set; }
    }
    public class ResponseCollectionModels
    {
        public string TxnId { get; set; }
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string StatusSeverity { get; set; }
    }
}
