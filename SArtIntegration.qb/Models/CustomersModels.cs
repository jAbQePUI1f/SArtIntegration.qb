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
        public string Id { get; set; }

        [DisplayName("JobTitle")]
        public string Title { get; set; }

        [DisplayName("FullName")]
        public string DisplayName { get; set; }

        [DisplayName("CompanyName")]
        public string CompanyName { get; set; }

        public bool Taxable { get; set; }

        [DisplayName("BillAddress")]
        public Address Address { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        [DisplayName("Balance")]
        public decimal Balance { get; set; }

    }
    public class Address
    {
        public string AddLine1 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }
}
