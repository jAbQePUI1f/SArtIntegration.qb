namespace SArtIntegration.qb.Models.Json
{
    public class ProductRequest
    {
        public ProductModelJson[] importProductFromQuickbooks { get; set; }
        public class ProductModelJson
        {
            public string id { get; set; }
            public string name { get; set; }
            public string fullyQualifiedName { get; set; }
            public string description { get; set; }
            public decimal purchaseCost { get; set; }
            public decimal unitPrice { get; set; }
            public bool taxable { get; set; }
            public string type { get; set; }
            public bool active { get; set; }
            public decimal stock { get; set; }
        }
    }
}
