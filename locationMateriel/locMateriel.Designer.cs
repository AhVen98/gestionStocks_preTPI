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
            this.listView1 = new System.Windows.Forms.ListView();
            this.chObjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chObjectState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRenter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReturnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
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
            this.btnRentObject.Click += new System.EventHandler(this.btnRentObject_Click);
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
            this.btnReturnObject.Click += new System.EventHandler(this.btnReturnObject_Click);
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
            this.btnReturnDateOver.Click += new System.EventHandler(this.btnReturnDateOver_Click);
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
            this.btnLocationHistory.Click += new System.EventHandler(this.btnLocationHistory_Click);
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
            this.btnGeneratePDF.Click += new System.EventHandler(this.btnGeneratePDF_Click);
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(634, 120);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(121, 23);
            this.btnResearch.TabIndex = 3;
            this.btnResearch.Text = "Rechercher";
            this.btnResearch.UseVisualStyleBackColor = true;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // txtResearch
            // 
            this.txtResearch.Location = new System.Drawing.Point(471, 122);
            this.txtResearch.Name = "txtResearch";
            this.txtResearch.Size = new System.Drawing.Size(157, 20);
            this.txtResearch.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chObjectName,
            this.chType,
            this.chObjectState,
            this.chRenter,
            this.chReturnDate});
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(19, 146);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(736, 400);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chObjectName
            // 
            this.chObjectName.Text = "nom de l\'objet";
            this.chObjectName.Width = 146;
            // 
            // chObjectState
            // 
            this.chObjectState.Text = "état";
            this.chObjectState.Width = 146;
            // 
            // chRenter
            // 
            this.chRenter.Text = "locataire";
            this.chRenter.Width = 146;
            // 
            // chReturnDate
            // 
            this.chReturnDate.Text = "date de retour limite";
            this.chReturnDate.Width = 146;
            // 
            // chType
            // 
            this.chType.Text = "type";
            this.chType.Width = 146;
            // 
            // locMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(937, 556);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtResearch);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.btnGeneratePDF);
            this.Controls.Add(this.btnLocationHistory);
            this.Controls.Add(this.btnReturnDateOver);
            this.Controls.Add(this.btnReturnObject);
            this.Controls.Add(this.btnRentObject);
            this.Controls.Add(this.btnAddObject);
            this.Controls.Add(this.lblLocationMat_Title);
            this.MaximumSize = new System.Drawing.Size(953, 595);
            this.MinimumSize = new System.Drawing.Size(953, 595);
            this.Name = "locMateriel";
            this.Text = "Location de matériel";
            this.Load += new System.EventHandler(this.locMateriel_Load);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chObjectName;
        private System.Windows.Forms.ColumnHeader chObjectState;
        private System.Windows.Forms.ColumnHeader chRenter;
        private System.Windows.Forms.ColumnHeader chReturnDate;
        private System.Windows.Forms.ColumnHeader chType;
    }
}

