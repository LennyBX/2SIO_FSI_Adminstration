﻿namespace _2SIO_FSI_Adminstration
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
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
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bQuitter = new System.Windows.Forms.Button();
            this.PanelInterieur = new System.Windows.Forms.Panel();
            this.tbUser = new System.Windows.Forms.Label();
            this.lWelcomeSub = new System.Windows.Forms.Label();
            this.lWelcome = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.msGlobal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.PanelInterieur.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.Controls.Add(this.msGlobal);
            this.PanelMenu.Location = new System.Drawing.Point(87, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(806, 29);
            this.PanelMenu.TabIndex = 7;
            // 
            // msGlobal
            // 
            this.msGlobal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msGlobal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msGlobal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem2,
            this.gestionEtudiantToolStripMenuItem1,
            this.gestionClasseToolStripMenuItem,
            this.gestionDesCourToolStripMenuItem});
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
            // 
            // gestionEtudiantToolStripMenuItem1
            // 
            this.gestionEtudiantToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesEtudiantsToolStripMenuItem,
            this.ajouterUnEtudiantToolStripMenuItem,
            this.supprimerUnÉtudiantToolStripMenuItem,
            this.modifierUnÉtudiantToolStripMenuItem});
            this.gestionEtudiantToolStripMenuItem1.Name = "gestionEtudiantToolStripMenuItem1";
            this.gestionEtudiantToolStripMenuItem1.Size = new System.Drawing.Size(199, 29);
            this.gestionEtudiantToolStripMenuItem1.Text = "Gestion des étudiants";
            // 
            // listeDesEtudiantsToolStripMenuItem
            // 
            this.listeDesEtudiantsToolStripMenuItem.Name = "listeDesEtudiantsToolStripMenuItem";
            this.listeDesEtudiantsToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.listeDesEtudiantsToolStripMenuItem.Text = "Liste des étudiants";
            this.listeDesEtudiantsToolStripMenuItem.Click += new System.EventHandler(this.listeDesEtudiantsToolStripMenuItem_Click);
            // 
            // ajouterUnEtudiantToolStripMenuItem
            // 
            this.ajouterUnEtudiantToolStripMenuItem.Name = "ajouterUnEtudiantToolStripMenuItem";
            this.ajouterUnEtudiantToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.ajouterUnEtudiantToolStripMenuItem.Text = "Ajouter un étudiant";
            this.ajouterUnEtudiantToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnEtudiantToolStripMenuItem_Click);
            // 
            // supprimerUnÉtudiantToolStripMenuItem
            // 
            this.supprimerUnÉtudiantToolStripMenuItem.Name = "supprimerUnÉtudiantToolStripMenuItem";
            this.supprimerUnÉtudiantToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.supprimerUnÉtudiantToolStripMenuItem.Text = "Supprimer un étudiant";
            this.supprimerUnÉtudiantToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnÉtudiantToolStripMenuItem_Click);
            // 
            // modifierUnÉtudiantToolStripMenuItem
            // 
            this.modifierUnÉtudiantToolStripMenuItem.Name = "modifierUnÉtudiantToolStripMenuItem";
            this.modifierUnÉtudiantToolStripMenuItem.Size = new System.Drawing.Size(292, 34);
            this.modifierUnÉtudiantToolStripMenuItem.Text = "Modifier un étudiant";
            this.modifierUnÉtudiantToolStripMenuItem.Click += new System.EventHandler(this.modifierUnÉtudiantToolStripMenuItem_Click);
            // 
            // gestionClasseToolStripMenuItem
            // 
            this.gestionClasseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesClassesToolStripMenuItem,
            this.ajouterUneClasseToolStripMenuItem,
            this.supprimerUneClasseToolStripMenuItem,
            this.modifierUneClasseToolStripMenuItem});
            this.gestionClasseToolStripMenuItem.Name = "gestionClasseToolStripMenuItem";
            this.gestionClasseToolStripMenuItem.Size = new System.Drawing.Size(180, 29);
            this.gestionClasseToolStripMenuItem.Text = "Gestion des classes";
            // 
            // listeDesClassesToolStripMenuItem
            // 
            this.listeDesClassesToolStripMenuItem.Name = "listeDesClassesToolStripMenuItem";
            this.listeDesClassesToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.listeDesClassesToolStripMenuItem.Text = "Liste des classes";
            this.listeDesClassesToolStripMenuItem.Click += new System.EventHandler(this.listeDesClassesToolStripMenuItem_Click);
            // 
            // ajouterUneClasseToolStripMenuItem
            // 
            this.ajouterUneClasseToolStripMenuItem.Name = "ajouterUneClasseToolStripMenuItem";
            this.ajouterUneClasseToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.ajouterUneClasseToolStripMenuItem.Text = "Ajouter une classe";
            this.ajouterUneClasseToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneClasseToolStripMenuItem_Click);
            // 
            // supprimerUneClasseToolStripMenuItem
            // 
            this.supprimerUneClasseToolStripMenuItem.Name = "supprimerUneClasseToolStripMenuItem";
            this.supprimerUneClasseToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.supprimerUneClasseToolStripMenuItem.Text = "Supprimer une classe";
            this.supprimerUneClasseToolStripMenuItem.Click += new System.EventHandler(this.supprimerUneClasseToolStripMenuItem_Click);
            // 
            // modifierUneClasseToolStripMenuItem
            // 
            this.modifierUneClasseToolStripMenuItem.Name = "modifierUneClasseToolStripMenuItem";
            this.modifierUneClasseToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.modifierUneClasseToolStripMenuItem.Text = "Modifier une classe";
            this.modifierUneClasseToolStripMenuItem.Click += new System.EventHandler(this.modifierUneClasseToolStripMenuItem_Click);
            // 
            // gestionDesCourToolStripMenuItem
            // 
            this.gestionDesCourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCoursToolStripMenuItem,
            this.ajouterUnCoursToolStripMenuItem,
            this.supprimerUnCoursToolStripMenuItem,
            this.modifierUnCoursToolStripMenuItem});
            this.gestionDesCourToolStripMenuItem.Name = "gestionDesCourToolStripMenuItem";
            this.gestionDesCourToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.gestionDesCourToolStripMenuItem.Text = "Gestion des cours";
            // 
            // listeDesCoursToolStripMenuItem
            // 
            this.listeDesCoursToolStripMenuItem.Name = "listeDesCoursToolStripMenuItem";
            this.listeDesCoursToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listeDesCoursToolStripMenuItem.Text = "Liste des cours";
            this.listeDesCoursToolStripMenuItem.Click += new System.EventHandler(this.listeDesCoursToolStripMenuItem_Click);
            // 
            // ajouterUnCoursToolStripMenuItem
            // 
            this.ajouterUnCoursToolStripMenuItem.Name = "ajouterUnCoursToolStripMenuItem";
            this.ajouterUnCoursToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.ajouterUnCoursToolStripMenuItem.Text = "Ajouter un cours";
            this.ajouterUnCoursToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnCoursToolStripMenuItem_Click);
            // 
            // supprimerUnCoursToolStripMenuItem
            // 
            this.supprimerUnCoursToolStripMenuItem.Name = "supprimerUnCoursToolStripMenuItem";
            this.supprimerUnCoursToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.supprimerUnCoursToolStripMenuItem.Text = "Supprimer un cours";
            this.supprimerUnCoursToolStripMenuItem.Click += new System.EventHandler(this.supprimerUnCoursToolStripMenuItem_Click);
            // 
            // modifierUnCoursToolStripMenuItem
            // 
            this.modifierUnCoursToolStripMenuItem.Name = "modifierUnCoursToolStripMenuItem";
            this.modifierUnCoursToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modifierUnCoursToolStripMenuItem.Text = "Modifier un cours";
            this.modifierUnCoursToolStripMenuItem.Click += new System.EventHandler(this.modifierUnCoursToolStripMenuItem_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(84, 90);
            this.PanelLogo.TabIndex = 9;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(379, 17);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(262, 275);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // bQuitter
            // 
            this.bQuitter.BackColor = System.Drawing.Color.Green;
            this.bQuitter.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitter.ForeColor = System.Drawing.Color.Transparent;
            this.bQuitter.Location = new System.Drawing.Point(991, 541);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(178, 63);
            this.bQuitter.TabIndex = 7;
            this.bQuitter.Text = "Déconnexion";
            this.bQuitter.UseVisualStyleBackColor = false;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // PanelInterieur
            // 
            this.PanelInterieur.Controls.Add(this.pbLogo);
            this.PanelInterieur.Controls.Add(this.tbUser);
            this.PanelInterieur.Controls.Add(this.lWelcomeSub);
            this.PanelInterieur.Controls.Add(this.lWelcome);
            this.PanelInterieur.Location = new System.Drawing.Point(87, 35);
            this.PanelInterieur.Name = "PanelInterieur";
            this.PanelInterieur.Size = new System.Drawing.Size(879, 543);
            this.PanelInterieur.TabIndex = 11;
            // 
            // tbUser
            // 
            this.tbUser.AutoSize = true;
            this.tbUser.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.Color.Green;
            this.tbUser.Location = new System.Drawing.Point(492, 310);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(111, 35);
            this.tbUser.TabIndex = 15;
            this.tbUser.Text = "{user}";
            // 
            // lWelcomeSub
            // 
            this.lWelcomeSub.AutoSize = true;
            this.lWelcomeSub.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcomeSub.ForeColor = System.Drawing.Color.Green;
            this.lWelcomeSub.Location = new System.Drawing.Point(239, 389);
            this.lWelcomeSub.Name = "lWelcomeSub";
            this.lWelcomeSub.Size = new System.Drawing.Size(806, 35);
            this.lWelcomeSub.TabIndex = 14;
            this.lWelcomeSub.Text = "Application de gestion administration de l\'école FSI";
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.ForeColor = System.Drawing.Color.Green;
            this.lWelcome.Location = new System.Drawing.Point(362, 310);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(175, 35);
            this.lWelcome.TabIndex = 13;
            this.lWelcome.Text = "Bienvenue";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 624);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.PanelInterieur);
            this.Controls.Add(this.PanelLogo);
            this.Controls.Add(this.PanelMenu);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Accueil";
            this.Text = "FSI Notes - Accueil";
            this.PanelMenu.ResumeLayout(false);
            this.PanelMenu.PerformLayout();
            this.msGlobal.ResumeLayout(false);
            this.msGlobal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.PanelInterieur.ResumeLayout(false);
            this.PanelInterieur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.MenuStrip msGlobal;
        //      private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gestionEtudiantToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeDesEtudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnEtudiantToolStripMenuItem;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        //     private System.Windows.Forms.Button bDeConnexion;
        private System.Windows.Forms.Panel PanelInterieur;
        //    private System.Windows.Forms.Label lTexteBienvenue;
        //     private System.Windows.Forms.Label lBienvenue;
        private System.Windows.Forms.Label lWelcomeSub;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneClasseToolStripMenuItem;
        private System.Windows.Forms.Label tbUser;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnÉtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerUnCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUneClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnÉtudiantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnCoursToolStripMenuItem;
        //    private System.Windows.Forms.Label tbUserConnecte2;
    }
}

