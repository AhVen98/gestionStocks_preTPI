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
    public partial class frmChoicePDF : Form
    {
        public frmChoicePDF()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnRentedPDF_Click(object sender, EventArgs e)
        {
            Controller.MethodToCall("pdf_rented");
        }

        private void btnAvailablePDF_Click(object sender, EventArgs e)
        {
            Controller.MethodToCall("pdf_available");
        }
    }
}
