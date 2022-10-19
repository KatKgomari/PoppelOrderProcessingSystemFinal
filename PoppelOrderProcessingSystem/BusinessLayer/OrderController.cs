using PoppelOrderProcessingSystem.DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderProcessingSystem.BusinessLayer
{
    public class OrderController
    {
        #region Data Members
        private OrderDB orderDB;//make reference 
        private Collection<Order> orders;
        private Order order;
        #endregion
    }
}
