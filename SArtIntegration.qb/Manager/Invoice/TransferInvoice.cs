using SArtIntegration.qb.Manager.Connect;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SArtIntegration.qb.Manager.Invoice
{
    public class TransferInvoice
    {
       
        public static ResponseInvoiceModels BuildInvoiceAddRqXML(TransferInvoiceModels transferInvoice)
        {
            //var connectDbResult = ConnectManager.ConnectToQB();
            string requestXML = "";

            //if (!validateInput()) return null;

            //GET ALL INPUT INTO XML
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement qbXMLMsgsRq = TransferHelper.BuildRqEnvelope(xmlDoc, UserSharedInfo.GetConnectInfo().MaxVersion);
            qbXMLMsgsRq.SetAttribute("onError", "stopOnError");
            XmlElement InvoiceAddRq = xmlDoc.CreateElement("InvoiceAddRq");
            qbXMLMsgsRq.AppendChild(InvoiceAddRq);
            XmlElement InvoiceAdd = xmlDoc.CreateElement("InvoiceAdd");
            InvoiceAddRq.AppendChild(InvoiceAdd);

            // CustomerRef -> FullName
            if (transferInvoice.CustomerName != "")
            {
                XmlElement Element_CustomerRef = xmlDoc.CreateElement("CustomerRef");
                InvoiceAdd.AppendChild(Element_CustomerRef);
                XmlElement Element_CustomerRef_FullName = xmlDoc.CreateElement("FullName");
                Element_CustomerRef.AppendChild(Element_CustomerRef_FullName).InnerText = transferInvoice.CustomerName;
            }

            // TxnDate Fatura TArihi
            DateTime DT_TxnDate = System.DateTime.Today;
            if (transferInvoice.TxnDate != "")
            {
                DT_TxnDate = Convert.ToDateTime(transferInvoice.TxnDate);
                string TxnDate = getDateString(DT_TxnDate);
                XmlElement Element_TxnDate = xmlDoc.CreateElement("TxnDate");
                InvoiceAdd.AppendChild(Element_TxnDate).InnerText = TxnDate;
            }

            // RefNumber Invoice Number
            if (transferInvoice.InvoiceNumber != "")
            {
                XmlElement Element_RefNumber = xmlDoc.CreateElement("RefNumber");
                InvoiceAdd.AppendChild(Element_RefNumber).InnerText = transferInvoice.InvoiceNumber;
            }

            // BillAddress bu bilgi müşteri üzerinden çekilecek yada faturadan gelecek
            if (transferInvoice.BillAddr != "")
            {
                string[] BillAddress = transferInvoice.BillAddr.Split('\n');
                XmlElement Element_BillAddress = xmlDoc.CreateElement("BillAddress");
                InvoiceAdd.AppendChild(Element_BillAddress);
                for (int i = 0; i < BillAddress.Length; i++)
                {
                    if (BillAddress[i] != "" || BillAddress[i] != null)
                    {
                        XmlElement Element_Addr = xmlDoc.CreateElement("Addr" + (i + 1));
                        Element_BillAddress.AppendChild(Element_Addr).InnerText = BillAddress[i];
                    }
                }
            }

            // TermsRef -> FullName Vade 
            bool termsAvailable = false;
            if (transferInvoice.TermsName != "")
            {
                termsAvailable = true;
                XmlElement Element_TermsRef = xmlDoc.CreateElement("TermsRef");
                InvoiceAdd.AppendChild(Element_TermsRef);
                XmlElement Element_TermsRef_FullName = xmlDoc.CreateElement("FullName");
                Element_TermsRef.AppendChild(Element_TermsRef_FullName).InnerText = transferInvoice.TermsName;
            }

            // DueDate girilin vade ye göre hesap yapıp due date oluşturuluyor.
            if (termsAvailable)
            {
                DateTime DT_DueDate = System.DateTime.Today;
                double dueInDays = getDueInDays(transferInvoice.TermsName);
                DT_DueDate = DT_TxnDate.AddDays(dueInDays);
                string DueDate = getDateString(DT_DueDate);
                XmlElement Element_DueDate = xmlDoc.CreateElement("DueDate");
                InvoiceAdd.AppendChild(Element_DueDate).InnerText = DueDate;
            }



            //Line Items
            XmlElement Element_InvoiceLineAdd;
            // ABD bölgesel ayarlarını oluşturmak için "en-US" kültürünü kullanın
            CultureInfo usCulture = new CultureInfo("en-US");

            // ABD bölgesel ayarlarını kullanan bir sayı biçimlendirici oluşturun
            NumberFormatInfo usNumberFormat = usCulture.NumberFormat;


            foreach (var item in transferInvoice.LineModels)
            {
                Element_InvoiceLineAdd = xmlDoc.CreateElement("InvoiceLineAdd");
                InvoiceAdd.AppendChild(Element_InvoiceLineAdd);

                XmlElement Element_InvoiceLineAdd_ItemRef = xmlDoc.CreateElement("ItemRef");
                Element_InvoiceLineAdd.AppendChild(Element_InvoiceLineAdd_ItemRef);
                XmlElement Element_InvoiceLineAdd_ItemRef_FullName = xmlDoc.CreateElement("FullName");
                Element_InvoiceLineAdd_ItemRef.AppendChild(Element_InvoiceLineAdd_ItemRef_FullName).InnerText = item.ItemName;

                XmlElement Element_InvoiceLineAdd_Desc = xmlDoc.CreateElement("Desc");
                Element_InvoiceLineAdd.AppendChild(Element_InvoiceLineAdd_Desc).InnerText = item.ItemDesc;

                XmlElement Element_InvoiceLineAdd_Quantity = xmlDoc.CreateElement("Quantity");
                Element_InvoiceLineAdd.AppendChild(Element_InvoiceLineAdd_Quantity).InnerText = item.Quantity.ToString();

                XmlElement Element_InvoiceLineAdd_Rate = xmlDoc.CreateElement("Rate");
                Element_InvoiceLineAdd.AppendChild(Element_InvoiceLineAdd_Rate).InnerText = item.UnitPrice.ToString().Replace(",", ".");

                XmlElement Element_InvoiceLineAdd_Amount = xmlDoc.CreateElement("Amount");
                Element_InvoiceLineAdd.AppendChild(Element_InvoiceLineAdd_Amount).InnerText = item.TotalAmount.ToString();


            }

            InvoiceAddRq.SetAttribute("requestID", "99");
            requestXML = xmlDoc.OuterXml;

            var responseModel = ResponseInvoice(requestXML);

            return responseModel;
        }

        public static ResponseInvoiceModels ResponseInvoice(string requestXML)
        {
            ResponseInvoiceModels response = new ResponseInvoiceModels();


            if (requestXML == null)
            {
                response.StatusMessage = "One of the input is missing. Double-check your entries and then click Save again.";
                return response;
            }
            //var connectInfo = ConnectManager.ConnectToQB();
            string returnXml = ConnectManager.ProcessRequestFromQB(UserSharedInfo.GetConnectInfo(), requestXML);
            ConnectManager.DisconnectFromQB(UserSharedInfo.GetConnectInfo());
            try
            {
                XmlNodeList RsNodeList = null;
                XmlNodeList RsNodeListt = null;
                XmlDocument Doc = new XmlDocument();
                Doc.LoadXml(returnXml);
                RsNodeList = Doc.GetElementsByTagName("InvoiceAddRs");
                XmlAttributeCollection rsAttributes = RsNodeList.Item(0).Attributes;
                XmlNode statusCode = rsAttributes.GetNamedItem("statusCode");
                response.StatusCode = Convert.ToString(statusCode.Value);
                XmlNode statusSeverity = rsAttributes.GetNamedItem("statusSeverity");
                response.StatusSeverity = Convert.ToString(statusSeverity.Value);
                XmlNode statusMessage = rsAttributes.GetNamedItem("statusMessage");
                response.StatusMessage = Convert.ToString(statusMessage.Value);
                RsNodeListt = Doc.GetElementsByTagName("InvoiceRet");
                response.TxnId = RsNodeListt.Item(0).SelectSingleNode("TxnID").InnerText;
                //XmlNode txId = rsAttributess.GetNamedItem("TxnID");
                //string bb = txId.Value;

            }
            catch (Exception ex)
            {
                response.StatusMessage = ex.ToString();
            }

            return response;
        }

     

        #region helper
        private static string getDateString(DateTime dt)
        {
            string year = dt.Year.ToString();
            string month = dt.Month.ToString();
            if (month.Length < 2) month = "0" + month;
            string day = dt.Day.ToString();
            if (day.Length < 2) day = "0" + day;
            return year + "-" + month + "-" + day;
        }
        private static double getDueInDays(string terms)
        {
            double dueInDays = 0;
            switch (terms)
            {
                case "Due on receipt":
                    dueInDays = 0;
                    break;
                case "Net 15":
                    dueInDays = 15;
                    break;
                case "Net 30":
                    dueInDays = 30;
                    break;
                case "Net 60":
                    dueInDays = 60;
                    break;
                default:
                    dueInDays = 0;
                    break;
            }
            return dueInDays;
        }
        #endregion
    }
}
