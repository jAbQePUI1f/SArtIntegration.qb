using SArtIntegration.qb.Manager.Customer;
using SArtIntegration.qb.Manager.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
