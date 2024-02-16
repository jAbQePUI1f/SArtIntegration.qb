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
using static SArtIntegration.qb.Models.Json.ProductRequest;

namespace SArtIntegration.qb.Manager.Item
{
    public class TransferItems
    {



        public static async void LoadItems()
        {

            //var customer1 = new ProductRequest
            //{
            //    importProductFromQuickbooks = new[]
            //   {
            //        new ProductModelJson {
            //           id="11111",
            //         name = "New",
            //     description = "new new ",
            //     fullyQualifiedName = "new2",
            //    taxable = false,
            //     active = true,
            //     type = "Inventory",
            //     purchaseCost =Convert.ToDecimal("5.5"),
            //     unitPrice = Convert.ToDecimal("10.5"),
            //     stock=Convert.ToDecimal("10"),
            //         }
            //    }

            //};



            //var response2 =await ApiManager.PostAsync<ProductRequest, ProductResponse>(Configuration.GetUrl() + "management/quick-books/products?lang=tr", customer1);



            //var connectInfo = ConnectManager.ConnectToQB();

            string[] includeRetElements = typeof(ItemModels)
                                  .GetProperties()
                                  .Select(p => GetDisplayName(p))
                                  .ToArray();

            //string[] includeRetElements = { "ListID", "Name", "QuantityOnHand", "Description", "Price", "IsActive" };

            string response = ConnectManager.ProcessRequestFromQB(UserSharedInfo.GetConnectInfo(), BuildItemQueryRqXML(includeRetElements, null, UserSharedInfo.GetConnectInfo().MaxVersion));



            var result = ParseItemQueryRs(response);


            List<ProductModelJson> productList = new List<ProductModelJson>();


            foreach (var item in result)
            {
                ProductModelJson productModel = new ProductModelJson()
                {
                    active = true,
                    description = item.description,
                    fullyQualifiedName = item.fullyQualifiedName,
                    type = item.type,
                    id = item.id,
                    name = item.name,
                    purchaseCost = item.purchaseCost,
                    stock = item.stock,
                    taxable = item.taxable,
                    unitPrice = item.unitPrice
                };
                productList.Add(productModel);

            }

            ProductRequest productRequest = new ProductRequest();
            productRequest.importProductFromQuickbooks = productList.ToArray();

            var response1 = await ApiManager.PostAsync<ProductRequest, ProductResponse>(Configuration.GetUrl() + "management/quick-books/products?lang=tr",productRequest);

            //string jsonResult = JsonConvert.SerializeObject(result, Newtonsoft.Json.Formatting.Indented);
            if (response1.responseStatus == 200)
            {
                MessageBox.Show("Products add Succesfully");

            }


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
