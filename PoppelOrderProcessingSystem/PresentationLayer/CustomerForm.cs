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
using PoppelOrderProcessingSystem.BusinessLayer;
using PoppelOrderProcessingSystem.DatabaseLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PoppelOrderProcessingSystem.PresentationLayer
{
    public partial class CustomerForm : Form
    {
        #region Variables
        public bool listFormClosed;
        private Collection<Customer> customers;
        private CustomerController customerController;
        private FormStates state;
        private Customer customer;
        private OrderForm orderForm;
        private InventoryController inventoryController;
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
        public CustomerForm(CustomerController customerController)
        {

            InitializeComponent();
            this.customerController = customerController;
            this.WindowState = FormWindowState.Normal;
            this.Load += CustomerForm_Load;
            this.Activated += CustomerForm_Activated;
            // this.FormClosed += CustomermClosed;
            state = FormStates.View;
        }
        #endregion

        #region Form Events
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customerListView.View = View.Details;
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
        private void CustomerForm_Activated(object sender, EventArgs e)
        {

            customerListView.View = View.Details;
            setUpCustomerListView();
            ShowAll(false);
        }
        #endregion

        #region The List View
        public void setUpCustomerListView()
        {

            ListViewItem customerDetails; //Declare variables
            Customer customer;
            //Clear current List View Control
            customerListView.Clear();
            //Set Up Columns of List View

            customerListView.Columns.Insert(0, "CustomerID", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            customerListView.Columns.Insert(2, "Email", 150, HorizontalAlignment.Left);
            customerListView.Columns.Insert(3, "Phone", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(4, "Address", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(5, "Account_Balance", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(6, "Credit_Amount", 100, HorizontalAlignment.Left);
            customerListView.Columns.Insert(7, "Credit_Status", 100, HorizontalAlignment.Left);
            customers = customerController.Customers;                   //customers collection will be filled
            // Get all the employees from the EmployeeController object 
            // (use the property) and assign to a local employees collection reference
            

            //Add customer details to each ListView item 
            foreach (Customer cust in customers)
            {
                customerDetails = new ListViewItem();
                customerDetails.Text = cust.CustomerID.ToString();
                customerDetails.SubItems.Add(cust.CustomerName);
                customerDetails.SubItems.Add(cust.CustomerEmail);
                customerDetails.SubItems.Add(cust.CustomerPhone);
                customerDetails.SubItems.Add(cust.CustomerAddress);
                customerDetails.SubItems.Add(cust.CustomerAccountBalance.ToString());
                customerDetails.SubItems.Add(cust.CustomerCreditAmount.ToString());
                customerDetails.SubItems.Add(cust.CustomersCreditStatus);

                customerListView.Items.Add(customerDetails);
            }
            customerListView.Refresh();
            customerListView.GridLines = true;
        }
        #endregion

        #region Utility Methods
        private void ShowAll(bool value)
        {
            
            idLabel.Visible = value;
            nameLabel.Visible = value;
            emailLabel.Visible = value;
            phoneLabel.Visible = value;
            adrLabel.Visible = value; // address label
            accBLabel.Visible = value; // account balance
            crdtAmntLabel.Visible = value; // credit amount
            crdtStatLabel.Visible = value; // credits status
            
            idTextBox.Visible = value;
            nameTextBox.Visible = value;
            emailTextBox.Visible = value;
            phoneTextBox.Visible = value;
            addressTextBox.Visible = value;
            AccBalTextBox.Visible = value;
            crdtAmTextBox.Visible = value;
            crdtStatTextBox.Visible = value;
            // When doing the buttons, come back here
            //If the form state is View, the Submit button and the Edit button should not be visible
            if (state == FormStates.Delete)
            {
                //cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                //cancelButton.Visible = value;
                submitButton.Visible = value;
            }
            deleteButton.Visible = value;
            editButton.Visible = value;

        }

        private void EnableEntries(bool value)
        {
            if ((state == FormStates.Edit) && value)
            {
                idTextBox.Enabled = !value;
            }
            else
            {
                idTextBox.Enabled = value;
            }
            nameTextBox.Enabled = value;
            emailTextBox.Enabled = value;
            phoneTextBox.Enabled = value;
            addressTextBox.Enabled = value;
            AccBalTextBox.Enabled = value;
            crdtAmTextBox.Enabled = value;
            crdtStatTextBox.Enabled = value;
            
            if (state == FormStates.Delete)
            {
                //cancelButton.Visible = !value;
                submitButton.Visible = !value;
            }
            else
            {
                //cancelButton.Visible = value;
                submitButton.Visible = value;
            }
        }

        private void ClearAll()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            emailTextBox.Text = ""; 
            phoneTextBox.Text = "";
            addressTextBox.Text = "";
            AccBalTextBox.Text = "";
            crdtAmTextBox.Text = "";
            crdtStatTextBox.Text = "";
        }

        private void PopulateTextBoxes(Customer customer)  ////*****************8
        {
            
            idTextBox.Text = customer.CustomerID.ToString();
            nameTextBox.Text = customer.CustomerName;
            emailTextBox.Text = customer.CustomerEmail;
            phoneTextBox.Text = customer.CustomerPhone; 
            addressTextBox.Text = customer.CustomerAddress;
            AccBalTextBox.Text = customer.CustomerAccountBalance.ToString();
            crdtAmTextBox.Text = customer.CustomerCreditAmount.ToString();
            crdtStatTextBox.Text = customer.CustomersCreditStatus;
            }

        private void PopulateObject( )
        {

            customer = new Customer();
            customer.CustomerID = int.Parse(idTextBox.Text);
            customer.CustomerName = nameTextBox.Text;
            customer.CustomerEmail = emailTextBox.Text;
            customer.CustomerPhone = phoneTextBox.Text;
            customer.CustomerAddress = addressTextBox.Text;
            customer.CustomerAccountBalance = decimal.Parse(AccBalTextBox.Text);
            customer.CustomerCreditAmount = decimal.Parse(crdtAmTextBox.Text);
            customer.CustomersCreditStatus = crdtStatTextBox.Text;
            customerController.Customer = customer;
        }

        #endregion

        private void customerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAll(true);
            state = FormStates.View;
            EnableEntries(false);
            if (customerListView.SelectedItems.Count > 0)   // if you selected an item 
            {
                customer = customerController.Find(int.Parse(customerListView.SelectedItems[0].Text));  //selected employee becoms current employee
                PopulateTextBoxes(customer);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //set the form state to Edit
            state = FormStates.Edit;
            EnableEntries(true);//call the EnableEntities method  
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            if (state == FormStates.Edit)
            {
                customerController.DataMaintenance(customer, DB.DBOperation.Edit);

            }
            else//delete code
            {
                customerController.DataMaintenance(customer, DB.DBOperation.Delete);
            }
            customerController.FinalizeChanges(customer);
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpCustomerListView();   //refresh List View
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //set the form state to Delete
            state = FormStates.Delete;
            editButton.Visible = false;
            EnableEntries(false);
            MessageBox.Show("This record is about to be deleted");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ClearAll();
            state = FormStates.View;
            ShowAll(false);
            setUpCustomerListView();   //refresh List View
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            // This will lead us to where we will be able to select Order Items
            PopulateObject();
            
            if (orderForm == null)
            {
                CreateNewOrderForm();
            }
            if (orderForm.listFormClosed)
            {
                CreateNewOrderForm();
            }
            //customerForm.setUpCustomerListView();
            orderForm.Show();

        }

        public void CreateNewOrderForm()
        {
            inventoryController = new InventoryController();
            orderForm = new OrderForm(customerController, inventoryController);
            orderForm.StartPosition = FormStartPosition.Manual;
        }

    }
}

