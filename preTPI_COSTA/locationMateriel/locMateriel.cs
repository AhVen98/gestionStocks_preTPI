using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using locationMateriel;

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
            List<string> lstTab = new List<string>();

            dgvGlobal.ColumnCount = 6;
            //option for display
            dgvGlobal.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvGlobal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvGlobal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvGlobal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvGlobal.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvGlobal.GridColor = Color.Black;

            //columns name
            dgvGlobal.Columns[0].Name = "Nom";
            dgvGlobal.Columns[1].Name = "Type";
            dgvGlobal.Columns[2].Name = "État";
            dgvGlobal.Columns[3].Name = "Locataire";
            dgvGlobal.Columns[4].Name = "Date de retour limite";
            dgvGlobal.Columns[5].Name = "Id";
            dgvGlobal.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

            List<Objects> lstObj = Objects.Load();
            foreach (Objects obj in lstObj)
            {
                string[] row = { obj.Name, obj.Type, obj.State, obj.Renter, obj.ExpectedReturn.ToString(), obj.ID.ToString()};
                dgvGlobal.Rows.Add(row);
            }
        }

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            frmAddObject frmAdd = new frmAddObject();
            frmAdd.Show();
        }

        private void btnRentObject_Click(object sender, EventArgs e)
        {
            frmRentObject frmRent = new frmRentObject();
            frmRent.Show();
        }

        private void btnReturnObject_Click(object sender, EventArgs e)
        {
            frmReturnObject frmReturn = new frmReturnObject();
            frmReturn.Show();
        }

        private void btnReturnDateOver_Click(object sender, EventArgs e)
        {
            //Controller.MethodToCall("delay");
        }

        private void btnLocationHistory_Click(object sender, EventArgs e)
        {
            //Controller.MethodToCall("logs");
        }

        private void btnGeneratePDF_Click(object sender, EventArgs e)
        {
            frmChoicePDF frmPDF = new frmChoicePDF();
            frmPDF.Show();
        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            if (txtResearch.Text == "")
            {
                //Controller.MethodToCall("default");
            }
            else
            {
                //Controller.MethodToCall("research");
            }
        }     
    }
}
