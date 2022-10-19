using PoppelOrderProcessingSystem.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderProcessingSystem.DatabaseLayer
{
    public class InventoryDB:DB
    {
        #region Data Members
        private string table = "Inventory";
        private string sqlLocal = "SELECT * FROM Inventory";
        private Collection<Product> products;
        #endregion

        #region Property Method: Collection
        public Collection<Product> AllProducts
        {
            get
            {
                return products;
            }
        }
        #endregion

        #region Constructor
        public InventoryDB() : base()
        {
            products = new Collection<Product>();
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
            Product product;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Customer object
                    product = new Product();
                    //Obtain each product attribute from the specific field in the row in the table
                    product.ProductID = Convert.ToString(myRow["ProductID"]).TrimEnd();
                    product.ProductName = Convert.ToString(myRow["Name"]).TrimEnd();
                    product.ProductDescription  = Convert.ToString(myRow["Description"]).TrimEnd();
                    product.ProductPrice = Convert.ToDecimal(myRow["Price"]);
                    product.ProductNotExpiredQuantity = Convert.ToInt16(myRow["Fresh_Quantity"]);
                    product.ProductExpiredQuantity = Convert.ToInt16(myRow["Quantity_Expired"]);
                    product.ProductTotalQuantity = Convert.ToInt16(myRow["Total_Quantity"]);
                    product.ProductSupplier = Convert.ToString(myRow["Category"]).TrimEnd();
                    product.ProductSupplier = Convert.ToString(myRow["Supplier"]).TrimEnd();
                    
                    products.Add(product);
                }
            }
        }

        private void FillRow(DataRow aRow, Product product, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["ProductID"] = product.ProductID;
            }
            aRow["Name"] = product.ProductName;
            aRow["Description"] = product.ProductDescription;
            aRow["Price"] = product.ProductPrice;
            aRow["Fresh_Quantity"] = product.ProductNotExpiredQuantity;
            aRow["Quantity_Expired"] = product.ProductExpiredQuantity;
            aRow["Total_Quantity"] = product.ProductTotalQuantity;
            aRow["Category"] = product.ProductCategory;
            aRow["Supplier"] = product.ProductSupplier;
            

        }

        private int FindRow(Product product)
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
                    if (product.ProductID == dsMain.Tables[table].Rows[rowIndex]["ProductID"].ToString())
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
        private void Build_INSERT_Parameters(Product product)
        {
            //Create Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.             
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ProductID", SqlDbType.NVarChar, 50, "ProductID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Description", SqlDbType.NVarChar, 50, "Description");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Money, 20, "Price");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Total_Quantity", SqlDbType.Int, 50, "Total_Quantity");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Supplier", SqlDbType.NVarChar, 50, "Supplier");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Quantity_Expired", SqlDbType.Int, 50, "Quantity_Expired");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters(Product product)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);
            
            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //Do for all fields other than ID and EMPID as for Insert 
            param = new SqlParameter("@Description", SqlDbType.NVarChar, 50, "Description");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Price", SqlDbType.Money, 20, "Price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Total_Quantity", SqlDbType.Int, 50, "Total_Quantity");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Supplier", SqlDbType.NVarChar, 50, "Supplier");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Quantity_Expired", SqlDbType.Int, 50, "Quantity_Expired");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the ID of record that needs to change with the original ID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.Int, 15, "ProductID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@ProductID", SqlDbType.Int, 15, "ProductID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Product product)
        {
            //Create the command that must be used to insert values into the table..

            daMain.InsertCommand = new SqlCommand("INSERT into Inventory(ProductID, Name, Description, Price, Total_Quantity, Supplier, Quantity_Expired) VALUES (@ProductID, @Name, @Description, @Price, @Total_Quantity, @Supplier, @Quantity_Expired)", cnMain);
            //daMain.InsertCommand = new SqlCommand("INSERT into Customer (CustomerID, Name, Email, Phone, Address, Account_Balance, Credit_Amount, Credit_Status) VALUES (" + customer.CustomerID.ToString() + ", " + customer.CustomerName + ", " + customer.CustomerEmail + ", " +customer.CustomerPhone+ ", " +customer.CustomerAddress+ ", " +customer.CustomerAccountBalance+ ", " + customer.CustomerCreditAmount+ ", " +customer.CustomersCreditStatus + " )", cnMain);
            Build_INSERT_Parameters(product);
        }

        private void Create_UPDATE_Command(Product product)
        {
            //Create the command that must be used to insert values into one of the three tables
            //Assumption is that the ID and EMPID cannot be changed
            daMain.UpdateCommand = new SqlCommand("UPDATE Inventory SET Name =@Name, Description =@Description, Price =@Price, Total_Quantity=Total_Quantity, Supplier =@Supplier, Quantity_Expired =@Quantity_Expired " + "WHERE ProductID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(product);
        }

        private string Create_DELETE_Command(Product product)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Inventory WHERE ProductID = @ProductID", cnMain);
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
        public bool UpdateDataSource(Product product)
        {
            bool success = true;
            Create_INSERT_Command(product);
            //Create_UPDATE_Command(customer);
            //Create_DELETE_Command(customer);
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Product product, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, product, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:

                    aRow = dsMain.Tables[table].Rows[FindRow(product)];
                    FillRow(aRow, product, operation);


                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(product)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion
    }
}
