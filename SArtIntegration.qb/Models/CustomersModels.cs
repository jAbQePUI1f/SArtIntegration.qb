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
        public Address address { get; set; }

        public string latitude { get; set; }

        public string longitude { get; set; }

        [DisplayName("Balance")]
        public decimal balance { get; set; }

    }
    public class Address
    {
        public string addLine1 { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
    }
}
