using SArtIntegration.qb.Manager.Api;
using SArtIntegration.qb.Manager.Collection;
using SArtIntegration.qb.Manager.Config;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Manager.Invoice;
using SArtIntegration.qb.Models;
using SArtIntegration.qb.Models.Enums;
using SArtIntegration.qb.Models.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SArtIntegration.qb.Models.Enums.DocumentTypes;
using static SArtIntegration.qb.Models.Enums.InvoiceTypes;
using static SArtIntegration.qb.Models.Enums.TransactionTypes;
using static SArtIntegration.qb.Models.Json.CollectionSyncRequest;
using static SArtIntegration.qb.Models.Json.InvoiceSyncRequest;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SArtIntegration.qb
{
    public partial class formDialogScreen : Form
    {
        string documentType = "";
        DocumentType operationType;
        InvoiceModelJson invoiceResponse = new InvoiceModelJson();
        CollectionModelJson collectionResponse = new CollectionModelJson();
        public formDialogScreen(DocumentType type)
        {

            operationType = type;
            InitializeComponent();
            btnTransfer.Text = "Transfer Data";
            FillComboBoxWithEnumValues(type);

        }
        private void FillComboBoxWithEnumValues(DocumentType type)
        {
            Type enumType = type switch
            {
                DocumentType.InvoiceType => typeof(InvoiceTypes.InvoiceType),
                DocumentType.CollectionType => typeof(TransactionTypes.TransactionType),
                _ => throw new ArgumentException("Geçersiz ComboBox tipi"),
            };

            var enumValues = Enum.GetValues(enumType)
                                .Cast<Enum>()
                                .Select(e => new
                                {
                                    Value = e,
                                    Text = GetEnumDisplayValue(e)
                                })
                                .ToList();

            comBoxDocument.Items.Clear();
            comBoxDocument.DataSource = enumValues;
            comBoxDocument.DisplayMember = "Text";
            comBoxDocument.ValueMember = "Value";
        }



        private async void bttnGetData_Click(object sender, EventArgs e)
        {


            #region helper



            string checkBoxColumnName = "chk";

            DataGridViewColumn checkBoxColumn = dataGridView1.Columns[checkBoxColumnName];

            if (checkBoxColumn != null && checkBoxColumn is DataGridViewCheckBoxColumn)
            {
                ((DataGridViewCheckBoxColumn)checkBoxColumn).Visible = true;
            }
            chckAll.Visible = true;
            #endregion

            string beginDate = pickerBeginDate.Value.ToString("yyyy-MM-dd");
            string endDate = pickerEndDate.Value.ToString("yyyy-MM-dd");

            if (operationType == DocumentType.InvoiceType)
            {

                var invoiceRequest = new InvoiceRequest
                {
                    startDate = beginDate, //"2023-12-01",
                    endDate = endDate,//"2024-01-01",
                    invoiceTypes = new[] { documentType }
                };

                invoiceResponse = await ApiManager.PostAsync<InvoiceRequest, InvoiceModelJson>(Configuration.GetUrl() + "management/invoices-for-erp", invoiceRequest);

                List<DisplayInvoiceInfo> displayInfoList = invoiceResponse.data.Select(header => new DisplayInvoiceInfo
                {
                    Number = header.number,
                    Date = header.date.ToShortDateString(),
                    DocumentNumber = header.documentNumber,
                    CustomerCode = header.customerCode,
                    CustomerName = header.customerName,
                    DiscountTotal = header.discountTotal.ToString(),
                    VatTotal = header.vatTotal.ToString(),
                    GrossTotal = header.grossTotal.ToString()
                }).ToList();

                dataGridView1.DataSource = displayInfoList;
            }
            else
            {
                var collectionRequest = new CollectionRequest
                {
                    startDate = beginDate,//"2023-12-01",
                    endDate = endDate,//"2024-01-11",
                    transactionTypes = new[] { documentType,
                }

                };

                collectionResponse = await ApiManager.PostAsync<CollectionRequest, CollectionModelJson>(Configuration.GetUrl() + "management/collections-for-erp", collectionRequest);


                List<DisplayCollectionInfo> displayInfoList = collectionResponse.data.Select(header => new DisplayCollectionInfo
                {
                    Number = header.invoiceNo,
                    Date = header.date.ToShortDateString(),
                    DocumentNo = header.documentNo,
                    CustomerCode = header.customerCode,
                    CustomerName = header.customerName,
                    Amount = header.amount.ToString(),

                }).ToList();

                dataGridView1.DataSource = displayInfoList;

            }

        }

        private void chckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chckAll.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["chk"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["chk"].Value = false;
                }
            }
        }


        private void comBoxDocument_SelectedIndexChanged(object sender, EventArgs e)
        {

            object selectedItem = comBoxDocument.SelectedItem;

            if (selectedItem != null)
            {
                // Eğer ComboBox'da eklenen nesne bir anonim tür ise
                if (selectedItem.GetType().GetProperty("Text") != null)
                {
                    documentType = selectedItem.GetType().GetProperty("Text").GetValue(selectedItem)?.ToString();
                    // Burada seçilen metni kullanabilirsiniz
                }
                // Eğer ComboBox'da eklenen nesne bir enum ise
                else if (selectedItem is Enum)
                {
                    documentType = GetEnumDisplayValue((Enum)selectedItem);
                    // Burada seçilen metni kullanabilirsiniz
                }
            }


        }

        private string GetEnumDisplayValue(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var displayAttribute = (DisplayAttribute)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));

            return displayAttribute == null ? value.ToString() : displayAttribute.Name;
        }

        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (Convert.ToBoolean(row.Cells["chk"].Value))
                {

                    string number = row.Cells["Number"].Value.ToString();

                    if (operationType == DocumentType.InvoiceType)
                    {

                        var selectedInvoice = invoiceResponse.data.FirstOrDefault(inv => inv.number == number);


                        #region Faturaları QB aktar
                        TransferInvoiceModels transferInvoice = new TransferInvoiceModels()
                        {
                            BillAddr = "",
                            CustomerName = selectedInvoice.customerName,
                            InvoiceNumber = selectedInvoice.documentNumber,
                            TermsName = "",
                            TxnDate = selectedInvoice.documentDate.ToString(),
                            DueDate = selectedInvoice.documentDate.ToString(),
                            LineModels = new List<InvoiceLineModels>()

                        };
                        foreach (var detailItem in selectedInvoice.details)
                        {
                            InvoiceLineModels lineModel = new InvoiceLineModels()
                            {
                                ItemDesc = detailItem.code,
                                ItemName = detailItem.code,
                                Quantity = detailItem.quantity,
                                TotalAmount = Convert.ToDecimal(detailItem.grossTotal),
                                UnitPrice = Convert.ToDecimal(detailItem.price)
                            };

                            transferInvoice.LineModels.Add(lineModel);
                        }

                        var transferResult = TransferInvoice.BuildInvoiceAddRqXML(transferInvoice);
                        #endregion

                        #region Faturalar Başarılı/Başarısız İşaretle
                        InvoiceSyncRequest request = new InvoiceSyncRequest();

                        if (transferResult.TxnId != null)
                        {
                            request = new InvoiceSyncRequest
                            {
                                IntegratedInvoices = new[]
                               {
                        new IntegratedInvoice
                        {
                            SuccessfullyIntegrated = true,
                            InvoiceNumber = selectedInvoice.documentNumber,
                            RemoteInvoiceNumber = transferResult.TxnId,
                            ErrorMessage = transferResult.StatusMessage.ToString()
                        }
                        }
                            };



                        }
                        else
                        {
                            request = new InvoiceSyncRequest
                            {
                                IntegratedInvoices = new[]
                              {
                        new IntegratedInvoice
                        {
                            SuccessfullyIntegrated = false,
                            InvoiceNumber = selectedInvoice.documentNumber,
                            RemoteInvoiceNumber = "",
                            ErrorMessage = transferResult.StatusMessage.ToString()
                        }
                        }
                            };
                        }

                        var response = await ApiManager.SendRequestAsync<InvoiceSyncRequest, InvoiceSyncResponse>(request, Configuration.GetUrl() + "sync-invoice-statuses");
                        #endregion

                    }
                    else
                    {
                        var selectedCollection = collectionResponse.data.FirstOrDefault(inv => inv.documentNo == number);

                        #region Tahsilatları aktar
                        TransferCollectionModels collectionModels = new TransferCollectionModels()
                        {
                            CustomerName = selectedCollection.customerName,
                            Number = selectedCollection.documentNo,
                            TxnDate = selectedCollection.dueDate.ToString(),
                            AppliedTxnID = selectedCollection.invoiceNo,
                            AppliedPaymentAmount = selectedCollection.amount,
                            PaymentMethodName = selectedCollection.paymentName,
                            TotalAmount = selectedCollection.amount
                        };

                        var result = TransferCollection.BuildCollectionAddRqXML(collectionModels);
                        #endregion

                        #region Tahsilatlar Başarılı/Başarısız İşaretle
                        CollectionSyncRequest request = new CollectionSyncRequest();

                        if (result.TxnId != null)
                        {
                            request = new CollectionSyncRequest
                            {
                                IntegratedCollections = new[]
                               {
                        new IntegratedCollection
                        {
                             customerFinancialTransactionId=selectedCollection.customerFinancialTransactionId,
                             message=result.StatusMessage,
                              synced=true

                        }
                        }
                            };
                        }
                        else
                        {
                            request = new CollectionSyncRequest
                            {
                                IntegratedCollections = new[]
                              {
                        new IntegratedCollection
                        {
                           customerFinancialTransactionId=selectedCollection.customerFinancialTransactionId,
                             message=result.StatusMessage,
                              synced=false
                        }
                        }
                            };
                        }

                        var response = await ApiManager.SendRequestAsync<CollectionSyncRequest, CollectionSyncResponse>(request, Configuration.GetUrl() + "sync-collection-statuses");
                        #endregion


                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            new mainScreen().Show();
        }
    }

}