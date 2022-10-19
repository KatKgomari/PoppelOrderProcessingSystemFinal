using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelOrderProcessingSystem.BusinessLayer;

namespace PoppelOrderProcessingSystem.DatabaseLayer
{
    public class CustomerDB : DB
    {
        #region Data Members
        private string table = "Customer";
        private string sqlLocal = "SELECT * FROM Customer";
        private Collection<Customer> customers;
        #endregion

        #region Property Method: Collection
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqlLocal, table);
            Add2Collection();

        }
        #endregion

        #region Utility Methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection()
        {
            //Declare references to a myRow object and an Employee object
            DataRow myRow = null;
            Customer customer;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Customer object
                    customer = new Customer();
                    //Obtain each customer attribute from the specific field in the row in the table
                    customer.CustomerID = Convert.ToInt16(myRow["CustomerID"]);
                  
                    //Do the same for all other attributes
                    customer.CustomerName = Convert.ToString(myRow["Name"]).TrimEnd();
                    customer.CustomerEmail = Convert.ToString(myRow["Email"]).TrimEnd();
                    customer.CustomerPhone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    customer.CustomerAddress = Convert.ToString(myRow["Address"]).TrimEnd();
                    customer.CustomerAccountBalance = Convert.ToDecimal(myRow["Account_Balance"]);
                    customer.CustomerCreditAmount = Convert.ToDecimal(myRow["Credit_Amount"]);
                    customer.CustomersCreditStatus = Convert.ToString(myRow["Credit_Status"]).TrimEnd();

                    customers.Add(customer);
                }
            }
        }

        private void FillRow(DataRow aRow, Customer customer, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["CustomerID"] = customer.CustomerID;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Name"] = customer.CustomerName;
            aRow["Email"] = customer.CustomerEmail;
            aRow["Phone"] = customer.CustomerPhone;
            aRow["Address"] = customer.CustomerAddress;
            aRow["Account_Balance"] = customer.CustomerAccountBalance;
            aRow["Credit_Amount"] = customer.CustomerCreditAmount;
            aRow["Credit_Status"] = customer.CustomersCreditStatus;

        }

        private int FindRow(Customer customer)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it 
                    //is automatically known to the compiler when used as below
                    if (customer.CustomerID == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["CustomerID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Customer customer)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.             
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@CustomerID", SqlDbType.Int, 16, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 50, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Account_Balance", SqlDbType.Money, 20, "Account_Balance");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Credit_Amount", SqlDbType.Money, 20, "Credit_Amount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Credit_Status", SqlDbType.NVarChar, 50, "Credit_Status");
            daMain.InsertCommand.Parameters.Add(param);
            //***https://msdn.microsoft.com/en-za/library/ms179882.aspx
        }

        private void Build_UPDATE_Parameters(Customer customer)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 50, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 50, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Account_Balance", SqlDbType.Money, 20, "Account_Balance");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Credit_Amount", SqlDbType.Money, 20, "Credit_Amount");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Credit_Status", SqlDbType.NVarChar, 50, "Credit_Status");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.Int, 15, "CustomerID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@CustomerID", SqlDbType.Int, 15, "CustomerID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Customer customer)
        {
            //Create the command that must be used to insert values into the table..
            
            daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustomerID, Name, Email, Phone, Address, Account_Balance, Credit_Amount, Credit_Status) VALUES (@CustomerID, @Name, @Email, @Phone, @Address, @Account_Balance, @Credit_Amount, @Credit_Status)", cnMain);
            //daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustomerID, Name, Email, Phone, Address, Account_Balance, Credit_Amount, Credit_Status) VALUES (" + customer.CustomerID.ToString() + ", " + customer.CustomerName + ", " + customer.CustomerEmail + ", " +customer.CustomerPhone+ ", " +customer.CustomerAddress+ ", " +customer.CustomerAccountBalance+ ", " + customer.CustomerCreditAmount+ ", " +customer.CustomersCreditStatus + " )", cnMain);
            Build_INSERT_Parameters(customer);
        }

        private void Create_UPDATE_Command(Customer customer)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Customer SET Name =@Name, Email =@Email, Phone =@Phone, Address =@Address, Account_Balance =@Account_Balance, Credit_Amount =@Credit_Amount, Credit_Status =@Credit_Status " + "WHERE CustomerID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(customer);
        }

        private string Create_DELETE_Command(Customer customer)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @CustomerID", cnMain);
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }
        public bool UpdateDataSource(Customer customer)
        {
            bool success = true;
            Create_INSERT_Command(customer);
            //Create_UPDATE_Command(customer);
            //Create_DELETE_Command(customer);
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Customer customer, DB.DBOperation operation)
        {
            DataRow aRow = null;
            
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, customer, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:

                    aRow = dsMain.Tables[table].Rows[FindRow(customer)];
                    FillRow(aRow, customer, operation);


                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(customer)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion
    }


}


