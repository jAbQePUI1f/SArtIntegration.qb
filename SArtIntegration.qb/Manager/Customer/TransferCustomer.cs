using SArtIntegration.qb.Manager.Api;
using SArtIntegration.qb.Manager.Config;
using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Models;
using SArtIntegration.qb.Models.Json;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Xml;
using static SArtIntegration.qb.Models.Json.CustomerRequest;

namespace SArtIntegration.qb.Manager.Customer
{
    public class TransferCustomer
    {
        public static async void LoadCustomer()
        {
            #region -- let me check 2
            //var connectDbResult = ConnectManager.ConnectToQB();

            //CustomersModels customers = new();

            //var customer1 = new CustomerRequest
            //{
            //    importCustomerFromQuickbooks = new[]
            //    {
            //        new CustomerModelJson {
            //           id="1001",
            //        title = "Ms.1",
            //    displayName = "Jane Smith1",
            //    companyName = "XYZ Corp.1",
            //    taxable = false,
            //    addLine1 = "456 Elm St1",
            //    city = "Othertown1",
            //    country = "USA1",
            //    postalCode = "34500",
            //    balance = Convert.ToDecimal("5.5"),
            //         }
            //    }

            //};

            //var response2 =await  ApiManager.PostAsync<CustomerRequest, CustomerResponse>(Configuration.GetUrl() + "management/quick-books/customers?lang=tr", customer1);
            #endregion

            string[] includeRetElements = typeof(CustomersModels)
                                     .GetProperties()
                                     .Select(p => GetDisplayName(p))
                                     .ToArray();

            string response = ConnectManager.ProcessRequestFromQB(UserSharedInfo.GetConnectInfo(), 
                BuildCustomerQueryRqXML(includeRetElements, null, UserSharedInfo.GetConnectInfo().MaxVersion));

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
                    #region -- Customer Location Info
                    //latitude = item.latitude,
                    //longitude = item.longitude,
                    #endregion
                    companyName = item.companyName,
                    displayName = item.displayName,
                    id = item.id,
                    taxable = item.taxable,
                    title = item.title
                };
                customerList.Add(customerModel);

            }

            CustomerRequest customerRequest = new CustomerRequest();
            customerRequest.importCustomerFromQuickbooks = customerList.ToArray();
            var response1 =await ApiManager.PostAsync<CustomerRequest, CustomerResponse>(Configuration.GetUrl() + "management/quick-books/customers?lang=tr", customerRequest);

            //string jsonResult = JsonConvert.SerializeObject(result, Newtonsoft.Json.Formatting.Indented);
            if (response1.responseStatus == 200)
            {
                MessageBox.Show("Customers add Succesfully");

            }
            //ConnectManager.DisconnectFromQB(UserSharedInfo.GetConnectInfo());
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
