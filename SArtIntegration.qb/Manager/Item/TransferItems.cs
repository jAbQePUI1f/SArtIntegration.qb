using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SArtIntegration.qb.Manager.Item
{
    public class TransferItems
    {
        private readonly ConnectManager _connect;
        private readonly TransferHelper _helper;
        public TransferItems()
        {
            _helper = new TransferHelper();
            _connect = new ConnectManager();
        }

        public void loadItems()
        {
            string request = "ItemQueryRq";
            var connectInfo = _connect.connectToQB();

            string[] includeRetElements = typeof(ItemModels)
                                  .GetProperties()
                                  .Select(p => GetDisplayName(p))
                                  .ToArray();

            //string[] includeRetElements = { "ListID", "Name", "QuantityOnHand", "Description", "Price", "IsActive" };

            string response = _connect.processRequestFromQB(connectInfo, buildItemQueryRqXML(includeRetElements, null, connectInfo.maxVersion));


            //DataTable itemDataTable = createItemDataTable();

            parseItemQueryRs(response);


            _connect.disconnectFromQB(connectInfo);


        }
        private string buildItemQueryRqXML(string[] includeRetElement, string itemName, string maxVersion)
        {
            string xml = "";
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement qbXMLMsgsRq = _helper.buildRqEnvelope(xmlDoc, maxVersion);
            qbXMLMsgsRq.SetAttribute("onError", "stopOnError");
            XmlElement ItemQueryRq = xmlDoc.CreateElement("ItemInventoryQueryRq");
            qbXMLMsgsRq.AppendChild(ItemQueryRq);

            if (itemName != null)
            {
                ItemQueryRq.AppendChild(_helper.MakeSimpleElem(xmlDoc, "FullName", itemName));
            }

            for (int x = 0; x < includeRetElement.Length; x++)
            {
                ItemQueryRq.AppendChild(_helper.MakeSimpleElem(xmlDoc, "IncludeRetElement", includeRetElement[x]));
            }

            ItemQueryRq.SetAttribute("requestID", "1");
            xml = xmlDoc.OuterXml;
            return xml;
        }

        private List<ItemModels> parseItemQueryRs(string response)
        {
            List<ItemModels> models = new List<ItemModels>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response);

            XmlNodeList itemNodes = xmlDoc.SelectNodes("//ItemInventoryQueryRs/ItemInventoryRet");

            foreach (XmlNode itemNode in itemNodes)
            {
                ItemModels ıtem = new ItemModels();

                ıtem.description = itemNode.SelectSingleNode("SalesDesc")?.InnerText ?? "";
                ıtem.purchaseCost = itemNode.SelectSingleNode("PurchaseCost") != null ? Convert.ToDecimal(itemNode.SelectSingleNode("PurchaseCost").InnerText) : 0.00m;
                ıtem.taxable = false;
                ıtem.stock = itemNode.SelectSingleNode("QuantityOnHand") != null ? Convert.ToDecimal(itemNode.SelectSingleNode("QuantityOnHand").InnerText) : 0.00m;
                ıtem.name = itemNode.SelectSingleNode("Name")?.InnerText ?? "";
                ıtem.active = Convert.ToBoolean(itemNode.SelectSingleNode("IsActive").InnerText);
                ıtem.fullyQualifiedName = itemNode.SelectSingleNode("FullName")?.InnerText ?? "";
                ıtem.id = itemNode.SelectSingleNode("ListID")?.InnerText ?? "";
                ıtem.unitPrice = itemNode.SelectSingleNode("SalesPrice") != null ? Convert.ToDecimal(itemNode.SelectSingleNode("SalesPrice").InnerText) : 0.00m;
                ıtem.type = "";

                models.Add(ıtem);
            }

            return models;
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
