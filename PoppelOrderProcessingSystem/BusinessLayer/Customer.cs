using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelOrderProcessingSystem.BusinessLayer
{
    public class Customer
    {
        #region Fields 
        private int customerID;
        private string customerName;
        private string customerEmail;
        private string customerPhone;
        private string customerAddress;
        private decimal customerAccountBalance;
        private decimal customerCreditAmount;
        private string customerCreditStatus;
        #endregion

        #region Constructor
        public Customer()
        {
            // Don't know what to put here yet
        }
        #endregion

        #region Property Methods
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string CustomerEmail
        {
            get { return customerEmail; }
            set { customerEmail = value; }
        }
        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        public string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        public decimal CustomerAccountBalance
        {
            get { return customerAccountBalance; }
            set { customerAccountBalance = value; }
        }
        public decimal CustomerCreditAmount
        {
            get { return customerCreditAmount; }
            set { customerCreditAmount = value; }
        }
        public string CustomersCreditStatus
        {
            get { return customerCreditStatus; }
            set { customerCreditStatus = value; }
        }
        #endregion
    }
}
