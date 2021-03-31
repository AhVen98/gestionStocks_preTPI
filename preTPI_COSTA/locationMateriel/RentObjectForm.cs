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
        string selectedDate = DateTime.Today.ToShortDateString();

        public frmRentObject()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
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

        private void btnRent_Click(object sender, EventArgs e)
        {
            int locatorNumber;
            int employeeNumber;
            string name = txtName.Text;
            bool res = int.TryParse(txtClientID.Text, out locatorNumber);
            bool res2 = int.TryParse(txtClientID.Text, out employeeNumber);
            DateTime returnDate = Convert.ToDateTime(selectedDate);
            RequestDB req = new RequestDB();
            int objectNumber = req.ReqGetIDFromName(name);
            string state = req.ReqCheckState(objectNumber);
            if(state == "disponible")
            {
                Employees.RentObject(objectNumber, locatorNumber, employeeNumber, returnDate);
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("L'objet est déjà loué !");
                ActiveForm.Close();
            }
        }

        private void calExpectedReturn_DateChanged(object sender, DateRangeEventArgs e)
        {
            selectedDate = calExpectedReturn.SelectionRange.Start.ToShortDateString();
        }
    }
}
