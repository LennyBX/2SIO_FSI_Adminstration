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
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCour)).BeginInit();
            this.msGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // bQuitter
            // 
            this.bQuitter.BackColor = System.Drawing.Color.Green;
            this.bQuitter.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitter.ForeColor = System.Drawing.Color.Transparent;
            this.bQuitter.Location = new System.Drawing.Point(893, 66);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(161, 42);
            this.bQuitter.TabIndex = 8;
            this.bQuitter.Text = "Fermer";
            this.bQuitter.UseVisualStyleBackColor = false;
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
            this.dgvCour.Location = new System.Drawing.Point(36, 52);
            this.dgvCour.MultiSelect = false;
            this.dgvCour.Name = "dgvCour";
            this.dgvCour.ReadOnly = true;
            this.dgvCour.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCour.Size = new System.Drawing.Size(820, 435);
            this.dgvCour.TabIndex = 9;
            // 
            // msGlobal
            // 
            this.msGlobal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem2,
            this.gestionEtudiantToolStripMenuItem1,
            this.gestionClasseToolStripMenuItem});
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(1077, 33);
            this.msGlobal.TabIndex = 10;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(83, 29);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            // 
            // gestionEtudiantToolStripMenuItem1
            // 
            this.gestionEtudiantToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEtudiantsToolStripMenuItem,
            this.ajouterUnEtudiantToolStripMenuItem});
            this.gestionEtudiantToolStripMenuItem1.Name = "gestionEtudiantToolStripMenuItem1";
            this.gestionEtudiantToolStripMenuItem1.Size = new System.Drawing.Size(158, 29);
            this.gestionEtudiantToolStripMenuItem1.Text = "Gestion Etudiant";
            // 
            // listeDesEtudiantsToolStripMenuItem
            // 
            this.listeDesEtudiantsToolStripMenuItem.Name = "listeDesEtudiantsToolStripMenuItem";
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            // 
            // gestionClasseToolStripMenuItem
            // 
            this.gestionClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesClassesToolStripMenuItem,
            this.ajouterUneClasseToolStripMenuItem});
            this.gestionClasseToolStripMenuItem.Name = "gestionClasseToolStripMenuItem";
            this.gestionClasseToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.gestionClasseToolStripMenuItem.Text = "Gestion classe";
            // 
            // listeDesClassesToolStripMenuItem
            // 
            this.listeDesClassesToolStripMenuItem.Name = "listeDesClassesToolStripMenuItem";
            this.listeDesClassesToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.listeDesClassesToolStripMenuItem.Text = "Liste des classes";
            // 
            // ajouterUneClasseToolStripMenuItem
            // 
            this.ajouterUneClasseToolStripMenuItem.Name = "ajouterUneClasseToolStripMenuItem";
            this.ajouterUneClasseToolStripMenuItem.Size = new System.Drawing.Size(257, 34);
            this.ajouterUneClasseToolStripMenuItem.Text = "Ajouter une classe";
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
            this.ClientSize = new System.Drawing.Size(1077, 532);
            this.Controls.Add(this.msGlobal);
            this.Controls.Add(this.dgvCour);
            this.Controls.Add(this.bQuitter);
            this.Name = "ListeCour";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCour)).EndInit();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.DataGridView dgvCour;
        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
    }
}