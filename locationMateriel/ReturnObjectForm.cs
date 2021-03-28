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
            MessageBox.Show("L'objet a correctement été retourné");
            ActiveForm.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int rentID;
            List<string> lstTab = new List<string>();
            int.TryParse(txtRentNumber.Text, out rentID);

            dgvObjectToReturn.ColumnCount = 4;
            //option for display
            dgvObjectToReturn.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvObjectToReturn.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvObjectToReturn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvObjectToReturn.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvObjectToReturn.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvObjectToReturn.GridColor = Color.Black;

            //columns name
            dgvObjectToReturn.Columns[0].Name = "ID";
            dgvObjectToReturn.Columns[1].Name = "Nom d'objet";
            dgvObjectToReturn.Columns[2].Name = "Locataire";
            dgvObjectToReturn.Columns[3].Name = "Date de retour limite";

            dgvObjectToReturn.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;

            List<Objects> lstObj = Objects.LoadRented(rentID);
            foreach (Objects obj in lstObj)
            {
                string[] row = { obj.ID.ToString(), obj.Name, obj.Renter, obj.ExpectedReturn.ToString()};
                dgvObjectToReturn.Rows.Add(row);
            }
        }
    }
}
