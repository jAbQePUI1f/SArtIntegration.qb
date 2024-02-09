using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SArtIntegration.qb.Models.Json.CustomerRequest;

namespace SArtIntegration.qb.Models.Json
{
    public class ProductRequest
    {
        public ProductModelJson[] importProductFromQuickbooks { get; set; }
        public class ProductModelJson
        {

            public long id { get; set; }
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
