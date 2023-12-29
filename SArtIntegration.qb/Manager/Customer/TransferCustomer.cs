using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Interop.QBXMLRP2;
using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Models;

namespace SArtIntegration.qb.Manager.Customer
{
    public class TransferCustomer
    {
        private readonly ConnectManager _connect;
        private readonly TransferHelper _helper;
        public TransferCustomer()
        {
            _connect = new ConnectManager();
            _helper = new TransferHelper();
        }
        public void LoadCustomer()
        {
            var connectDbResult = _connect.connectToQB();
            CustomersModels customers = new CustomersModels();

           

            string[] includeRetElements = typeof(CustomersModels)
                                     .GetProperties()
                                     .Select(p => GetDisplayName(p))
                                     .ToArray();


            string response =_connect.processRequestFromQB(connectDbResult,buildCustomerQueryRqXML(includeRetElements, null, connectDbResult.maxVersion));

            var result = parseCustomerQueryRs(response);

        }
        private string buildCustomerQueryRqXML(string[] includeRetElement, string fullName, string maxVersion)
        {
            string xml = "";
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement qbXMLMsgsRq = _helper.buildRqEnvelope(xmlDoc, maxVersion);
            qbXMLMsgsRq.SetAttribute("onError", "stopOnError");
            XmlElement CustomerQueryRq = xmlDoc.CreateElement("CustomerQueryRq");
            qbXMLMsgsRq.AppendChild(CustomerQueryRq);
            if (fullName != null)
            {
                CustomerQueryRq.AppendChild(_helper.MakeSimpleElem(xmlDoc, "FullName", fullName));

                //XmlElement fullNameElement = xmlDoc.CreateElement("FullName");
                //CustomerQueryRq.AppendChild(fullNameElement).InnerText = fullName;
            }
            for (int x = 0; x < includeRetElement.Length; x++)
            {
                CustomerQueryRq.AppendChild(_helper.MakeSimpleElem(xmlDoc, "IncludeRetElement", includeRetElement[x]));
                //XmlElement includeRet = xmlDoc.CreateElement("IncludeRetElement");
                //CustomerQueryRq.AppendChild(includeRet).InnerText = includeRetElement[x];
            }
            CustomerQueryRq.SetAttribute("requestID", "1");
            xml = xmlDoc.OuterXml;
            return xml;
        }

        private List<CustomersModels> parseCustomerQueryRs(string response)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response);
            List<CustomersModels> customersModels = new List<CustomersModels>();
            XmlNodeList customerNodes = xmlDoc.SelectNodes("//CustomerRet");
            foreach (XmlNode customerNode in customerNodes)
            {
                CustomersModels customers = new CustomersModels();

                customers.id = customerNode.SelectSingleNode("ListID")?.InnerText ?? "";
                customers.displayName = customerNode.SelectSingleNode("FullName")?.InnerText ?? "";
                customers.companyName = customerNode.SelectSingleNode("CompanyName")?.InnerText ?? "";

                XmlNode billAddressNode = customerNode.SelectSingleNode("BillAddress");

                customers.address = new Address
                {
                    addLine1 = billAddressNode.SelectSingleNode("Addr1")?.InnerText ?? "" + " " + billAddressNode.SelectSingleNode("Addr2")?.InnerText ?? "",
                    city = billAddressNode.SelectSingleNode("City")?.InnerText ?? "",
                    country = billAddressNode.SelectSingleNode("Country")?.InnerText ?? "",
                    postalCode = billAddressNode.SelectSingleNode("PostalCode")?.InnerText ?? "",
                };

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
