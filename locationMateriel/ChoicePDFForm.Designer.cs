
namespace locationMateriel
{
    partial class ChoicePDFForm
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
            this.btnRentedPDF = new System.Windows.Forms.Button();
            this.btnAvailablePDF = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRentedPDF
            // 
            this.btnRentedPDF.Location = new System.Drawing.Point(212, 115);
            this.btnRentedPDF.Name = "btnRentedPDF";
            this.btnRentedPDF.Size = new System.Drawing.Size(119, 46);
            this.btnRentedPDF.TabIndex = 0;
            this.btnRentedPDF.Text = "Objets loués";
            this.btnRentedPDF.UseVisualStyleBackColor = true;
            // 
            // btnAvailablePDF
            // 
            this.btnAvailablePDF.Location = new System.Drawing.Point(380, 115);
            this.btnAvailablePDF.Name = "btnAvailablePDF";
            this.btnAvailablePDF.Size = new System.Drawing.Size(119, 46);
            this.btnAvailablePDF.TabIndex = 1;
            this.btnAvailablePDF.Text = "Objets disponibles";
            this.btnAvailablePDF.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(34, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 46);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ChoicePDFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAvailablePDF);
            this.Controls.Add(this.btnRentedPDF);
            this.MaximumSize = new System.Drawing.Size(549, 328);
            this.MinimumSize = new System.Drawing.Size(549, 328);
            this.Name = "ChoicePDFForm";
            this.Text = "Sélectionner le type de PDF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRentedPDF;
        private System.Windows.Forms.Button btnAvailablePDF;
        private System.Windows.Forms.Button btnCancel;
    }
}