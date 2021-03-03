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

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            Controller.MethodToCall("add");
        }
    }
}
