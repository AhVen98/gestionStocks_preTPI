
namespace locationMateriel
{
    partial class frmReturnObject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReturnObject = new System.Windows.Forms.Label();
            this.txtRentNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.lstViewObjectToReturn = new System.Windows.Forms.ListView();
            this.cHNumberObjet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHNameObject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHRenter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReturnObject
            // 
            this.lblReturnObject.AutoSize = true;
            this.lblReturnObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnObject.Location = new System.Drawing.Point(160, 9);
            this.lblReturnObject.Name = "lblReturnObject";
            this.lblReturnObject.Size = new System.Drawing.Size(230, 29);
            this.lblReturnObject.TabIndex = 7;
            this.lblReturnObject.Text = "Retourner un objet";
            // 
            // txtRentNumber
            // 
            this.txtRentNumber.Location = new System.Drawing.Point(12, 62);
            this.txtRentNumber.Name = "txtRentNumber";
            this.txtRentNumber.Size = new System.Drawing.Size(99, 20);
            this.txtRentNumber.TabIndex = 9;
            this.txtRentNumber.Text = "numéro de location";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(422, 62);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(99, 20);
            this.txtEmployeeNumber.TabIndex = 9;
            this.txtEmployeeNumber.Text = "numéro d\'employé";
            // 
            // lstViewObjectToReturn
            // 
            this.lstViewObjectToReturn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHNumberObjet,
            this.cHNameObject,
            this.cHRenter,
            this.cHReturnDate});
            this.lstViewObjectToReturn.Enabled = false;
            this.lstViewObjectToReturn.HideSelection = false;
            this.lstViewObjectToReturn.Location = new System.Drawing.Point(13, 108);
            this.lstViewObjectToReturn.Name = "lstViewObjectToReturn";
            this.lstViewObjectToReturn.Size = new System.Drawing.Size(508, 86);
            this.lstViewObjectToReturn.TabIndex = 10;
            this.lstViewObjectToReturn.UseCompatibleStateImageBehavior = false;
            this.lstViewObjectToReturn.View = System.Windows.Forms.View.Details;
            // 
            // cHNumberObjet
            // 
            this.cHNumberObjet.Text = "N° d\'objet";
            // 
            // cHNameObject
            // 
            this.cHNameObject.Text = "Nom de l\'objet";
            this.cHNameObject.Width = 150;
            // 
            // cHRenter
            // 
            this.cHRenter.Text = "locataire";
            this.cHRenter.Width = 150;
            // 
            // cHReturnDate
            // 
            this.cHReturnDate.Text = "Date de retour limite";
            this.cHReturnDate.Width = 140;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(446, 254);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Retourner";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmReturnObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lstViewObjectToReturn);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtRentNumber);
            this.Controls.Add(this.lblReturnObject);
            this.MaximumSize = new System.Drawing.Size(549, 328);
            this.MinimumSize = new System.Drawing.Size(549, 328);
            this.Name = "frmReturnObject";
            this.Text = "Retourner un objet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnObject;
        private System.Windows.Forms.TextBox txtRentNumber;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.ListView lstViewObjectToReturn;
        private System.Windows.Forms.ColumnHeader cHNumberObjet;
        private System.Windows.Forms.ColumnHeader cHNameObject;
        private System.Windows.Forms.ColumnHeader cHRenter;
        private System.Windows.Forms.ColumnHeader cHReturnDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
    }
}