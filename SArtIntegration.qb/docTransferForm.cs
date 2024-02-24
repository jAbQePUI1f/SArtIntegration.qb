using SArtIntegration.qb.Manager.Api;
using SArtIntegration.qb.Manager.Collection;
using SArtIntegration.qb.Manager.Config;
using SArtIntegration.qb.Manager.Invoice;
using SArtIntegration.qb.Models;
using SArtIntegration.qb.Models.Enums;
using SArtIntegration.qb.Models.Json;
using System.ComponentModel.DataAnnotations;
using System.Data;
using static SArtIntegration.qb.Models.Enums.DocumentTypes;
using static SArtIntegration.qb.Models.Json.CollectionSyncRequest;
using static SArtIntegration.qb.Models.Json.InvoiceSyncRequest;

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

                collectionResponse = await ApiManager.PostAsync<CollectionRequest,
                    CollectionModelJson>(Configuration.GetUrl() + "management/collections-for-erp", collectionRequest);


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

                    if (operationType == DocumentType.InvoiceType)
                    {
                        string number = row.Cells["Number"].Value.ToString();
                        var selectedInvoice = invoiceResponse.data.FirstOrDefault(inv => inv.number == number);

                        #region --Send Invoice To QB
                        TransferInvoiceModels transferInvoice = new TransferInvoiceModels()
                        {
                            BillAddr = selectedInvoice.customerBranchName,
                            CustomerName = selectedInvoice.customerName,
                            InvoiceNumber = selectedInvoice.number,
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
                                TotalAmount = Convert.ToDecimal(detailItem.grossTotal.ToString("0.00")),
                                UnitPrice = Convert.ToDecimal(detailItem.price.ToString("0.00"))
                            };

                            transferInvoice.LineModels.Add(lineModel);
                        }

                        var transferResult = TransferInvoice.BuildInvoiceAddRqXML(transferInvoice);
                        #endregion

                        #region --Sync Invoice

                        InvoiceSyncRequest request = new InvoiceSyncRequest();

                        if (transferResult.TxnId != null)
                        {
                            request = new InvoiceSyncRequest
                            {
                                integratedInvoices = new[]
                               {
                        new IntegratedInvoice
                        {
                            successfullyIntegrated = true,
                            invoiceNumber = selectedInvoice.number,
                            remoteInvoiceNumber = transferResult.TxnId,
                            errorMessage = transferResult.StatusMessage.ToString()
                        }
                        }
                            };



                        }
                        else
                        {
                            request = new InvoiceSyncRequest
                            {
                                integratedInvoices = new[]
                              {
                        new IntegratedInvoice
                        {
                            successfullyIntegrated = false,
                            invoiceNumber = selectedInvoice.number,
                            remoteInvoiceNumber = "",
                            errorMessage = transferResult.StatusMessage.ToString()
                        }
                        }
                            };
                        }

                        //                     request = new InvoiceSyncRequest
                        //                     {
                        //                         integratedInvoices = new[]
                        //{
                        //     new IntegratedInvoice
                        //     {
                        //         successfullyIntegrated = false,
                        //         invoiceNumber = "SKNETE00024599",
                        //         remoteInvoiceNumber = "",
                        //         errorMessage = "System.NullReferenceException: Object reference not set to an instance of an object.170"
                        //     }
                        // }
                        //                     };



                        var response = await ApiManager.PutAsync<InvoiceSyncRequest, InvoiceSyncResponse>(request, Configuration.GetUrl() + "management/sync-invoice-statuses");


                        #endregion

                    }
                    else
                    {
                        string number = row.Cells["DocumentNo"].Value.ToString();
                        var selectedCollection = collectionResponse.data.FirstOrDefault(inv => inv.documentNo == number);

                        #region --Send Collection To QB
                        TransferCollectionModels collectionModels = new TransferCollectionModels()
                        {
                            CustomerName = selectedCollection.customerName,
                            Number = selectedCollection.documentNo,
                            TxnDate = selectedCollection.createDate.ToString(),
                            AppliedTxnID = selectedCollection.invoiceNo,
                            AppliedPaymentAmount = Convert.ToDecimal(selectedCollection.amount.ToString("0.00")),
                            PaymentMethodName = selectedCollection.paymentName,
                            TotalAmount = Convert.ToDecimal(selectedCollection.amount.ToString("0.00")),
                        };

                        var result = TransferCollection.BuildCollectionAddRqXML(collectionModels);
                        #endregion

                        #region --Sync Collection
                        CollectionSyncRequest request = new CollectionSyncRequest();

                        if (result.TxnId != null)
                        {
                            request = new CollectionSyncRequest
                            {
                                integratedCollections = new[]
                               {
                        new IntegratedCollection
                        {
                             ficheNo=selectedCollection.ficheNo,
                             errorMessage=result.StatusMessage,
                             successfullyIntegrated=true,
                             remoteCollectionNumber=result.TxnId

                        }
                        }
                            };
                        }
                        else
                        {
                            request = new CollectionSyncRequest
                            {
                                integratedCollections = new[]
                              {
                        new IntegratedCollection
                        {
                           ficheNo=selectedCollection.ficheNo,
                           errorMessage=result.StatusMessage,
                           successfullyIntegrated=false
                        }
                        }
                            };
                        }

                        var response = await ApiManager.PostAsync<CollectionSyncRequest, CollectionSyncResponse>(Configuration.GetUrl() + "management/sync-collection-statuses", request);

                        #endregion
                        
                    }
                }
            }
            MessageBox.Show("Transfer is Completed");
        }
        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new mainScreen().Show();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}