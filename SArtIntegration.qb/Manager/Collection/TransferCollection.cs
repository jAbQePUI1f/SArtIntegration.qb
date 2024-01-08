using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SArtIntegration.qb.Manager.Collection
{
    public class TransferCollection
    {
        public static ResponseCollectionModels BuildCollectionAddRqXML(TransferCollectionModels  collectionModels)
        {

            // Ödeme eklemek için QBXML belgesi oluştur
            XmlDocument inputXMLDoc = new XmlDocument();
            inputXMLDoc.AppendChild(inputXMLDoc.CreateXmlDeclaration("1.0", "UTF-8", null));
            inputXMLDoc.AppendChild(inputXMLDoc.CreateProcessingInstruction("qbxml", "version=\"16.0\""));

            XmlElement qbXML = inputXMLDoc.CreateElement("QBXML");
            inputXMLDoc.AppendChild(qbXML);

            XmlElement qbXMLMsgsRq = inputXMLDoc.CreateElement("QBXMLMsgsRq");
            qbXML.AppendChild(qbXMLMsgsRq);
            qbXMLMsgsRq.SetAttribute("onError", "stopOnError");

            XmlElement receivePaymentAddRq = inputXMLDoc.CreateElement("ReceivePaymentAddRq");
            qbXMLMsgsRq.AppendChild(receivePaymentAddRq);
            receivePaymentAddRq.SetAttribute("requestID", "1");

            XmlElement receivePaymentAdd = inputXMLDoc.CreateElement("ReceivePaymentAdd");
            receivePaymentAddRq.AppendChild(receivePaymentAdd);

            // Müşteri referansı ekle
            XmlElement customerRef = inputXMLDoc.CreateElement("CustomerRef");
            receivePaymentAdd.AppendChild(customerRef);
            customerRef.AppendChild(TransferHelper.MakeSimpleElem(inputXMLDoc, "FullName", collectionModels.CustomerName)); // Müşteri ListID'si

            // Ödeme tarihi, referans numarası ve toplam tutarı ekle
            receivePaymentAdd.AppendChild(TransferHelper.MakeSimpleElem(inputXMLDoc, "TxnDate", DateTime.Parse(collectionModels.TxnDate).ToString("yyyy-MM-dd")));
            //receivePaymentAdd.AppendChild(MakeSimpleElem(inputXMLDoc, "TxnDate", "2023-12-26"));
            receivePaymentAdd.AppendChild(TransferHelper.MakeSimpleElem(inputXMLDoc, "RefNumber", collectionModels.Number));
            receivePaymentAdd.AppendChild(TransferHelper.MakeSimpleElem(inputXMLDoc, "TotalAmount", collectionModels.TotalAmount.ToString()));

            XmlElement appliendtoTxnAdd = inputXMLDoc.CreateElement("AppliedToTxnAdd");
            receivePaymentAdd.AppendChild(appliendtoTxnAdd);
            appliendtoTxnAdd.AppendChild(TransferHelper.MakeSimpleElem(inputXMLDoc, "TxnID", collectionModels.AppliedTxnID)); // Ödeme Yöntemi ListID'si
            appliendtoTxnAdd.AppendChild(TransferHelper.MakeSimpleElem(inputXMLDoc, "PaymentAmount", collectionModels.AppliedPaymentAmount.ToString())); // Ödeme Yöntemi ListID'si


            // ödeme bir faturaya bağlayı yapılmayacak ise
            //receivePaymentAdd.AppendChild(TransferHelper.MakeSimpleElem(inputXMLDoc, "IsAutoApply", "false"));


            // Ödeme yöntemi referansı ekle
            //XmlElement paymentMethodRef = inputXMLDoc.CreateElement("PaymentMethodRef");
            //receivePaymentAdd.AppendChild(paymentMethodRef);
            //paymentMethodRef.AppendChild(MakeSimpleElem(inputXMLDoc, "FullName", "CASH")); // Ödeme Yöntemi ListID'si


            //// ARAccountRef ekle (isteğe bağlı)
            //XmlElement arAccountRef = inputXMLDoc.CreateElement("ARAccountRef");
            //receivePaymentAdd.AppendChild(arAccountRef);
            //arAccountRef.AppendChild(MakeSimpleElem(inputXMLDoc, "ListID", "200000-1011023419")); // Hesap ListID'si

            // Not (isteğe bağlı)
            //receivePaymentAdd.AppendChild(MakeSimpleElem(inputXMLDoc, "Memo", "Ödeme notu"));

            // İşlemi gerçekleştir
            string input = inputXMLDoc.OuterXml;

            var responseModel = ResponseCollection(input);

            return responseModel;

        }
        public static ResponseCollectionModels ResponseCollection(string requestXML)
        {
            ResponseCollectionModels collectionModels = new();


            if (requestXML == null)
            {
                collectionModels.StatusMessage = "One of the input is missing. Double-check your entries and then click Save again.";
                return collectionModels;
            }
            var connectInfo = ConnectManager.ConnectToQB();
            string returnXml = ConnectManager.ProcessRequestFromQB(connectInfo, requestXML);
            ConnectManager.DisconnectFromQB(connectInfo);
            try
            {
                XmlNodeList RsNodeList = null;
                XmlNodeList RsNodeListt = null;
                XmlDocument Doc = new XmlDocument();
                Doc.LoadXml(returnXml);
                RsNodeList = Doc.GetElementsByTagName("ReceivePaymentAddRs");
                XmlAttributeCollection rsAttributes = RsNodeList.Item(0).Attributes;
                XmlNode statusCode = rsAttributes.GetNamedItem("statusCode");
                collectionModels.StatusCode = Convert.ToString(statusCode.Value);
                XmlNode statusSeverity = rsAttributes.GetNamedItem("statusSeverity");
                collectionModels.StatusSeverity = Convert.ToString(statusSeverity.Value);
                XmlNode statusMessage = rsAttributes.GetNamedItem("statusMessage");
                collectionModels.StatusMessage = Convert.ToString(statusMessage.Value);
                RsNodeListt = Doc.GetElementsByTagName("ReceivePaymentRet");
                collectionModels.TxnId = RsNodeListt.Item(0).SelectSingleNode("TxnID").InnerText;
                //XmlNode txId = rsAttributess.GetNamedItem("TxnID");
                //string bb = txId.Value;

            }
            catch (Exception ex)
            {
                collectionModels.StatusMessage = ex.ToString();
            }

            return collectionModels;
        }
    }
}
