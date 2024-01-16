using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SArtIntegration.qb.Manager.Api;
using SArtIntegration.qb.Manager.Collection;
using SArtIntegration.qb.Manager.Config;
using SArtIntegration.qb.Manager.Customer;
using SArtIntegration.qb.Manager.Helper;
using SArtIntegration.qb.Manager.Invoice;
using SArtIntegration.qb.Manager.Item;
using SArtIntegration.qb.Models;
using SArtIntegration.qb.Models.Enums;
using SArtIntegration.qb.Models.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SArtIntegration.qb.Models.Enums.InvoiceTypes;
using static SArtIntegration.qb.Models.Enums.TransactionTypes;
using static SArtIntegration.qb.Models.Json.CollectionSyncRequest;
using static SArtIntegration.qb.Models.Json.InvoiceSyncRequest;

namespace SArtIntegration.qb
{
    public partial class mainScreen : Form
    {
        private readonly TransferCustomer _transferCustomer;
        private readonly TransferItems _transferItems;
        public mainScreen()
        {
            InitializeComponent();
            _transferCustomer = new TransferCustomer();
            _transferItems = new TransferItems();
        }

        private void bttnTrsansferToCustomer_Click(object sender, EventArgs e)
        {
            TransferCustomer.LoadCustomer();
        }

        private void bttnTransferToItems_Click(object sender, EventArgs e)
        {
            TransferItems.LoadItems();
        }

        private async void bttnTransferInvoice_Click(object sender, EventArgs e)
        {
            #region Faturaları çağır
            var invoiceRequest = new InvoiceRequest
            {
                startDate = "2023-12-01",
                endDate = "2024-01-01",
                invoiceTypes = new[] { InvoiceType.SELLING.DisplayName().ToString(), InvoiceType.BUYING.DisplayName().ToString() }
            };


            var invoiceResponse = await ApiManager.PostAsync<InvoiceRequest, InvoiceModelJson>(Configuration.GetUrl() + "management/invoices-for-erp", invoiceRequest);
            #endregion


            foreach (var item in invoiceResponse.data)
            {
                #region Faturaları QB aktar
                TransferInvoiceModels transferInvoice = new TransferInvoiceModels()
                {
                    BillAddr = "",
                    CustomerName = item.customerName,
                    InvoiceNumber = item.documentNumber,
                    TermsName = "",
                    TxnDate = item.documentDate.ToString(),
                    DueDate = item.documentDate.ToString(),
                    LineModels = new List<InvoiceLineModels>()

                };
                foreach (var detailItem in item.details)
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
                            InvoiceNumber = item.documentNumber,
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
                            InvoiceNumber = item.documentNumber,
                            RemoteInvoiceNumber = "",
                            ErrorMessage = transferResult.StatusMessage.ToString()
                        }
                        }
                    };
                }

                var response = await ApiManager.SendRequestAsync<InvoiceSyncRequest, InvoiceSyncResponse>(request, Configuration.GetUrl() + "sync-invoice-statuses");
                #endregion

                MessageBox.Show(response.message.ToString());
            }



        }

        private async void bttnTransferCollection_Click(object sender, EventArgs e)
        {
            #region Tahsilatları çağır
            var collectionRequest = new CollectionRequest
            {
                startDate = "2023-12-01",
                endDate = "2024-01-11",
                transactionTypes = new[] { TransactionType.CASH_COLLECTION.DisplayName().ToString(),
                    TransactionType.CASH_PAYMENT.DisplayName().ToString(),
                    TransactionType.CHECK_COLLECTION.DisplayName().ToString(),
                    TransactionType.CREDIT_CARD_PAYMENT.DisplayName().ToString(),
                    TransactionType.BOND_PAYMENT.DisplayName().ToString(),
                    TransactionType.BANK_TRANSFER_PAYMENT.DisplayName().ToString(),
                    TransactionType.CREDIT_CARD_COLLECTION.DisplayName().ToString(),
                    TransactionType.BOND_COLLECTION.DisplayName().ToString(),
                    TransactionType.CHECK_PAYMENT.DisplayName().ToString(),
                    TransactionType.BANK_TRANSFER_COLLECTION.DisplayName().ToString(),
                }

            };

            var collectionResponse = await ApiManager.PostAsync<CollectionRequest, CollectionModelJson>(Configuration.GetUrl() + "management/collections-for-erp", collectionRequest);
            #endregion

          
            foreach (var item in collectionResponse.data)
            {
                #region Tahsilatları aktar
                TransferCollectionModels collectionModels = new TransferCollectionModels()
                {
                    CustomerName = item.customerName,
                    Number = item.documentNo,
                    TxnDate = item.dueDate.ToString(),
                    AppliedTxnID = item.invoiceNo,
                    AppliedPaymentAmount = item.amount,
                    PaymentMethodName = item.paymentName,
                    TotalAmount = item.amount
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
                             customerFinancialTransactionId=item.customerFinancialTransactionId,
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
                           customerFinancialTransactionId=item.customerFinancialTransactionId,
                             message=result.StatusMessage,
                              synced=false
                        }
                        }
                    };
                }

                var response = await ApiManager.SendRequestAsync<CollectionSyncRequest, CollectionSyncResponse>(request, Configuration.GetUrl() + "sync-collection-statuses");
                #endregion

                MessageBox.Show(response.message.ToString());
            }

        }

    }
}
