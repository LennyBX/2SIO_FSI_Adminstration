namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeEtudiant));
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.dgvEtudiants = new System.Windows.Forms.DataGridView();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bFermer = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnÉtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnÉtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerUnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.msGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pbLogo);
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(84, 75);
            this.PanelLogo.TabIndex = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(78, 73);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // dgvEtudiants
            // 
            this.dgvEtudiants.AllowUserToAddRows = false;
            this.dgvEtudiants.AllowUserToDeleteRows = false;
            this.dgvEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtudiants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomEtudiant,
            this.prenomEtudiant,
            this.Classe});
            this.dgvEtudiants.Location = new System.Drawing.Point(90, 39);
            this.dgvEtudiants.MultiSelect = false;
            this.dgvEtudiants.Name = "dgvEtudiants";
            this.dgvEtudiants.ReadOnly = true;
            this.dgvEtudiants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEtudiants.Size = new System.Drawing.Size(1086, 503);
            this.dgvEtudiants.TabIndex = 1;
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.HeaderText = "Nom";
            this.nomEtudiant.MinimumWidth = 8;
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.ReadOnly = true;
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.HeaderText = "Prénom";
            this.prenomEtudiant.MinimumWidth = 8;
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.ReadOnly = true;
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Classe";
            this.Classe.MinimumWidth = 6;
            this.Classe.Name = "Classe";
            this.Classe.ReadOnly = true;
            // 
            // bFermer
            // 
            this.bFermer.BackColor = System.Drawing.Color.DarkGreen;
            this.bFermer.ForeColor = System.Drawing.Color.Transparent;
            this.bFermer.Location = new System.Drawing.Point(1220, 39);
            this.bFermer.Name = "bFermer";
            this.bFermer.Size = new System.Drawing.Size(153, 47);
            this.bFermer.TabIndex = 13;
            this.bFermer.Text = "Retour";
            this.bFermer.UseVisualStyleBackColor = false;
            this.bFermer.Click += new System.EventHandler(this.bFermer_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.msGlobal);
            this.PanelMenu.Location = new System.Drawing.Point(90, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1005, 33);
            this.PanelMenu.TabIndex = 14;
            // 
            // msGlobal
            // 
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem2,
            this.gestionEtudiantToolStripMenuItem1,
            this.gestionClasseToolStripMenuItem,
            this.gestionDesCourToolStripMenuItem});
            this.msGlobal.Location = new System.Drawing.Point(0, 0);
            this.msGlobal.Name = "msGlobal";
            this.msGlobal.Size = new System.Drawing.Size(1005, 28);
            this.msGlobal.TabIndex = 0;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(71, 24);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            // 
            // gestionEtudiantToolStripMenuItem1
            // 
            this.gestionEtudiantToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEtudiantsToolStripMenuItem,
            this.ajouterUnEtudiantToolStripMenuItem,
            this.supprimerUnÉtudiantToolStripMenuItem,
            this.modifierUnÉtudiantToolStripMenuItem});
            this.gestionEtudiantToolStripMenuItem1.Name = "gestionEtudiantToolStripMenuItem1";
            this.gestionEtudiantToolStripMenuItem1.Size = new System.Drawing.Size(165, 24);
            this.gestionEtudiantToolStripMenuItem1.Text = "Gestion des étudiants";
            // 
            // listeDesEtudiantsToolStripMenuItem
            // 
            this.listeDesEtudiantsToolStripMenuItem.Name = "listeDesEtudiantsToolStripMenuItem";
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click_1);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudiantToolStripMenuItem_Click_1);
            // 
            // supprimerUnÉtudiantToolStripMenuItem
            // 
            this.supprimerUnÉtudiantToolStripMenuItem.Name = "supprimerUnÉtudiantToolStripMenuItem";
            this.supprimerUnÉtudiantToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.supprimerUnÉtudiantToolStripMenuItem.Text = "Supprimer un étudiant";
            this.supprimerUnÉtudiantToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnÉtudiantToolStripMenuItem_Click_1);
            // 
            // modifierUnÉtudiantToolStripMenuItem
            // 
            this.modifierUnÉtudiantToolStripMenuItem.Name = "modifierUnÉtudiantToolStripMenuItem";
            this.modifierUnÉtudiantToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.modifierUnÉtudiantToolStripMenuItem.Text = "Modifier un étudiant";
            this.modifierUnÉtudiantToolStripMenuItem.Click += new System.EventHandler(this.modifierUnÉtudiantToolStripMenuItem_Click_1);
            // 
            // gestionClasseToolStripMenuItem
            // 
            this.gestionClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesClassesToolStripMenuItem,
            this.ajouterUneClasseToolStripMenuItem,
            this.supprimerUneClasseToolStripMenuItem,
            this.modifierUneClasseToolStripMenuItem});
            this.gestionClasseToolStripMenuItem.Name = "gestionClasseToolStripMenuItem";
            this.gestionClasseToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.gestionClasseToolStripMenuItem.Text = "Gestion des classes";
            // 
            // listeDesClassesToolStripMenuItem
            // 
            this.listeDesClassesToolStripMenuItem.Name = "listeDesClassesToolStripMenuItem";
            this.listeDesClassesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.listeDesClassesToolStripMenuItem.Text = "Liste des classes";
            this.listeDesClassesToolStripMenuItem.Click += new System.EventHandler(this.listeDesClassesToolStripMenuItem_Click_1);
            // 
            // ajouterUneClasseToolStripMenuItem
            // 
            this.ajouterUneClasseToolStripMenuItem.Name = "ajouterUneClasseToolStripMenuItem";
            this.ajouterUneClasseToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.ajouterUneClasseToolStripMenuItem.Text = "Ajouter une classe";
            this.ajouterUneClasseToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneClasseToolStripMenuItem_Click_1);
            // 
            // supprimerUneClasseToolStripMenuItem
            // 
            this.supprimerUneClasseToolStripMenuItem.Name = "supprimerUneClasseToolStripMenuItem";
            this.supprimerUneClasseToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.supprimerUneClasseToolStripMenuItem.Text = "Supprimer une classe";
            this.supprimerUneClasseToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneClasseToolStripMenuItem_Click_1);
            // 
            // modifierUneClasseToolStripMenuItem
            // 
            this.modifierUneClasseToolStripMenuItem.Name = "modifierUneClasseToolStripMenuItem";
            this.modifierUneClasseToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.modifierUneClasseToolStripMenuItem.Text = "Modifier une classe";
            this.modifierUneClasseToolStripMenuItem.Click += new System.EventHandler(this.modifierUneClasseToolStripMenuItem_Click_1);
            // 
            // gestionDesCourToolStripMenuItem
            // 
            this.gestionDesCourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCoursToolStripMenuItem,
            this.ajouterUnCoursToolStripMenuItem,
            this.supprimerUnCoursToolStripMenuItem,
            this.modifierUnCoursToolStripMenuItem});
            this.gestionDesCourToolStripMenuItem.Name = "gestionDesCourToolStripMenuItem";
            this.gestionDesCourToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.gestionDesCourToolStripMenuItem.Text = "Gestion des cours";
            // 
            // listeDesCoursToolStripMenuItem
            // 
            this.listeDesCoursToolStripMenuItem.Name = "listeDesCoursToolStripMenuItem";
            this.listeDesCoursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listeDesCoursToolStripMenuItem.Text = "Liste des cours";
            this.listeDesCoursToolStripMenuItem.Click += new System.EventHandler(this.listeDesCoursToolStripMenuItem_Click_1);
            // 
            // ajouterUnCoursToolStripMenuItem
            // 
            this.ajouterUnCoursToolStripMenuItem.Name = "ajouterUnCoursToolStripMenuItem";
            this.ajouterUnCoursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ajouterUnCoursToolStripMenuItem.Text = "Ajouter un cours";
            this.ajouterUnCoursToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnCoursToolStripMenuItem_Click_1);
            // 
            // supprimerUnCoursToolStripMenuItem
            // 
            this.supprimerUnCoursToolStripMenuItem.Name = "supprimerUnCoursToolStripMenuItem";
            this.supprimerUnCoursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.supprimerUnCoursToolStripMenuItem.Text = "Supprimer un cours";
            this.supprimerUnCoursToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnCoursToolStripMenuItem_Click_1);
            // 
            // modifierUnCoursToolStripMenuItem
            // 
            this.modifierUnCoursToolStripMenuItem.Name = "modifierUnCoursToolStripMenuItem";
            this.modifierUnCoursToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modifierUnCoursToolStripMenuItem.Text = "Modifier un cours";
            this.modifierUnCoursToolStripMenuItem.Click += new System.EventHandler(this.modifierUnCoursToolStripMenuItem_Click_1);
            // 
            // ListeEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1385, 577);
            this.Controls.Add(this.dgvEtudiants);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.bFermer);
            this.Controls.Add(this.PanelLogo);
            this.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ListeEtudiant";
            this.Text = "FSI Notes - Liste des étudiants";
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        //   private P2022_Appli_AdministrationDataSetTableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.Button bFermer;
        private System.Windows.Forms.DataGridView dgvEtudiants;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomEtudiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnÉtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnÉtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnCoursToolStripMenuItem;
    }
}