using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using PoppelOrderProcessingSystem.BusinessLayer;
using static PoppelOrderProcessingSystem.PresentationLayer.CustomerForm;
using PoppelOrderProcessingSystem.DatabaseLayer;

namespace PoppelOrderProcessingSystem.PresentationLayer
{
    public partial class OrderForm : Form
    {

        #region Data Members
        public bool listFormClosed;
        private FormStates state;
        private Collection<Product> products;
        private InventoryController inventoryController;
        private CustomerController customerController;
        private Product product;
        private Customer customer;
        private decimal amount;   // This is the price * quantity of each order item.
        private decimal totalSoFar; // This is the total so far
        private decimal remainingCustomerCreditAmount;
        private int productFound;  // We will insert the customer that is found using the find method here.

        // Order items for the order
        private OrderItem orderItem;
        private Collection<OrderItem> orderItems;

        // So we can open the next page:
        private PickingListForm pickingListForm;

        #endregion

        #region Property Methods 
        public Collection<OrderItem> OrderItems
        {
            get { return orderItems; }
        }
        #endregion

        #region Enumeration
        public enum FormStates
        {
            View = 0,
            Add = 1,
            Edit = 2,
            Delete = 3
        }
        #endregion

        #region Constructor
        public OrderForm(CustomerController customerController, InventoryController inventoryController)
        {
            InitializeComponent();
            this.inventoryController = inventoryController;
            this.customerController = customerController;
            customer = customerController.Customer;
            this.WindowState = FormWindowState.Normal;
            this.Load += OrderForm_Load;
            state = FormStates.View;
            remainingCustomerCreditAmount = customer.CustomerCreditAmount;
            customerCreditAmountTextBox.Text = remainingCustomerCreditAmount.ToString();

            customerCreditAmountTextBox.Enabled = false;
            totalSoFar = 0;
            amount = 0;
            totalSoFarTextBox.Text = amount.ToString();
            totalSoFarTextBox.Enabled = false;
            undoButton.Visible = false;

            products = inventoryController.Products;
            // So we can add order items and send them to the checkout page.
            orderItems = new Collection<OrderItem>();

            

        }
        #endregion


        #region Form Events

        private void OrderForm_Load(object sender, EventArgs e)
        {
            orderItemsListView.View = View.Details;
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            productIDTextBox.Enabled = false;
            productNameTextBox.Enabled = false;
            productDescriptionTextBox.Enabled = false;
            productPriceTextBox.Enabled = false;
            orderItemsListView.View = View.Details;
            setUpOrderItemsListView();
            // ShowAll(false); Actually, not this because I want them to always be visible
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
        #endregion

        #region The List View
        public void setUpOrderItemsListView()
        {
            ListViewItem productDetails;
            Product product;
            orderItemsListView.Clear();

            // Setting up the columns of the List View
            orderItemsListView.Columns.Insert(0, "ProductID", 120, HorizontalAlignment.Left);
            orderItemsListView.Columns.Insert(1, "Product_Name", 120, HorizontalAlignment.Left);
            orderItemsListView.Columns.Insert(2, "Product_Description", 120, HorizontalAlignment.Left);
            orderItemsListView.Columns.Insert(3, "Product_Price", 120, HorizontalAlignment.Left);
            orderItemsListView.Columns.Insert(4, "Product_Fresh_Quantity", 120, HorizontalAlignment.Left);
            orderItemsListView.Columns.Insert(5, "Product_Quantity_Expired", 120, HorizontalAlignment.Left);
            orderItemsListView.Columns.Insert(6, "Product_Total_Quantity", 120, HorizontalAlignment.Left);
            orderItemsListView.Columns.Insert(7, "Product_Category", 120, HorizontalAlignment.Left);
            orderItemsListView.Columns.Insert(8, "Product_Supplier", 120, HorizontalAlignment.Left);

            

            // Add the product details to each ListView Item
            foreach(Product prod in products)
            {
                productDetails = new ListViewItem();
                productDetails.Text = prod.ProductID.ToString();
                productDetails.SubItems.Add(prod.ProductName);
                productDetails.SubItems.Add(prod.ProductDescription);
                productDetails.SubItems.Add(prod.ProductPrice.ToString());
                productDetails.SubItems.Add(prod.ProductNotExpiredQuantity.ToString());
                productDetails.SubItems.Add(prod.ProductExpiredQuantity.ToString());
                productDetails.SubItems.Add(prod.ProductTotalQuantity.ToString());
                productDetails.SubItems.Add(prod.ProductCategory);
                productDetails.SubItems.Add(prod.ProductSupplier);

                orderItemsListView.Items.Add(productDetails);
            }
            orderItemsListView.Refresh();
            orderItemsListView.GridLines = true;
        }
        #endregion

        #region Utility Methods 

        private void ClearAll()
        {
            productIDTextBox.Text = "";
            productNameTextBox.Text = "";
            productDescriptionTextBox.Text = "";
            productQuantityTextBox.Text = "";
            productPriceTextBox.Text = "";
        }

        private void PopulateTextBoxes(Product product)
        {
            productIDTextBox.Text = product.ProductID.ToString();
            productNameTextBox.Text = product.ProductName;
            productDescriptionTextBox.Text = product.ProductDescription;
            productPriceTextBox.Text = product.ProductPrice.ToString();

            //productQuantityTextBox.Text = "";       // Marketing clerk enters value
        }



        #endregion

        private void orderItemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ShowAll(true);
            state = FormStates.View;
            //EnableEntries(false);
            if (orderItemsListView.SelectedItems.Count > 0)   // if you selected an item 
            {
                product = inventoryController.Find(orderItemsListView.SelectedItems[0].Text);  //selected employee becoms current employee
                PopulateTextBoxes(product);
            }
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            
            if ((productQuantityTextBox.Text == "") || (productDescriptionTextBox.Text == "") || (productNameTextBox.Text == "") || (productPriceTextBox.Text == "") || (productIDTextBox.Text == ""))
            {
                MessageBox.Show("Please make sure that all areas are filled.");
            }
            else if (Convert.ToInt16(productQuantityTextBox.Text) == 0)
            {
                MessageBox.Show("Product Quantity can not be zero.");
                return;
            }
            
            
                amount = (Convert.ToDecimal(productPriceTextBox.Text) * Convert.ToDecimal(productQuantityTextBox.Text));
                totalSoFar += amount;
                remainingCustomerCreditAmount -= amount;

                orderItem = new OrderItem();
                orderItem.ID = productIDTextBox.Text;
                productFound = FindIndex(orderItem); //We  have found the product in the databse

            if (remainingCustomerCreditAmount >= totalSoFar && products[productFound].ProductNotExpiredQuantity >= Convert.ToDecimal(productQuantityTextBox.Text)){ 
                totalSoFarTextBox.Text = amount.ToString();
                customerCreditAmountTextBox.Text = remainingCustomerCreditAmount.ToString();
                
                orderItem.Name = productNameTextBox.Text;
                orderItem.Description = productDescriptionTextBox.Text;
                orderItem.Price = Convert.ToDecimal(productPriceTextBox.Text);
                orderItem.Quantity = Convert.ToInt16(productQuantityTextBox.Text);
                orderItems.Add(orderItem);

                // Must check whether we have not exceeded credit amount

                // Lessening the quantity of the product in the database. We will need the inventoryController
                productFound = FindIndex(orderItem); //We  have found the product in the databse
                if (productFound == -1)
                {
                    MessageBox.Show("Something went wrong");
                }
                else
                {
                    products[productFound].ProductNotExpiredQuantity -= orderItem.Quantity;
                    setUpOrderItemsListView();
                }
                undoButton.Visible = true;
                MessageBox.Show("Product added to order: \nID :" + productIDTextBox.Text + "\n" + productDescriptionTextBox.Text + "\nQuantity: " + productQuantityTextBox.Text);
            }
            else
            {
                // Undo all of the events that occcured as a result of adding the product
                totalSoFar -= amount;
                remainingCustomerCreditAmount += amount;
                if (remainingCustomerCreditAmount < totalSoFar)
                {
                    MessageBox.Show("Customer Credit Status will be NEGATIVE.\nInform customer of remaining credit amount." +
                        "\nCheckout is advised.");
                }
                else
                {
                    MessageBox.Show("Quantity requested is greater than the quantity currently in stock.");
                }
            }
            
            /* PopulateObject();
             customerController.DataMaintenance(product, DB.DBOperation.Add);
             customerController.FinalizeChanges(customer);
             MessageBox.Show("Submitted to the Database!");*/
            ;
            ClearAll();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            // Undoing the addition of an orderitem to the order

            // Increase the customer's credit amount 
            remainingCustomerCreditAmount += amount;

            //The total so far will dcrease
            totalSoFar -= amount;

            // Decreasing the quantity in the database
            productFound = FindIndex(orderItem); //We  have found the product in the databse
            if (productFound == -1)
            {
                MessageBox.Show("Something went wrong.");
            }
            else
            {
                products[productFound].ProductNotExpiredQuantity += orderItem.Quantity;
                setUpOrderItemsListView();
            }

            customerCreditAmountTextBox.Text = remainingCustomerCreditAmount.ToString();
            totalSoFarTextBox.Text = totalSoFar.ToString();
            MessageBox.Show("Product removed from order: \nID :" + orderItem.ID + "\n" + orderItem.Description + "\nQuantity: " + orderItem.Quantity.ToString());

            // We want to delete the most recent product from the orderitems collection 
            orderItems.Remove(orderItem);  //The order item field will be set to the most recent order item

            undoButton.Visible = false; 
        }


        public int FindIndex(OrderItem orderItem)
        {
            //this.orderItem = orderItem;
            int counter = 0;
            bool found = false;
            found = (orderItem.ID == products[counter].ProductID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < products.Count - 1)
            {
                counter += 1;
                found = (orderItem.ID == products[counter].ProductID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }

            
        }

        private void generatePickingListButton_Click(object sender, EventArgs e)
        {
            if(pickingListForm == null)
            {
                CreateNewPickingListForm();
            }
            if(pickingListForm.listFormClosed)
            {
                CreateNewPickingListForm();
            }
            pickingListForm.Show();
        }

        public void CreateNewPickingListForm()
        {
            pickingListForm = new PickingListForm(customerController, orderItems, totalSoFar);
            pickingListForm.StartPosition = FormStartPosition.Manual;
        }
    }
}
