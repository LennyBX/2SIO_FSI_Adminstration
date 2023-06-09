namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutCour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutCour));
            this.bAddCour = new System.Windows.Forms.Button();
            this.bClearText = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDesCour = new System.Windows.Forms.TextBox();
            this.TbNomCour = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAddCour
            // 
            this.bAddCour.BackColor = System.Drawing.Color.DarkGreen;
            this.bAddCour.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddCour.ForeColor = System.Drawing.Color.FloralWhite;
            this.bAddCour.Location = new System.Drawing.Point(357, 505);
            this.bAddCour.Name = "bAddCour";
            this.bAddCour.Size = new System.Drawing.Size(174, 55);
            this.bAddCour.TabIndex = 7;
            this.bAddCour.Text = "Ajouter";
            this.bAddCour.UseVisualStyleBackColor = false;
            this.bAddCour.Click += new System.EventHandler(this.bAddCour_Click);
            // 
            // bClearText
            // 
            this.bClearText.BackColor = System.Drawing.Color.DarkGreen;
            this.bClearText.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClearText.ForeColor = System.Drawing.Color.Ivory;
            this.bClearText.Location = new System.Drawing.Point(810, 457);
            this.bClearText.Name = "bClearText";
            this.bClearText.Size = new System.Drawing.Size(172, 55);
            this.bClearText.TabIndex = 10;
            this.bClearText.Text = "Effacer";
            this.bClearText.UseVisualStyleBackColor = false;
            this.bClearText.Click += new System.EventHandler(this.bClearText_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.DarkGreen;
            this.bBack.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.Ivory;
            this.bBack.Location = new System.Drawing.Point(807, 534);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(175, 55);
            this.bBack.TabIndex = 11;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // cbClasse
            // 
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(293, 370);
            this.cbClasse.MinimumSize = new System.Drawing.Size(300, 0);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(404, 28);
            this.cbClasse.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(132, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Classe";
            // 
            // tbDesCour
            // 
            this.tbDesCour.Location = new System.Drawing.Point(293, 253);
            this.tbDesCour.Name = "tbDesCour";
            this.tbDesCour.Size = new System.Drawing.Size(519, 26);
            this.tbDesCour.TabIndex = 14;
            // 
            // TbNomCour
            // 
            this.TbNomCour.Location = new System.Drawing.Point(311, 135);
            this.TbNomCour.Name = "TbNomCour";
            this.TbNomCour.Size = new System.Drawing.Size(300, 26);
            this.TbNomCour.TabIndex = 15;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(154, 126);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(87, 35);
            this.lNom.TabIndex = 16;
            this.lNom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(80, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(314, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 32);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ajouter votre cours";
            // 
            // AjoutCour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 618);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.TbNomCour);
            this.Controls.Add(this.tbDesCour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bClearText);
            this.Controls.Add(this.bAddCour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutCour";
            this.Text = "FSI Notes - Ajout Cours";
            this.Load += new System.EventHandler(this.AjoutCour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddCour;
        private System.Windows.Forms.Button bClearText;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDesCour;
        private System.Windows.Forms.TextBox TbNomCour;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Label label3;
    }
}