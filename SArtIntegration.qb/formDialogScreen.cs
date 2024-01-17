using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SArtIntegration.qb.Models.Enums.InvoiceTypes;

namespace SArtIntegration.qb
{
    public partial class formDialogScreen : Form
    {
        public formDialogScreen()
        {
            InitializeComponent();
        }
        string invoiceType;
        private void comBoxDocument_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comBoxDocument.SelectedIndex)
            {
                case 0:
                    invoiceType = "SELLING";
                    break;
                case 1:
                    invoiceType = "DAMAGED_SELLING_RETURN";
                    break;
                case 2:
                    invoiceType = "SELLING_RETURN";
                    break;
                case 3:
                    invoiceType = "SELLING_SERVICE";
                    break;
                case 4:
                    invoiceType = "BUYING_SERVICE";
                    break;
                case 5:
                    invoiceType = "BUYING";
                    break;
                case 6:
                    invoiceType = "DAMAGED_BUYING_RETURN";
                    break;
                case 7:
                    invoiceType = "BUYING_RETURN";
                    break;
            }
        }
    }
    
}