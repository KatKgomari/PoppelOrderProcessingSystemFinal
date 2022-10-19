using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderProcessingSystem.BusinessLayer
{
    public class OrderItem
    {
        #region Data Members 
        private String id;
        private string name;
        private string description;
        private decimal price;
        private int quantity;
        #endregion

        #region Constructor
        public OrderItem()
        {

        }
        #endregion

        #region Property Methods
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        #endregion
    }
}
