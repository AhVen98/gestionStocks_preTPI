namespace locationMateriel
{
    partial class locMateriel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLocationMat_Title = new System.Windows.Forms.Label();
            this.btnAddObject = new System.Windows.Forms.Button();
            this.btnRentObject = new System.Windows.Forms.Button();
            this.btnReturnObject = new System.Windows.Forms.Button();
            this.btnReturnDateOver = new System.Windows.Forms.Button();
            this.btnLocationHistory = new System.Windows.Forms.Button();
            this.btnGeneratePDF = new System.Windows.Forms.Button();
            this.btnResearch = new System.Windows.Forms.Button();
            this.txtResearch = new System.Windows.Forms.TextBox();
            this.pBInformations = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBInformations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLocationMat_Title
            // 
            this.lblLocationMat_Title.AutoSize = true;
            this.lblLocationMat_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationMat_Title.Location = new System.Drawing.Point(257, 31);
            this.lblLocationMat_Title.Name = "lblLocationMat_Title";
            this.lblLocationMat_Title.Size = new System.Drawing.Size(430, 51);
            this.lblLocationMat_Title.TabIndex = 0;
            this.lblLocationMat_Title.Text = "Location de matériel";
            this.lblLocationMat_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddObject
            // 
            this.btnAddObject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObject.Location = new System.Drawing.Point(767, 146);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(159, 52);
            this.btnAddObject.TabIndex = 1;
            this.btnAddObject.Text = "Ajouter un objet";
            this.btnAddObject.UseVisualStyleBackColor = true;
            // 
            // btnRentObject
            // 
            this.btnRentObject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRentObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentObject.Location = new System.Drawing.Point(767, 204);
            this.btnRentObject.Name = "btnRentObject";
            this.btnRentObject.Size = new System.Drawing.Size(159, 52);
            this.btnRentObject.TabIndex = 1;
            this.btnRentObject.Text = "Louer un objet";
            this.btnRentObject.UseVisualStyleBackColor = true;
            // 
            // btnReturnObject
            // 
            this.btnReturnObject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturnObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnObject.Location = new System.Drawing.Point(767, 262);
            this.btnReturnObject.Name = "btnReturnObject";
            this.btnReturnObject.Size = new System.Drawing.Size(159, 52);
            this.btnReturnObject.TabIndex = 1;
            this.btnReturnObject.Text = "Retourner un objet";
            this.btnReturnObject.UseVisualStyleBackColor = true;
            // 
            // btnReturnDateOver
            // 
            this.btnReturnDateOver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturnDateOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnDateOver.Location = new System.Drawing.Point(767, 378);
            this.btnReturnDateOver.Name = "btnReturnDateOver";
            this.btnReturnDateOver.Size = new System.Drawing.Size(159, 52);
            this.btnReturnDateOver.TabIndex = 1;
            this.btnReturnDateOver.Text = "Délai dépassé";
            this.btnReturnDateOver.UseVisualStyleBackColor = true;
            // 
            // btnLocationHistory
            // 
            this.btnLocationHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLocationHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocationHistory.Location = new System.Drawing.Point(767, 436);
            this.btnLocationHistory.Name = "btnLocationHistory";
            this.btnLocationHistory.Size = new System.Drawing.Size(159, 52);
            this.btnLocationHistory.TabIndex = 1;
            this.btnLocationHistory.Text = "Historique de location";
            this.btnLocationHistory.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePDF
            // 
            this.btnGeneratePDF.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGeneratePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePDF.Location = new System.Drawing.Point(767, 494);
            this.btnGeneratePDF.Name = "btnGeneratePDF";
            this.btnGeneratePDF.Size = new System.Drawing.Size(159, 52);
            this.btnGeneratePDF.TabIndex = 1;
            this.btnGeneratePDF.Text = "Générer un PDF";
            this.btnGeneratePDF.UseVisualStyleBackColor = true;
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(634, 120);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(121, 23);
            this.btnResearch.TabIndex = 3;
            this.btnResearch.Text = "Rechercher";
            this.btnResearch.UseVisualStyleBackColor = true;
            // 
            // txtResearch
            // 
            this.txtResearch.Location = new System.Drawing.Point(471, 122);
            this.txtResearch.Name = "txtResearch";
            this.txtResearch.Size = new System.Drawing.Size(157, 20);
            this.txtResearch.TabIndex = 4;
            // 
            // pBInformations
            // 
            this.pBInformations.BackColor = System.Drawing.Color.White;
            this.pBInformations.InitialImage = null;
            this.pBInformations.Location = new System.Drawing.Point(19, 146);
            this.pBInformations.Margin = new System.Windows.Forms.Padding(0);
            this.pBInformations.Name = "pBInformations";
            this.pBInformations.Size = new System.Drawing.Size(736, 399);
            this.pBInformations.TabIndex = 2;
            this.pBInformations.TabStop = false;
            // 
            // locMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 560);
            this.Controls.Add(this.txtResearch);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.pBInformations);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.btnLocationHistory);
            this.Controls.Add(this.btnReturnDateOver);
            this.Controls.Add(this.btnReturnObject);
            this.Controls.Add(this.btnRentObject);
            this.Controls.Add(this.btnAddObject);
            this.Controls.Add(this.lblLocationMat_Title);
            this.Name = "locMateriel";
            this.Text = "Location de matériel";
            this.Load += new System.EventHandler(this.locMateriel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBInformations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocationMat_Title;
        private System.Windows.Forms.Button btnAddObject;
        private System.Windows.Forms.Button btnRentObject;
        private System.Windows.Forms.Button btnReturnObject;
        private System.Windows.Forms.Button btnReturnDateOver;
        private System.Windows.Forms.Button btnLocationHistory;
        private System.Windows.Forms.Button btnGeneratePDF;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.TextBox txtResearch;
        private System.Windows.Forms.PictureBox pBInformations;
    }
}

