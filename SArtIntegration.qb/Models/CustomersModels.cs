using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SArtIntegration.qb.Models
{
    public class CustomersModels
    {
        [DisplayName("ListID")]
        public string id { get; set; }

        [DisplayName("JobTitle")]
        public string title { get; set; }

        [DisplayName("FullName")]
        public string displayName { get; set; }

        [DisplayName("CompanyName")]
        public string companyName { get; set; }

        public bool taxable { get; set; }

        [DisplayName("BillAddress")]
        public Address Address { get; set; }
        [DisplayName("Addr1")]
        public string addLine1 { get; set; }
        [DisplayName("City")]
        public string city { get; set; }
        [DisplayName("Country")]
        public string country { get; set; }
        [DisplayName("PostalCode")]
        public string postalCode { get; set; }
        public string latitude { get; set; }

        public string longitude { get; set; }

        [DisplayName("Balance")]
        public decimal balance { get; set; }

    }
    public class Address
    {
        public string AddLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
