
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvObjectToReturn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectToReturn)).BeginInit();
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
            this.txtRentNumber.TabIndex = 1;
            this.txtRentNumber.Text = "numéro de location";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(422, 62);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(99, 20);
            this.txtEmployeeNumber.TabIndex = 2;
            this.txtEmployeeNumber.Text = "numéro d\'employé";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(446, 254);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Retourner";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(195, 200);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(131, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Afficher le détail";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvObjectToReturn
            // 
            this.dgvObjectToReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjectToReturn.Location = new System.Drawing.Point(13, 89);
            this.dgvObjectToReturn.Name = "dgvObjectToReturn";
            this.dgvObjectToReturn.Size = new System.Drawing.Size(508, 105);
            this.dgvObjectToReturn.TabIndex = 15;
            // 
            // frmReturnObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 289);
            this.Controls.Add(this.dgvObjectToReturn);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtRentNumber);
            this.Controls.Add(this.lblReturnObject);
            this.MaximumSize = new System.Drawing.Size(549, 328);
            this.MinimumSize = new System.Drawing.Size(549, 328);
            this.Name = "frmReturnObject";
            this.Text = "Retourner un objet";
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjectToReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturnObject;
        private System.Windows.Forms.TextBox txtRentNumber;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DataGridView dgvObjectToReturn;
    }
}