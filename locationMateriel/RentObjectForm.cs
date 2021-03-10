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
    public partial class frmRentObject : Form
    {
        public frmRentObject()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.MethodToCall("cancel");
        }

        private void rbtnNewClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNewClient.Checked == true)
            {
                txtClientID.Visible = false;
                txtClientID.Enabled = false;
                txtClientFirstName.Visible = true;
                txtClientFirstName.Enabled = true;
                txtClientLastName.Visible = true;
                txtClientLastName.Enabled = true;
                txtBirthDate.Visible = true;
                txtBirthDate.Enabled = true;
                txtMail.Visible = true;
                txtMail.Enabled = true;
                lblBirth.Visible = true;
                lblFirstName.Visible = true;
                lblLastName.Visible = true;
                lblMail.Visible = true;
                lblClientNumber.Visible = false;
            }
            else
            {
                txtClientID.Visible = true;
                txtClientID.Enabled = true;
                txtClientFirstName.Visible = false;
                txtClientFirstName.Enabled = false;
                txtClientLastName.Visible = false;
                txtClientLastName.Enabled = false;
                txtBirthDate.Visible = false;
                txtBirthDate.Enabled = false;
                txtMail.Visible = false;
                txtMail.Enabled = false;
                lblBirth.Visible = false;
                lblFirstName.Visible = false;
                lblLastName.Visible = false;
                lblMail.Visible = false;
                lblClientNumber.Visible = true;
            }
        }

        private void rbtnExistingClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnExistingClient.Checked == false)
            {
                txtClientID.Visible = false;
                txtClientID.Enabled = false;
                txtClientFirstName.Visible = true;
                txtClientFirstName.Enabled = true;
                txtClientLastName.Visible = true;
                txtClientLastName.Enabled = true;
                txtBirthDate.Visible = true;
                txtBirthDate.Enabled = true;
                txtMail.Visible = true;
                txtMail.Enabled = true;
                lblBirth.Visible = true;
                lblFirstName.Visible = true;
                lblLastName.Visible = true;
                lblMail.Visible = true;
                lblClientNumber.Visible = false;
            }
            else
            {
                txtClientID.Visible = true;
                txtClientID.Enabled = true;
                txtClientFirstName.Visible = false;
                txtClientFirstName.Enabled = false;
                txtClientLastName.Visible = false;
                txtClientLastName.Enabled = false;
                txtBirthDate.Visible = false;
                txtBirthDate.Enabled = false;
                txtMail.Visible = false;
                txtMail.Enabled = false;
                lblBirth.Visible = false;
                lblFirstName.Visible = false;
                lblLastName.Visible = false;
                lblMail.Visible = false;
                lblClientNumber.Visible = true;
            }
        }
    }
}
