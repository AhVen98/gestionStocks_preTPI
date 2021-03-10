
namespace locationMateriel
{
    partial class frmRentObject
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
            this.lblRentObject = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.calExpectedReturn = new System.Windows.Forms.MonthCalendar();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.rbtnNewClient = new System.Windows.Forms.RadioButton();
            this.rbtnExistingClient = new System.Windows.Forms.RadioButton();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientLastName = new System.Windows.Forms.TextBox();
            this.txtClientFirstName = new System.Windows.Forms.TextBox();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblClientNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.grpClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRentObject
            // 
            this.lblRentObject.AutoSize = true;
            this.lblRentObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentObject.Location = new System.Drawing.Point(174, 9);
            this.lblRentObject.Name = "lblRentObject";
            this.lblRentObject.Size = new System.Drawing.Size(181, 29);
            this.lblRentObject.TabIndex = 6;
            this.lblRentObject.Text = "Louer un objet";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(269, 20);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "nom de l\'objet";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(435, 53);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(84, 20);
            this.txtEmployeeNumber.TabIndex = 8;
            this.txtEmployeeNumber.Text = "numéro employé";
            // 
            // calExpectedReturn
            // 
            this.calExpectedReturn.Location = new System.Drawing.Point(292, 85);
            this.calExpectedReturn.Name = "calExpectedReturn";
            this.calExpectedReturn.TabIndex = 9;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(444, 253);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 10;
            this.btnRent.Text = "Louer";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(363, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.rbtnNewClient);
            this.grpClient.Controls.Add(this.rbtnExistingClient);
            this.grpClient.Location = new System.Drawing.Point(11, 79);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(269, 68);
            this.grpClient.TabIndex = 12;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Client";
            // 
            // rbtnNewClient
            // 
            this.rbtnNewClient.AutoSize = true;
            this.rbtnNewClient.Location = new System.Drawing.Point(7, 43);
            this.rbtnNewClient.Name = "rbtnNewClient";
            this.rbtnNewClient.Size = new System.Drawing.Size(69, 17);
            this.rbtnNewClient.TabIndex = 1;
            this.rbtnNewClient.Text = "Nouveau";
            this.rbtnNewClient.UseVisualStyleBackColor = true;
            this.rbtnNewClient.CheckedChanged += new System.EventHandler(this.rbtnNewClient_CheckedChanged);
            // 
            // rbtnExistingClient
            // 
            this.rbtnExistingClient.AutoSize = true;
            this.rbtnExistingClient.Checked = true;
            this.rbtnExistingClient.Location = new System.Drawing.Point(7, 20);
            this.rbtnExistingClient.Name = "rbtnExistingClient";
            this.rbtnExistingClient.Size = new System.Drawing.Size(86, 17);
            this.rbtnExistingClient.TabIndex = 0;
            this.rbtnExistingClient.TabStop = true;
            this.rbtnExistingClient.Text = "Déjà existant";
            this.rbtnExistingClient.UseVisualStyleBackColor = true;
            this.rbtnExistingClient.CheckedChanged += new System.EventHandler(this.rbtnExistingClient_CheckedChanged);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(87, 153);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(193, 20);
            this.txtClientID.TabIndex = 13;
            // 
            // txtClientLastName
            // 
            this.txtClientLastName.Enabled = false;
            this.txtClientLastName.Location = new System.Drawing.Point(87, 152);
            this.txtClientLastName.Name = "txtClientLastName";
            this.txtClientLastName.Size = new System.Drawing.Size(193, 20);
            this.txtClientLastName.TabIndex = 14;
            this.txtClientLastName.Visible = false;
            // 
            // txtClientFirstName
            // 
            this.txtClientFirstName.Enabled = false;
            this.txtClientFirstName.Location = new System.Drawing.Point(87, 179);
            this.txtClientFirstName.Name = "txtClientFirstName";
            this.txtClientFirstName.Size = new System.Drawing.Size(193, 20);
            this.txtClientFirstName.TabIndex = 14;
            this.txtClientFirstName.Visible = false;
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Enabled = false;
            this.txtBirthDate.Location = new System.Drawing.Point(113, 205);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(167, 20);
            this.txtBirthDate.TabIndex = 14;
            this.txtBirthDate.Text = "jj-mm-AAAA";
            this.txtBirthDate.Visible = false;
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(87, 231);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(193, 20);
            this.txtMail.TabIndex = 14;
            this.txtMail.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(11, 159);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(29, 13);
            this.lblLastName.TabIndex = 15;
            this.lblLastName.Text = "Nom";
            this.lblLastName.Visible = false;
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.AutoSize = true;
            this.lblClientNumber.Location = new System.Drawing.Point(14, 160);
            this.lblClientNumber.Name = "lblClientNumber";
            this.lblClientNumber.Size = new System.Drawing.Size(44, 13);
            this.lblClientNumber.TabIndex = 16;
            this.lblClientNumber.Text = "Numéro";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(11, 185);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(43, 13);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "Prénom";
            this.lblFirstName.Visible = false;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(11, 211);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(96, 13);
            this.lblBirth.TabIndex = 18;
            this.lblBirth.Text = "Date de naissance";
            this.lblBirth.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(14, 237);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 13);
            this.lblMail.TabIndex = 19;
            this.lblMail.Text = "E-Mail";
            this.lblMail.Visible = false;
            // 
            // frmRentObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 289);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txtClientLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblClientNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtBirthDate);
            this.Controls.Add(this.txtClientFirstName);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.calExpectedReturn);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblRentObject);
            this.MaximumSize = new System.Drawing.Size(549, 328);
            this.MinimumSize = new System.Drawing.Size(549, 328);
            this.Name = "frmRentObject";
            this.Text = "Louer un objet";
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRentObject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.MonthCalendar calExpectedReturn;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.RadioButton rbtnExistingClient;
        private System.Windows.Forms.RadioButton rbtnNewClient;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtClientLastName;
        private System.Windows.Forms.TextBox txtClientFirstName;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblClientNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblMail;
    }
}