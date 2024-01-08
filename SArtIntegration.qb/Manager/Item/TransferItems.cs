using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Models;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Xml;

namespace SArtIntegration.qb.Manager.Item
{
    public class TransferItems
    {



        public static void LoadItems()
        {

            var connectInfo = ConnectManager.ConnectToQB();

            string[] includeRetElements = typeof(ItemModels)
                                  .GetProperties()
                                  .Select(p => GetDisplayName(p))
                                  .ToArray();

            //string[] includeRetElements = { "ListID", "Name", "QuantityOnHand", "Description", "Price", "IsActive" };

            string response = ConnectManager.ProcessRequestFromQB(connectInfo, BuildItemQueryRqXML(includeRetElements, null, connectInfo.MaxVersion));



            var result = ParseItemQueryRs(response);


            ConnectManager.DisconnectFromQB(connectInfo);


        }
        private static string BuildItemQueryRqXML(string[] includeRetElement, string itemName, string maxVersion)
        {
            string xml = "";
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement qbXMLMsgsRq = TransferHelper.BuildRqEnvelope(xmlDoc, maxVersion);
            qbXMLMsgsRq.SetAttribute("onError", "stopOnError");
            XmlElement ItemQueryRq = xmlDoc.CreateElement("ItemQueryRq");//ItemQueryRq ItemInventoryQueryRq
            qbXMLMsgsRq.AppendChild(ItemQueryRq);

            if (itemName != null)
            {
                ItemQueryRq.AppendChild(TransferHelper.MakeSimpleElem(xmlDoc, "FullName", itemName));
            }

            for (int x = 0; x < includeRetElement.Length; x++)
            {
                ItemQueryRq.AppendChild(TransferHelper.MakeSimpleElem(xmlDoc, "IncludeRetElement", includeRetElement[x]));
            }

            ItemQueryRq.SetAttribute("requestID", "1");
            xml = xmlDoc.OuterXml;
            return xml;
        }

        private static List<ItemModels> ParseItemQueryRs(string response)
        {
            List<ItemModels> models = new List<ItemModels>();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response);

            XmlNodeList itemNodes = xmlDoc.SelectNodes("//ItemQueryRs/*[self::ItemInventoryRet or self::ItemServiceRet]");////ItemInventoryQueryRs/ItemInventoryRet



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
