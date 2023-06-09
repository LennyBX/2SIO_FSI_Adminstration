namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ModifierCours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierCours));
            this.label2 = new System.Windows.Forms.Label();
            this.lLibelle = new System.Windows.Forms.Label();
            this.tbLibelleCours = new System.Windows.Forms.TextBox();
            this.tbDescriptionCour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbListeClasse = new System.Windows.Forms.ComboBox();
            this.cbListeCours = new System.Windows.Forms.ComboBox();
            this.bBack = new System.Windows.Forms.Button();
            this.bModify = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(279, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 35);
            this.label2.TabIndex = 23;
            this.label2.Text = "Description";
            // 
            // lLibelle
            // 
            this.lLibelle.AutoSize = true;
            this.lLibelle.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLibelle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lLibelle.Location = new System.Drawing.Point(338, 159);
            this.lLibelle.Name = "lLibelle";
            this.lLibelle.Size = new System.Drawing.Size(118, 35);
            this.lLibelle.TabIndex = 22;
            this.lLibelle.Text = "Libelle";
            // 
            // tbLibelleCours
            // 
            this.tbLibelleCours.Location = new System.Drawing.Point(497, 168);
            this.tbLibelleCours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLibelleCours.Name = "tbLibelleCours";
            this.tbLibelleCours.Size = new System.Drawing.Size(300, 26);
            this.tbLibelleCours.TabIndex = 21;
            // 
            // tbDescriptionCour
            // 
            this.tbDescriptionCour.Location = new System.Drawing.Point(510, 270);
            this.tbDescriptionCour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescriptionCour.Name = "tbDescriptionCour";
            this.tbDescriptionCour.Size = new System.Drawing.Size(522, 26);
            this.tbDescriptionCour.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(320, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Classe";
            // 
            // cbListeClasse
            // 
            this.cbListeClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeClasse.FormattingEnabled = true;
            this.cbListeClasse.Location = new System.Drawing.Point(510, 391);
            this.cbListeClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbListeClasse.MinimumSize = new System.Drawing.Size(300, 0);
            this.cbListeClasse.Name = "cbListeClasse";
            this.cbListeClasse.Size = new System.Drawing.Size(404, 28);
            this.cbListeClasse.TabIndex = 18;
            // 
            // cbListeCours
            // 
            this.cbListeCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeCours.FormattingEnabled = true;
            this.cbListeCours.Location = new System.Drawing.Point(20, 159);
            this.cbListeCours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListeCours.Name = "cbListeCours";
            this.cbListeCours.Size = new System.Drawing.Size(238, 28);
            this.cbListeCours.TabIndex = 24;
            this.cbListeCours.SelectedIndexChanged += new System.EventHandler(this.cbListeCours_SelectedIndexChanged);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.DarkGreen;
            this.bBack.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.Transparent;
            this.bBack.Location = new System.Drawing.Point(20, 478);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(141, 66);
            this.bBack.TabIndex = 28;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bModify
            // 
            this.bModify.BackColor = System.Drawing.Color.DarkGreen;
            this.bModify.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModify.ForeColor = System.Drawing.Color.Ivory;
            this.bModify.Location = new System.Drawing.Point(510, 475);
            this.bModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(154, 72);
            this.bModify.TabIndex = 27;
            this.bModify.Text = "Modifier";
            this.bModify.UseVisualStyleBackColor = false;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(445, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Modifier un Cours";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 32);
            this.label4.TabIndex = 30;
            this.label4.Text = "Choisir un cours";
            // 
            // ModifierCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 562);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bModify);
            this.Controls.Add(this.cbListeCours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lLibelle);
            this.Controls.Add(this.tbLibelleCours);
            this.Controls.Add(this.tbDescriptionCour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbListeClasse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifierCours";
            this.Text = "FSI Notes - Update Cour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lLibelle;
        private System.Windows.Forms.TextBox tbLibelleCours;
        private System.Windows.Forms.TextBox tbDescriptionCour;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbListeClasse;
        private System.Windows.Forms.ComboBox cbListeCours;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}