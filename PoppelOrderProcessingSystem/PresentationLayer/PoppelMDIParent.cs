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

namespace PoppelOrderProcessingSystem.PresentationLayer
{
    public partial class PoppelMDIParent : Form
    {
        #region Data Members
        private int childFormNumber = 0;
        private CustomerController customerController;
        private CustomerForm customerForm;
        private AddCustomerForm addCustomerForm;
        private Help helpForm;
        private Company companyForm;
        private InventoryReport inventoryReport;
        private InventoryController inventoryController;
        #endregion

        public PoppelMDIParent()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            customerController = new CustomerController();  
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        #region Child Forms
        public void CreateNewCustomerForm()
        {
            customerForm = new CustomerForm(customerController);
            customerForm.MdiParent = this;//Setting the MDI Parent
            customerForm.StartPosition = FormStartPosition.Manual;
        }

        public void CreateNewAddCustomerForm()
        {
            addCustomerForm = new AddCustomerForm(customerController);
            addCustomerForm.MdiParent = this;//Setting the MDI Parent
            addCustomerForm.StartPosition = FormStartPosition.Manual;
        }

        public void CreateNewHelpForm()
        {
            helpForm = new Help();
            helpForm.MdiParent = this;
            helpForm.StartPosition = FormStartPosition.Manual;
        }
        public void CreateNewCompanyForm()
        {
            companyForm = new Company();
            companyForm.MdiParent = this;
            companyForm.StartPosition = FormStartPosition.Manual;
        }

        public void CreateNewInventoryReport()
        {
            inventoryController = new InventoryController();
            inventoryReport = new InventoryReport(inventoryController);
            inventoryReport.MdiParent = this;
            inventoryReport.StartPosition = FormStartPosition.Manual;
        }

        #endregion

        private void makeOrderButton_Click(object sender, EventArgs e)
        {
            if (customerForm == null)
            {
                CreateNewCustomerForm();
            }
            if (customerForm.listFormClosed)
            {
                CreateNewCustomerForm();
            }
            customerForm.setUpCustomerListView();
            customerForm.Show();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (addCustomerForm == null)
            {
                CreateNewAddCustomerForm();
            }
            if (addCustomerForm.listFormClosed)
            {
                CreateNewAddCustomerForm();
            }
            addCustomerForm.Show();
        }















        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void dataSetForCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (helpForm == null)
            {
                CreateNewHelpForm();
            }
            if (helpForm.listFormClosed)
            {
                CreateNewHelpForm();
            }
            helpForm.Show();
        }

       

       

        private void PoppelMDIParent_Load(object sender, EventArgs e)
        {

        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if (companyForm == null)
            {
                CreateNewCompanyForm();
            }
            if (companyForm.listFormClosed)
            {
                CreateNewCompanyForm();
            }
            companyForm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            if (inventoryReport == null)
            {
                CreateNewInventoryReport();
            }
            if (inventoryReport.listFormClosed)
            {
                CreateNewInventoryReport();
            }
            inventoryReport.Show();
        }
    }
}
