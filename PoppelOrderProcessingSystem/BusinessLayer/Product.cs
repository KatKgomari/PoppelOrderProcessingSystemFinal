using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelOrderProcessingSystem.BusinessLayer
{
    public class Product
    {
        #region Data Members
        private string productID;
        private string productName;
        private string productDescription;
        private decimal productPrice;
        private int productTotalQuantity;
        private string productSupplier;
        private int productExpiredQuantity;
        private int productNotExpiredQuantity;
        private string productCategory;

        #endregion

        #region Contructor
        public Product()
        {

        }
        #endregion

        #region Property Methods
        public string ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string ProductDescription
        {
            get { return productDescription; }
            set { productDescription = value; }
        }
        public decimal ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
        public int ProductTotalQuantity
        {
            get { return productTotalQuantity; }
            set { productTotalQuantity = value; }
        }
        public string ProductSupplier
        {
            get { return productSupplier; }
            set { productSupplier = value; }
        }
        public int ProductExpiredQuantity
        {
            get { return productExpiredQuantity; }
            set { productExpiredQuantity = value; }
        }
        public int ProductNotExpiredQuantity
        {
            get { return productNotExpiredQuantity; }
            set { productNotExpiredQuantity = value; }
        }
        #endregion 
        public String ProductCategory
        {
            get { return productCategory; }
            set { productCategory = value; }
        }
    }
}
