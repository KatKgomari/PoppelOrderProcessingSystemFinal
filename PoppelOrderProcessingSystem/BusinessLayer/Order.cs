using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderProcessingSystem.BusinessLayer
{
    public class Order
    {
        #region Info
        /* An Order will have a collection of OrderItems
         * customer ID
         */
        #endregion

        #region Data Members
        private int orderID;
        private DateTime orderDate;
        private DateTime orderShipmentDate;
        private DateTime orderDeliveryDate;
        private int customerID;
        private Collection<OrderItem> items;
        private decimal orderTotalPrice;
        private OrderStatus orderStatus;
        private string deliveryNote;
        #endregion

        public enum OrderStatus
        {
            NewOrder = 0,
            onHold = 1,
            Shipped = 2,
            Delivered = 3
        }

        #region Constructor 
        public Order()
        {
            // Maybe initialize the collection here 
        }
        #endregion

        #region Property Methods 
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public Collection<OrderItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        public decimal OrderTotalPrice
        {
            get { return orderTotalPrice; }
            set { orderTotalPrice = value; }
        }
        public string DeliveryNote
        {
            get { return deliveryNote; }
            set { deliveryNote = value; }
        }
        
        #endregion

    }
}
