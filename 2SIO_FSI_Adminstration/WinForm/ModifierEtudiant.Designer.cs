namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ModifierEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierEtudiant));
            this.cbListeEtudiant = new System.Windows.Forms.ComboBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lMail = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lNumero = new System.Windows.Forms.Label();
            this.cbListeClasse = new System.Windows.Forms.ComboBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.bModify = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbListeEtudiant
            // 
            this.cbListeEtudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeEtudiant.FormattingEnabled = true;
            this.cbListeEtudiant.Location = new System.Drawing.Point(39, 207);
            this.cbListeEtudiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListeEtudiant.Name = "cbListeEtudiant";
            this.cbListeEtudiant.Size = new System.Drawing.Size(250, 28);
            this.cbListeEtudiant.TabIndex = 0;
            this.cbListeEtudiant.SelectedIndexChanged += new System.EventHandler(this.cbListeEtudiant_SelectedIndexChanged);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(1056, 238);
            this.tbMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(213, 26);
            this.tbMail.TabIndex = 24;
            // 
            // lMail
            // 
            this.lMail.AutoSize = true;
            this.lMail.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMail.ForeColor = System.Drawing.Color.DarkGreen;
            this.lMail.Location = new System.Drawing.Point(922, 229);
            this.lMail.Name = "lMail";
            this.lMail.Size = new System.Drawing.Size(81, 35);
            this.lMail.TabIndex = 23;
            this.lMail.Text = "Mail";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(1056, 136);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(213, 26);
            this.tbNumero.TabIndex = 22;
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumero.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNumero.Location = new System.Drawing.Point(884, 127);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(139, 35);
            this.lNumero.TabIndex = 21;
            this.lNumero.Text = "Numéro";
            // 
            // cbListeClasse
            // 
            this.cbListeClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeClasse.FormattingEnabled = true;
            this.cbListeClasse.Location = new System.Drawing.Point(562, 343);
            this.cbListeClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListeClasse.Name = "cbListeClasse";
            this.cbListeClasse.Size = new System.Drawing.Size(441, 28);
            this.cbListeClasse.TabIndex = 20;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(562, 229);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(213, 26);
            this.tbFirstName.TabIndex = 19;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(562, 136);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(213, 26);
            this.tbLastName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(407, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Classe";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrenom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lPrenom.Location = new System.Drawing.Point(393, 220);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(135, 35);
            this.lPrenom.TabIndex = 16;
            this.lPrenom.Text = "Prénom";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(441, 127);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(87, 35);
            this.lNom.TabIndex = 15;
            this.lNom.Text = "Nom";
            // 
            // bModify
            // 
            this.bModify.BackColor = System.Drawing.Color.DarkGreen;
            this.bModify.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModify.ForeColor = System.Drawing.Color.White;
            this.bModify.Location = new System.Drawing.Point(51, 421);
            this.bModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(175, 78);
            this.bModify.TabIndex = 25;
            this.bModify.Text = "Modifier";
            this.bModify.UseVisualStyleBackColor = false;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.DarkGreen;
            this.bBack.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.Transparent;
            this.bBack.Location = new System.Drawing.Point(1130, 421);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(153, 78);
            this.bBack.TabIndex = 26;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(512, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Modifier un Etudiant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Choisir un Etudiant";
            // 
            // ModifierEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bModify);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.lMail);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lNumero);
            this.Controls.Add(this.cbListeClasse);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.cbListeEtudiant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifierEtudiant";
            this.Text = "FSI Notes - Update Etudiant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListeEtudiant;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lMail;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.ComboBox cbListeClasse;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}