using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderProcessingSystem.DatabaseLayer;

namespace PoppelOrderProcessingSystem.BusinessLayer
{
    public class CustomerController
    {
        #region Data Members
        private CustomerDB customerDB;//make reference 
        private Collection<Customer> customers;
        private Customer customer;
        #endregion

        #region Properties
        public Collection<Customer> Customers
        {
            get
            {
                return customers;
            }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        #endregion

        #region Constructor
        public CustomerController()
        {
            //***instantiate the EmployeeDB object to communicate with the database
            customerDB = new CustomerDB();
            customers = customerDB.AllCustomers;
        }
        #endregion

        #region Database Communication
        public void DataMaintenance(Customer customer, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            customerDB.DataSetChange(customer, operation);//calling method to do the insert
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the employee to the Collection
                    customers.Add(customer);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(customer);
                    customers[index] = customer;  // replace employee at this index with the updated employee
                                               //  employees.Add(anEmp);
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(customer);  // find the index of the specific employee in collection
                    customers.RemoveAt(index);  // remove that employee form the collection
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Customer customer)
        {
            //***call the EmployeeDB method that will commit the changes to the database
            return customerDB.UpdateDataSource(customer);

        }
        #endregion

        #region Search Methods
        public Customer Find(int ID)
        {
            int index = 0;
            bool found = (customers[index].CustomerID == ID);  //check if it is the first record
            int count = customers.Count;
            while (!(found) && (index < customers.Count - 1))  //if not "this" record and you are not at the end of the list 
            {
                index = index + 1;
                found = (customers[index].CustomerID == ID);   // this will be TRUE if found
            }
            return customers[index];  // this is the one!  
        }

        public int FindIndex(Customer customer)
        {
            int counter = 0;
            bool found = false;
            found = (customer.CustomerID == customers[counter].CustomerID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < customers.Count - 1)
            {
                counter += 1;
                found = (customer.CustomerID == customers[counter].CustomerID);
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
