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
            this.WindowState = FormWindowState.Normal;
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
            setUpInventoryReportListView();
        }
        #endregion

        #region The list View
        
        public void setUpInventoryReportListView()
        {
            ListViewItem productDetails;
            Product product;
            inventoryReportListView.Clear();

            // Setting up the columns of the List View
            inventoryReportListView.Columns.Insert(0, "ProductID", 120, HorizontalAlignment.Left);
            inventoryReportListView.Columns.Insert(1, "Product_Name", 120, HorizontalAlignment.Left);
            inventoryReportListView.Columns.Insert(2, "Product_Description", 120, HorizontalAlignment.Left);
            inventoryReportListView.Columns.Insert(3, "Product_Price", 120, HorizontalAlignment.Left);
            //inventoryReportListView.Columns.Insert(4, "Product_Fresh_Quantity", 120, HorizontalAlignment.Left);
            inventoryReportListView.Columns.Insert(4, "Product_Quantity_Expired", 120, HorizontalAlignment.Left);
            //inventoryReportListView.Columns.Insert(6, "Product_Total_Quantity", 120, HorizontalAlignment.Left);
            //inventoryReportListView.Columns.Insert(5, "Product_Category", 120, HorizontalAlignment.Left);
            inventoryReportListView.Columns.Insert(5, "Product_Supplier", 120, HorizontalAlignment.Left);

            products = inventoryController.Products;

            // Add the product details to each ListView Item
            foreach (Product prod in products)
            {
                productDetails = new ListViewItem();
                productDetails.Text = prod.ProductID.ToString();
                productDetails.SubItems.Add(prod.ProductName);
                productDetails.SubItems.Add(prod.ProductDescription);
                productDetails.SubItems.Add(prod.ProductPrice.ToString());
                //productDetails.SubItems.Add(prod.ProductNotExpiredQuantity.ToString());
                productDetails.SubItems.Add(prod.ProductExpiredQuantity.ToString());
               // productDetails.SubItems.Add(prod.ProductTotalQuantity.ToString());
               // productDetails.SubItems.Add(prod.ProductCategory);
                productDetails.SubItems.Add(prod.ProductSupplier);

                inventoryReportListView.Items.Add(productDetails);
            }
            inventoryReportListView.Refresh();
            inventoryReportListView.GridLines = true;
        }
        #endregion
        
    }
}
