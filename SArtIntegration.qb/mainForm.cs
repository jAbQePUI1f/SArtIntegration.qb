﻿using SArtIntegration.qb.Manager.Customer;
using SArtIntegration.qb.Manager.Item;
using static SArtIntegration.qb.Models.Enums.DocumentTypes;

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
            formDialogScreen frmDialog = new formDialogScreen(DocumentType.InvoiceType);
            frmDialog.ShowDialog();
            this.Close();

            #region --Get Invoice
            //var invoiceRequest = new InvoiceRequest
            //{
            //    startDate = "2023-12-01",
            //    endDate = "2024-01-01",
            //    invoiceTypes = new[] { InvoiceType.SELLING.DisplayName().ToString(), InvoiceType.BUYING.DisplayName().ToString() }
            //};


            //var invoiceResponse = await ApiManager.PostAsync<InvoiceRequest, InvoiceModelJson>(Configuration.GetUrl() + "management/invoices-for-erp", invoiceRequest);
            #endregion

            #region --Send Invoice
            //foreach (var item in invoiceResponse.data)
            //{
            //    TransferInvoiceModels transferInvoice = new TransferInvoiceModels()
            //    {
            //        BillAddr = "",
            //        CustomerName = item.customerName,
            //        InvoiceNumber = item.documentNumber,
            //        TermsName = "",
            //        TxnDate = item.documentDate.ToString(),
            //        DueDate = item.documentDate.ToString(),
            //        LineModels = new List<InvoiceLineModels>()

            //    };
            //    foreach (var detailItem in item.details)
            //    {
            //        InvoiceLineModels lineModel = new InvoiceLineModels()
            //        {
            //            ItemDesc = detailItem.code,
            //            ItemName = detailItem.code,
            //            Quantity = detailItem.quantity,
            //            TotalAmount = Convert.ToDecimal(detailItem.grossTotal),
            //            UnitPrice = Convert.ToDecimal(detailItem.price)
            //        };

            //        transferInvoice.LineModels.Add(lineModel);
            //    }

            //    var transferResult = TransferInvoice.BuildInvoiceAddRqXML(transferInvoice);
            #endregion

            #region --Sync Invoice
            //InvoiceSyncRequest request = new InvoiceSyncRequest();

            //if (transferResult.TxnId != null)
            //{
            //    request = new InvoiceSyncRequest
            //    {
            //        IntegratedInvoices = new[]
            //       {
            //        new IntegratedInvoice
            //        {
            //            SuccessfullyIntegrated = true,
            //            InvoiceNumber = item.documentNumber,
            //            RemoteInvoiceNumber = transferResult.TxnId,
            //            ErrorMessage = transferResult.StatusMessage.ToString()
            //        }
            //        }
            //    };

            //}
            //else
            //{
            //    request = new InvoiceSyncRequest
            //    {
            //        IntegratedInvoices = new[]
            //      {
            //        new IntegratedInvoice
            //        {
            //            SuccessfullyIntegrated = false,
            //            InvoiceNumber = item.documentNumber,
            //            RemoteInvoiceNumber = "",
            //            ErrorMessage = transferResult.StatusMessage.ToString()
            //        }
            //        }
            //    };
            //}

            //var response = await ApiManager.SendRequestAsync<InvoiceSyncRequest, InvoiceSyncResponse>(request, Configuration.GetUrl() + "sync-invoice-statuses");
            //MessageBox.Show(response.message.ToString());
            //}
            #endregion
        }
        private async void bttnTransferCollection_Click(object sender, EventArgs e)
        {

            formDialogScreen frmDialog = new formDialogScreen(DocumentType.CollectionType);
            frmDialog.ShowDialog();

            this.Close();

            #region --Get Collection
            //var collectionRequest = new CollectionRequest
            //{
            //    startDate = "2023-12-01",
            //    endDate = "2024-01-11",
            //    transactionTypes = new[] { TransactionType.CASH_COLLECTION.DisplayName().ToString(),
            //        TransactionType.CASH_PAYMENT.DisplayName().ToString(),
            //        TransactionType.CHECK_COLLECTION.DisplayName().ToString(),
            //        TransactionType.CREDIT_CARD_PAYMENT.DisplayName().ToString(),
            //        TransactionType.BOND_PAYMENT.DisplayName().ToString(),
            //        TransactionType.BANK_TRANSFER_PAYMENT.DisplayName().ToString(),
            //        TransactionType.CREDIT_CARD_COLLECTION.DisplayName().ToString(),
            //        TransactionType.BOND_COLLECTION.DisplayName().ToString(),
            //        TransactionType.CHECK_PAYMENT.DisplayName().ToString(),
            //        TransactionType.BANK_TRANSFER_COLLECTION.DisplayName().ToString(),
            //    }

            //};

            //var collectionResponse = await ApiManager.PostAsync<CollectionRequest, CollectionModelJson>(Configuration.GetUrl() + "management/collections-for-erp", collectionRequest);
            #endregion

            #region --Send Collection
            //foreach (var item in collectionResponse.data)
            //{
            //    
            //    TransferCollectionModels collectionModels = new TransferCollectionModels()
            //    {
            //        CustomerName = item.customerName,
            //        Number = item.documentNo,
            //        TxnDate = item.dueDate.ToString(),
            //        AppliedTxnID = item.invoiceNo,
            //        AppliedPaymentAmount = item.amount,
            //        PaymentMethodName = item.paymentName,
            //        TotalAmount = item.amount
            //    };

            //    var result = TransferCollection.BuildCollectionAddRqXML(collectionModels);
            #endregion

            #region --Sync Collection
            //    CollectionSyncRequest request = new CollectionSyncRequest();

            //    if (result.TxnId != null)
            //    {
            //        request = new CollectionSyncRequest
            //        {
            //            IntegratedCollections = new[]
            //           {
            //            new IntegratedCollection
            //            {
            //                 customerFinancialTransactionId=item.customerFinancialTransactionId,
            //                 message=result.StatusMessage,
            //                  synced=true

            //            }
            //            }
            //        };
            //    }
            //    else
            //    {
            //        request = new CollectionSyncRequest
            //        {
            //            IntegratedCollections = new[]
            //          {
            //            new IntegratedCollection
            //            {
            //               customerFinancialTransactionId=item.customerFinancialTransactionId,
            //                 message=result.StatusMessage,
            //                  synced=false
            //            }
            //            }
            //        };
            //    }

            //    var response = await ApiManager.SendRequestAsync<CollectionSyncRequest, CollectionSyncResponse>(request, Configuration.GetUrl() + "sync-collection-statuses");
            //    MessageBox.Show(response.message.ToString());
            //}
            #endregion
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
