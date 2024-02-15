using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Models;
using System.ComponentModel;
using System.Reflection;
using System.Xml;

namespace SArtIntegration.qb.Manager.Stock
{
    public  class TransferStock
    {
      
        public static void LoadStock()
        {
            //var connectInfo = ConnectManager.ConnectToQB();

            string[] includeRetElements = typeof(ItemModels)
                                  .GetProperties()
                                  .Select(p => GetDisplayName(p))
                                  .ToArray();

            //string[] includeRetElements = { "ListID", "Name", "QuantityOnHand", "Description", "Price", "IsActive" };

            string response = ConnectManager.ProcessRequestFromQB(UserSharedInfo.GetConnectInfo(), BuildItemQueryRqXML(includeRetElements, null, UserSharedInfo.GetConnectInfo().MaxVersion));


            //DataTable itemDataTable = createItemDataTable();

            var result= ParseItemQueryRs(response);


            ConnectManager.DisconnectFromQB(UserSharedInfo.GetConnectInfo());
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

            XmlNodeList itemNodes = xmlDoc.SelectNodes("//ItemInventoryQueryRs/ItemInventoryRet");// //ItemInventoryQueryRs/ItemInventoryRet



            foreach (XmlNode itemNode in itemNodes)
            {
                ItemModels ıtem = new ItemModels();

                ıtem.stock = itemNode.SelectSingleNode("QuantityOnHand") != null ? Convert.ToDecimal(itemNode.SelectSingleNode("QuantityOnHand").InnerText) : 0.00m;
                ıtem.name = itemNode.SelectSingleNode("Name")?.InnerText ?? "";
                ıtem.fullyQualifiedName = itemNode.SelectSingleNode("FullName")?.InnerText ?? "";
                ıtem.id = itemNode.SelectSingleNode("ListID")?.InnerText ?? "";


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
