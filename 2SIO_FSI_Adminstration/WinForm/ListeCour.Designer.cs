namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeCour
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
            this.bQuitter = new System.Windows.Forms.Button();
            this.dgvCour = new System.Windows.Forms.DataGridView();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCour)).BeginInit();
            this.SuspendLayout();
            // 
            // bQuitter
            // 
            this.bQuitter.BackColor = System.Drawing.Color.Green;
            this.bQuitter.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitter.ForeColor = System.Drawing.Color.Transparent;
            this.bQuitter.Location = new System.Drawing.Point(1217, 52);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(161, 42);
            this.bQuitter.TabIndex = 8;
            this.bQuitter.Text = "Fermer";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // dgvCour
            // 
            this.dgvCour.AllowUserToAddRows = false;
            this.dgvCour.AllowUserToDeleteRows = false;
            this.dgvCour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomEtudiant,
            this.Description,
            this.Classe});
            this.dgvCour.Location = new System.Drawing.Point(12, 12);
            this.dgvCour.MultiSelect = false;
            this.dgvCour.Name = "dgvCour";
            this.dgvCour.ReadOnly = true;
            this.dgvCour.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCour.Size = new System.Drawing.Size(1172, 616);
            this.dgvCour.TabIndex = 9;
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.HeaderText = "Cour";
            this.nomEtudiant.MinimumWidth = 8;
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Classe";
            this.Classe.MinimumWidth = 8;
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            // 
            // ListeCour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 640);
            this.Controls.Add(this.dgvCour);
            this.Controls.Add(this.bQuitter);
            this.Name = "ListeCour";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.DataGridView dgvCour;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
    }
}