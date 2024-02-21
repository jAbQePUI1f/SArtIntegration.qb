namespace SArtIntegration.qb.Models.Json
{
    public  class CustomerRequest
    {
        public CustomerModelJson[] importCustomerFromQuickbooks { get; set; }
        public class CustomerModelJson
        {
            public string id { get; set; }
            public string title { get; set; }
            public string displayName { get; set; }
            public string companyName { get; set; }
            public bool taxable { get; set; }
            public string addLine1 { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public string postalCode { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public decimal balance { get; set; }
        }
    }
}
