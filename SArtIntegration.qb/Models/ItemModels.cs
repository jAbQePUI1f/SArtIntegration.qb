using System.ComponentModel;

namespace SArtIntegration.qb.Models
{
    internal class ItemModels
    {
        [DisplayName("ListID")]
        public string id { get; set; }

        [DisplayName("Name")]
        public string  name { get; set; }

        [DisplayName("FullName")]
        public string fullyQualifiedName { get; set; }

        [DisplayName("SalesDesc")]
        public string description { get; set; }

        [DisplayName("PurchaseCost")]
        public decimal purchaseCost { get; set; }

        [DisplayName("SalesPrice")]
        public decimal unitPrice { get; set; }
        public bool taxable { get; set; }
        public string type { get; set; }

        [DisplayName("IsActive")]
        public bool active { get; set; }

        [DisplayName("QuantityOnHand")]
        public decimal stock { get; set; }
    }
}
