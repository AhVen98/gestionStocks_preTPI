
namespace locationMateriel
{
    partial class frmAddObject
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAddObject = new System.Windows.Forms.Label();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "nom de l\'objet";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(11, 79);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(207, 20);
            this.txtType.TabIndex = 1;
            this.txtType.Text = "type de l\'objet";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(11, 105);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(509, 96);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "Description";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(12, 208);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(508, 38);
            this.txtRemark.TabIndex = 4;
            this.txtRemark.Text = "Remarque";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(444, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(363, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblAddObject
            // 
            this.lblAddObject.AutoSize = true;
            this.lblAddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddObject.Location = new System.Drawing.Point(174, 9);
            this.lblAddObject.Name = "lblAddObject";
            this.lblAddObject.Size = new System.Drawing.Size(197, 29);
            this.lblAddObject.TabIndex = 5;
            this.lblAddObject.Text = "Ajouter un objet";
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Location = new System.Drawing.Point(424, 53);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(95, 20);
            this.txtEmployeeNumber.TabIndex = 2;
            // 
            // frmAddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 289);
            this.Controls.Add(this.lblAddObject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtName);
            this.MaximumSize = new System.Drawing.Size(549, 328);
            this.MinimumSize = new System.Drawing.Size(549, 328);
            this.Name = "frmAddObject";
            this.Text = "Ajouter un objet";
            this.Load += new System.EventHandler(this.AddObjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAddObject;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
    }
}