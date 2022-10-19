using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelOrderProcessingSystem.BusinessLayer;
using static PoppelOrderProcessingSystem.PresentationLayer.CustomerForm;
using static System.Windows.Forms.AxHost;
using PoppelOrderProcessingSystem.DatabaseLayer;

namespace PoppelOrderProcessingSystem.PresentationLayer
{
    public partial class AddCustomerForm : Form
    {
        #region Data Members
        public bool listFormClosed;
        private Customer customer;
        private CustomerController customerController; 
        
        #endregion

        #region Utility Methods
        public AddCustomerForm(CustomerController customerController)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.customerController = customerController;
        }
        #endregion

        #region Utility methods

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

        private void PopulateObject()
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
            
        }

        #endregion


        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            ShowAll(true);
        }

        private void CustomerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            PopulateObject();
            
            customerController.DataMaintenance(customer, DB.DBOperation.Add);
            customerController.FinalizeChanges(customer);
            MessageBox.Show("Submitted to the Database!");
            ClearAll();
            //ShowAll(true);
        }

        private void AddCustomerForm_Activated(object sender, EventArgs e)
        {
            ShowAll(true);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            listFormClosed = true;
        }

        private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
    }
}
