using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locationMateriel
{
    public partial class locMateriel : Form
    {
        public locMateriel()
        {
            InitializeComponent();
        }

        private void locMateriel_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            frmAddObject frmAdd = new frmAddObject();
            frmAdd.Show();
        }

        private void btnRentObject_Click(object sender, EventArgs e)
        {
            //frmRentObject frmRent = new frmRentObject();
            //frmRent.Show();
            Controller.MethodToCall("rent");
        }

        private void btnReturnObject_Click(object sender, EventArgs e)
        {
            //frmReturnObject frmReturn = new frmReturnObject();
            //frmReturn.Show();
            Controller.MethodToCall("return");
        }

        private void btnReturnDateOver_Click(object sender, EventArgs e)
        {
            Controller.MethodToCall("delay");
        }

        private void btnLocationHistory_Click(object sender, EventArgs e)
        {
            Controller.MethodToCall("logs");
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            Controller.MethodToCall("generate");
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            if (txtResearch.Text == "")
            {
                Controller.MethodToCall("default");
            }
            else
            {
                Controller.MethodToCall("research");
            }
        }
    }
}
