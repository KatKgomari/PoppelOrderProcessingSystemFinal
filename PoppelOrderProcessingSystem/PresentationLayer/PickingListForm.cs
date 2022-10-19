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
using System.Windows.Forms.VisualStyles;

namespace PoppelOrderProcessingSystem.PresentationLayer
{
    public partial class PickingListForm : Form
    {
        #region Data Members
        public bool listFormClosed;
        private CustomerController customerController;
        private Customer customer;
        private OrderItem orderItem;
        private Collection<OrderItem> orderItems;
        private decimal orderTotalAmount;
        #endregion
        public PickingListForm(CustomerController customerController, Collection<OrderItem> orderItems, decimal orderTotalAmount)
        {
            InitializeComponent();
            this.customerController = customerController;
            this.orderItems = orderItems;
            customer = customerController.Customer;
            totalTextBox.Enabled = false;
            totalTextBox.Text = orderTotalAmount.ToString();
            dateTextBox.Enabled = false;
            dateTextBox.Text = DateTime.Now.ToString();
            pickingListCustomerTextBox.Enabled = false;
            customerIDTextBox.Enabled = false;
            customerIDTextBox.Text = customer.CustomerID.ToString();
            pickingListCustomerTextBox.Text = customer.CustomerName;
        }

        #region Form events 
        private void PickingListForm_Load(object sender, EventArgs e)
        {
            pickingList_ListView.View = View.Details;
        }
        
        private void PickingListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        private void PickingListForm_Activated(object sender, EventArgs e)
        {
            pickingList_ListView.View = View.Details;
            setUpPickingListView();
        }
        #endregion

        #region The list view

        public void setUpPickingListView()
        {
            ListViewItem orderItemDetails;
            OrderItem orderItem;
            pickingList_ListView.Clear();

            // Setting up the columns of the List View
            pickingList_ListView.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            pickingList_ListView.Columns.Insert(1, "Description", 150, HorizontalAlignment.Left);
            pickingList_ListView.Columns.Insert(2, "Price", 150, HorizontalAlignment.Left);
            pickingList_ListView.Columns.Insert(3, "Quantity", 150, HorizontalAlignment.Left);
            pickingList_ListView.Columns.Insert(4, "Total Price", 150, HorizontalAlignment.Left);
            
            // Add the product details to each ListView Item
            foreach (OrderItem ord in orderItems)
            {
                orderItemDetails = new ListViewItem();
                orderItemDetails.Text = ord.ID.ToString();
                orderItemDetails.SubItems.Add(ord.Description);
                orderItemDetails.SubItems.Add(ord.Price.ToString());
                orderItemDetails.SubItems.Add(ord.Quantity.ToString());
                decimal total = ord.Price * ord.Quantity;
                orderItemDetails.SubItems.Add(total.ToString());

                pickingList_ListView.Items.Add(orderItemDetails);
            }
            pickingList_ListView.Refresh();
            //orderItemsListView.GridLines = true;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picking list sent to Picking Clerk.");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
