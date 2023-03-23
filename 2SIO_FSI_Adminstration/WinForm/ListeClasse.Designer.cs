namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ListeClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeClasse));
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bQuitter = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.msGlobal = new System.Windows.Forms.MenuStrip();
            this.accueilToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEtudiantToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEtudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnEtudiantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.dgvEtudiants = new System.Windows.Forms.DataGridView();
            this.nomEtudiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListeEtudiant = new System.Windows.Forms.DataGridView();
            this.bFermer = new System.Windows.Forms.Button();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.msGlobal.SuspendLayout();
            this.PanelInterieur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtudiant)).BeginInit();
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
            // bQuitter
            // 
            this.bQuitter.BackColor = System.Drawing.Color.Green;
            this.bQuitter.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitter.ForeColor = System.Drawing.Color.Transparent;
            this.bQuitter.Location = new System.Drawing.Point(903, 12);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(149, 34);
            this.bQuitter.TabIndex = 7;
            this.bQuitter.Text = "QUITTER";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.msGlobal);
            this.PanelMenu.Location = new System.Drawing.Point(87, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(806, 24);
            this.PanelMenu.TabIndex = 12;
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
            this.msGlobal.Size = new System.Drawing.Size(806, 33);
            this.msGlobal.TabIndex = 0;
            this.msGlobal.Text = "Menu";
            // 
            // accueilToolStripMenuItem2
            // 
            this.accueilToolStripMenuItem2.Name = "accueilToolStripMenuItem2";
            this.accueilToolStripMenuItem2.Size = new System.Drawing.Size(83, 29);
            this.accueilToolStripMenuItem2.Text = "Accueil";
            this.accueilToolStripMenuItem2.Click += new System.EventHandler(this.accueilToolStripMenuItem2_Click);
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
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(267, 34);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudiantToolStripMenuItem_Click);
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
            // PanelInterieur
            // 
            this.PanelInterieur.Controls.Add(this.dgvEtudiants);
            this.PanelInterieur.Controls.Add(this.dgvListeEtudiant);
            this.PanelInterieur.Location = new System.Drawing.Point(87, 29);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(806, 404);
            this.PanelInterieur.TabIndex = 12;
            // 
            // dgvEtudiants
            // 
            this.dgvEtudiants.AllowUserToAddRows = false;
            this.dgvEtudiants.AllowUserToDeleteRows = false;
            this.dgvEtudiants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtudiants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomEtudiant});
            this.dgvEtudiants.Location = new System.Drawing.Point(0, 3);
            this.dgvEtudiants.MultiSelect = false;
            this.dgvEtudiants.Name = "dgvEtudiants";
            this.dgvEtudiants.ReadOnly = true;
            this.dgvEtudiants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEtudiants.Size = new System.Drawing.Size(803, 398);
            this.dgvEtudiants.TabIndex = 1;
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.HeaderText = "Classe";
            this.nomEtudiant.MinimumWidth = 8;
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.ReadOnly = true;
            // 
            // dgvListeEtudiant
            // 
            this.dgvListeEtudiant.AllowUserToOrderColumns = true;
            this.dgvListeEtudiant.BackgroundColor = System.Drawing.Color.White;
            this.dgvListeEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEtudiant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListeEtudiant.GridColor = System.Drawing.Color.SkyBlue;
            this.dgvListeEtudiant.Location = new System.Drawing.Point(0, 0);
            this.dgvListeEtudiant.Name = "dgvListeEtudiant";
            this.dgvListeEtudiant.RowHeadersWidth = 62;
            this.dgvListeEtudiant.Size = new System.Drawing.Size(806, 404);
            this.dgvListeEtudiant.TabIndex = 0;
            // 
            // bFermer
            // 
            this.bFermer.BackColor = System.Drawing.Color.Green;
            this.bFermer.ForeColor = System.Drawing.Color.Transparent;
            this.bFermer.Location = new System.Drawing.Point(899, 52);
            this.bFermer.Name = "bFermer";
            this.bFermer.Size = new System.Drawing.Size(153, 34);
            this.bFermer.TabIndex = 13;
            this.bFermer.Text = "FERMER";
            this.bFermer.UseVisualStyleBackColor = false;
            this.bFermer.Click += new System.EventHandler(this.bFermer_Click);
            // 
            // ListeClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 444);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bFermer);
            this.Controls.Add(this.PanelInterieur);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelLogo);
            this.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "ListeClasse";
            this.Text = "Liste des classes";
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            this.PanelInterieur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtudiants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEtudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.MenuStrip msGlobal;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.Panel PanelInterieur;
        private System.Windows.Forms.DataGridView dgvListeEtudiant;
        //   private P2022_Appli_AdministrationDataSetTableAdapters.etudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.Button bFermer;
        //    private System.Windows.Forms.DataGridViewTextBoxColumn nometudiantDataGridViewTextBoxColumn;
        //     private System.Windows.Forms.DataGridViewTextBoxColumn prenometudiantDataGridViewTextBoxColumn;
        //    private System.Windows.Forms.DataGridViewTextBoxColumn idclasseDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEtudiants;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomEtudiant;
    }
}