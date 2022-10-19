using PoppelOrderProcessingSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelOrderProcessingSystem.PresentationLayer
{
    
    public partial class InventoryReport : Form
    {
        public bool listFormClosed;
        private Collection<Product> products;
        private InventoryController inventoryController;
        private Product product;
        public InventoryReport(InventoryController inventoryController)
        {
            InitializeComponent();
            dateTextBox.Enabled = false;
            dateTextBox.Text = DateTime.Now.ToString();
            this.inventoryController = inventoryController;
        }


        #region Form Events
        private void InventoryReport_Load(object sender, EventArgs e)
        {
            inventoryReportListView.View = View.Details;
        }

        private void InventoryReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        

        private void InventoryReport_Activated(object sender, EventArgs e)
        {
            inventoryReportListView.View = View.Details;
        }
        #endregion
    }
}
