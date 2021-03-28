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
    public partial class frmReturnObject : Form
    {
        public frmReturnObject()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int rentNumber;
            int objectID;
            DateTime returnDate = DateTime.Today;
            bool res = int.TryParse(txtRentNumber.Text, out rentNumber);
            RequestDB req = new RequestDB();
            objectID = req.ReqGetObjectNumber(rentNumber);
            Employees.ReturnObject(objectID);
        }
    }
}
