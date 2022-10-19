using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelOrderProcessingSystem.PresentationLayer
{
    public partial class Company : Form
    {
        public bool listFormClosed;
        public Company()
        {
            InitializeComponent();
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {

        }

        private void Company_Load(object sender, EventArgs e)
        {

        }

        private void Company_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }
    }
}
