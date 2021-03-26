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
    public partial class frmAddObject : Form
    {
        public frmAddObject()
        {
            InitializeComponent();
        }

        private void AddObjectForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int value = -1;
            if (int.TryParse(txtEmployeeNumber.Text, out value))
            {
                //Controller.MethodToCall("add", value, txtType.Text, txtName.Text, txtDescription.Text, txtRemark.Text);
                string name = txtName.Text;
                string type = txtType.Text;
                string description = txtDescription.Text;
                int employeeNumber = 0;
                bool res = int.TryParse(txtEmployeeNumber.Text, out employeeNumber);
                string remark = txtRemark.Text;
                Employees.AddObject(name, type, description, employeeNumber, remark);
                ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Problème là !!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
