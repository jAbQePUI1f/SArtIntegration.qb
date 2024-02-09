using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Interop.QBXMLRP2;
using Newtonsoft.Json;
using SArtIntegration.qb.Manager.Api;
using SArtIntegration.qb.Manager.Config;
using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Models;
using SArtIntegration.qb.Models.Json;
using static SArtIntegration.qb.Models.Json.CustomerRequest;

namespace SArtIntegration.qb.Manager.Customer
{
    public class TransferCustomer
    {

        public static void LoadCustomer()
        {
            //var connectDbResult = ConnectManager.ConnectToQB();

            //CustomersModels customers = new();

            //var customer1 = new CustomerRequest
            //{
            //    importCustomerFromQuickbooks = new[]
            //    {
            //        new CustomerModelJson {
            //           id=10,
            //        title = "Ms.1",
            //    displayName = "Jane Smith1",
            //    companyName = "XYZ Corp.1",
            //    taxable = false,
            //    addLine1 = "456 Elm St1",
            //    city = "Othertown1",
            //    country = "USA1",
            //    postalCode = "34500",
            //    latitude = "",
            //    longitude = "",
            //    balance = Convert.ToDecimal("5.5"),
            //         }
            //    }

            //};



            //var response1 = ApiManager.SendRequestAsync<CustomerRequest, CustomerResponse>(customer1, Configuration.GetUrl() + "management/quick-books/customers?lang=tr");



            string[] includeRetElements = typeof(CustomersModels)
                                     .GetProperties()
                                     .Select(p => GetDisplayName(p))
                                     .ToArray();


            string response = ConnectManager.ProcessRequestFromQB(UserSharedInfo.GetConnectInfo(), BuildCustomerQueryRqXML(includeRetElements, null, UserSharedInfo.GetConnectInfo().MaxVersion));

            var result = ParseCustomerQueryRs(response);
            List<CustomerModelJson> customerList = new List<CustomerModelJson>();


            foreach (var item in result)
            {
                CustomerModelJson customerModel = new CustomerModelJson()
                {
                    addLine1 = item.addLine1,
                    balance = item.balance,
                    city = item.city,
                    country = item.country,
                    postalCode = item.postalCode,
                    latitude = item.latitude,
                    longitude = item.longitude,
                    companyName = item.companyName,
                    displayName = item.displayName,
                    id = (long)Convert.ToDouble(item.id),
                    taxable = item.taxable,
                    title = item.title
                };
                customerList.Add(customerModel);

            }

            CustomerRequest customerRequest = new CustomerRequest();
            customerRequest.importCustomerFromQuickbooks = customerList.ToArray();

            var response1 = ApiManager.SendRequestAsync<CustomerRequest, CustomerResponse>(customerRequest, Configuration.GetUrl() + "management/quick-books/customers?lang=tr");

            //string jsonResult = JsonConvert.SerializeObject(result, Newtonsoft.Json.Formatting.Indented);
            if (response1.Result.responseStatus == 200)
            {
                MessageBox.Show("Customers add Succesfully");

            }

            ConnectManager.DisconnectFromQB(UserSharedInfo.GetConnectInfo());

        }
        private static string BuildCustomerQueryRqXML(string[] includeRetElement, string fullName, string maxVersion)
        {
            XmlDocument xmlDoc = new();
            XmlElement qbXMLMsgsRq = TransferHelper.BuildRqEnvelope(xmlDoc, maxVersion);
            qbXMLMsgsRq.SetAttribute("onError", "stopOnError");
            XmlElement CustomerQueryRq = xmlDoc.CreateElement("CustomerQueryRq");
            qbXMLMsgsRq.AppendChild(CustomerQueryRq);
            if (fullName != null)
            {
                CustomerQueryRq.AppendChild(TransferHelper.MakeSimpleElem(xmlDoc, "FullName", fullName));

            }
            for (int x = 0; x < includeRetElement.Length; x++)
            {
                CustomerQueryRq.AppendChild(TransferHelper.MakeSimpleElem(xmlDoc, "IncludeRetElement", includeRetElement[x]));

            }
            CustomerQueryRq.SetAttribute("requestID", "1");
            string xml = xmlDoc.OuterXml;
            return xml;
        }

        private static List<CustomersModels> ParseCustomerQueryRs(string response)
        {
            XmlDocument xmlDoc = new();
            xmlDoc.LoadXml(response);
            List<CustomersModels> customersModels = new List<CustomersModels>();
            XmlNodeList customerNodes = xmlDoc.SelectNodes("//CustomerRet");
            foreach (XmlNode customerNode in customerNodes)
            {
                CustomersModels customers = new()
                {
                    id = customerNode.SelectSingleNode("ListID")?.InnerText ?? "",
                    displayName = customerNode.SelectSingleNode("FullName")?.InnerText ?? "",
                    companyName = customerNode.SelectSingleNode("CompanyName")?.InnerText ?? ""
                };

                XmlNode billAddressNode = customerNode.SelectSingleNode("BillAddress");

                customers.addLine1 = billAddressNode.SelectSingleNode("Addr1")?.InnerText ?? "" + " " + billAddressNode.SelectSingleNode("Addr2")?.InnerText ?? "";
                customers.city = billAddressNode.SelectSingleNode("City")?.InnerText ?? "";
                customers.country = billAddressNode.SelectSingleNode("Country")?.InnerText ?? "";
                customers.postalCode = billAddressNode.SelectSingleNode("PostalCode")?.InnerText ?? "";



                customers.balance = customerNode.SelectSingleNode("Balance") != null ? Convert.ToDecimal(customerNode.SelectSingleNode("Balance").InnerText) : 0.00m;

                customers.title = customerNode.SelectSingleNode("JobTitle")?.InnerText ?? "";
                customers.latitude = "";
                customers.longitude = "";
                customers.taxable = false;

                customersModels.Add(customers);
            }
            return customersModels;
        }

        #region Helper
        static string GetDisplayName(PropertyInfo property)
        {
            var displayNameAttribute = property.GetCustomAttribute<DisplayNameAttribute>();
            return displayNameAttribute != null ? displayNameAttribute.DisplayName : property.Name;
        }
        #endregion

    }
}
