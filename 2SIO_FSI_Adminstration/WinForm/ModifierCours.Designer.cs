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
            this.label2 = new System.Windows.Forms.Label();
            this.lLibelle = new System.Windows.Forms.Label();
            this.tbLibelleCours = new System.Windows.Forms.TextBox();
            this.tbDescriptionCour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbListeClasse = new System.Windows.Forms.ComboBox();
            this.cbListeCours = new System.Windows.Forms.ComboBox();
            this.bBack = new System.Windows.Forms.Button();
            this.bModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(284, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Description";
            // 
            // lLibelle
            // 
            this.lLibelle.AutoSize = true;
            this.lLibelle.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLibelle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lLibelle.Location = new System.Drawing.Point(296, 101);
            this.lLibelle.Name = "lLibelle";
            this.lLibelle.Size = new System.Drawing.Size(98, 29);
            this.lLibelle.TabIndex = 22;
            this.lLibelle.Text = "Libelle";
            // 
            // tbLibelleCours
            // 
            this.tbLibelleCours.Location = new System.Drawing.Point(453, 80);
            this.tbLibelleCours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLibelleCours.MinimumSize = new System.Drawing.Size(267, 50);
            this.tbLibelleCours.Name = "tbLibelleCours";
            this.tbLibelleCours.Size = new System.Drawing.Size(267, 22);
            this.tbLibelleCours.TabIndex = 21;
            // 
            // tbDescriptionCour
            // 
            this.tbDescriptionCour.Location = new System.Drawing.Point(453, 155);
            this.tbDescriptionCour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescriptionCour.MinimumSize = new System.Drawing.Size(267, 130);
            this.tbDescriptionCour.Name = "tbDescriptionCour";
            this.tbDescriptionCour.Size = new System.Drawing.Size(464, 130);
            this.tbDescriptionCour.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(284, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Classe";
            // 
            // cbListeClasse
            // 
            this.cbListeClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeClasse.FormattingEnabled = true;
            this.cbListeClasse.Location = new System.Drawing.Point(453, 313);
            this.cbListeClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbListeClasse.MinimumSize = new System.Drawing.Size(267, 0);
            this.cbListeClasse.Name = "cbListeClasse";
            this.cbListeClasse.Size = new System.Drawing.Size(360, 24);
            this.cbListeClasse.TabIndex = 18;
            // 
            // cbListeCours
            // 
            this.cbListeCours.FormattingEnabled = true;
            this.cbListeCours.Location = new System.Drawing.Point(24, 68);
            this.cbListeCours.Name = "cbListeCours";
            this.cbListeCours.Size = new System.Drawing.Size(212, 24);
            this.cbListeCours.TabIndex = 24;
            this.cbListeCours.SelectedIndexChanged += new System.EventHandler(this.cbListeCours_SelectedIndexChanged);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(851, 388);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(102, 50);
            this.bBack.TabIndex = 28;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bModify
            // 
            this.bModify.Location = new System.Drawing.Point(18, 377);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(102, 50);
            this.bModify.TabIndex = 27;
            this.bModify.Text = "Modifier";
            this.bModify.UseVisualStyleBackColor = true;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // ModifierCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bModify);
            this.Controls.Add(this.cbListeCours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lLibelle);
            this.Controls.Add(this.tbLibelleCours);
            this.Controls.Add(this.tbDescriptionCour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbListeClasse);
            this.Name = "ModifierCours";
            this.Text = "ModifierCours";
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
    }
}