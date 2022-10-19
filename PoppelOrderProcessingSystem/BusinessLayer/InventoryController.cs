using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderProcessingSystem.DatabaseLayer;

namespace PoppelOrderProcessingSystem.BusinessLayer
{
    public class InventoryController
    {
        #region Data Members
        private InventoryDB inventoryDB;//make reference

        // This will be for specically displaying the inventory so we can choose the products 
        private Collection<Product> products;
        private Product product;
       // private OrderItem orderItem;

        
        #endregion

        #region Properties
        public Collection<Product> Products
        {
            get
            {
                return products;
            }
        }
        #endregion

        #region Constructor
        public InventoryController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            inventoryDB = new InventoryDB();
            products = inventoryDB.AllProducts;
        }
        #endregion

        #region Database Communication
        public void DataMaintenance(Product product, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            inventoryDB.DataSetChange(product, operation);//calling method to do the insert
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    products.Add(product);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(product);
                    products[index] = product;  // replace employee at this index with the updated employee
                                                  //  employees.Add(anEmp);
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(product);  // find the index of the specific employee in collection
                    products.RemoveAt(index);  // remove that employee form the collection
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Product product)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return inventoryDB.UpdateDataSource(product);

        }
        #endregion

        #region Search Methods
        public Product Find(string ID)
        {
            int index = 0;
            bool found = (products[index].ProductID == ID);  //check if it is the first record
            int count = products.Count;
            while (!(found) && (index < products.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (products[index].ProductID == ID);   // this will be TRUE if found
            }
            return products[index];  // this is the one!  
        }

        public int FindIndex(Product product)
        {
            int counter = 0;
            bool found = false;
            found = (product.ProductID == products[counter].ProductID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < products.Count - 1)
            {
                counter += 1;
                found = (product.ProductID == products[counter].ProductID);
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

        
        
#endregion

    }
}
