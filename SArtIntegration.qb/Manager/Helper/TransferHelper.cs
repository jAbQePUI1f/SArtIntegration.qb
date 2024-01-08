using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SArtIntegration.qb.Manager.Helper
{
    public class TransferHelper
    {
        //public virtual string buildDataCountQuery(string request)
        //{
        //    string input = "";
        //    XmlDocument inputXMLDoc = new XmlDocument();
        //    XmlElement qbXMLMsgsRq = buildRqEnvelope(inputXMLDoc, maxVersion);
        //    XmlElement queryRq = inputXMLDoc.CreateElement(request);
        //    queryRq.SetAttribute("metaData", "MetaDataOnly");
        //    qbXMLMsgsRq.AppendChild(queryRq);
        //    input = inputXMLDoc.OuterXml;
        //    return input;
        //}
        public static XmlElement BuildRqEnvelope(XmlDocument doc, string maxVer)
        {
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", null, null));
            doc.AppendChild(doc.CreateProcessingInstruction("qbxml", "version=\"" + maxVer + "\""));
            XmlElement qbXML = doc.CreateElement("QBXML");
            doc.AppendChild(qbXML);
            XmlElement qbXMLMsgsRq = doc.CreateElement("QBXMLMsgsRq");
            qbXML.AppendChild(qbXMLMsgsRq);
            qbXMLMsgsRq.SetAttribute("onError", "stopOnError");
            return qbXMLMsgsRq;
        }
        public static XmlElement MakeSimpleElem(XmlDocument doc, string tagName, string tagVal)
        {
            XmlElement elem = doc.CreateElement(tagName);
            elem.InnerText = tagVal;
            return elem;
        }
        public static string GetAddress(XmlNode addressNode)
        {
            if (addressNode != null)
            {
                string addr1 = addressNode.SelectSingleNode("Addr1")?.InnerText ?? "";
                string addr2 = addressNode.SelectSingleNode("Addr2")?.InnerText ?? "";
                string city = addressNode.SelectSingleNode("City")?.InnerText ?? "";
                string state = addressNode.SelectSingleNode("State")?.InnerText ?? "";
                string postalCode = addressNode.SelectSingleNode("PostalCode")?.InnerText ?? "";
                string country = addressNode.SelectSingleNode("Country")?.InnerText ?? "";

                // Adres bilgisini kullanarak bir dize oluştur
                return $"{addr1} {addr2} {city} {state} {postalCode} {country}";
            }
            return "";
        }

        public static string[] ConvertToStringArray<T>(T obj)
        {
            List<string> stringArray = new List<string>();

            if (obj != null)
            {
                PropertyInfo[] properties = typeof(T).GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    object value = property.GetValue(obj, null);
                    string stringValue = (value != null) ? value.ToString() : "null";

                    stringArray.Add($"{property.Name}: {stringValue}");
                }
            }

            return stringArray.ToArray();
        }

       
       
    }
}
