namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class ModifierClasse
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
            this.cbListeClasse = new System.Windows.Forms.ComboBox();
            this.bModify = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbAcronyme = new System.Windows.Forms.TextBox();
            this.lLibelle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbListeClasse
            // 
            this.cbListeClasse.FormattingEnabled = true;
            this.cbListeClasse.Location = new System.Drawing.Point(41, 58);
            this.cbListeClasse.Name = "cbListeClasse";
            this.cbListeClasse.Size = new System.Drawing.Size(267, 24);
            this.cbListeClasse.TabIndex = 0;
            this.cbListeClasse.SelectedIndexChanged += new System.EventHandler(this.cbListeClasse_SelectedIndexChanged);
            // 
            // bModify
            // 
            this.bModify.Location = new System.Drawing.Point(41, 185);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(102, 50);
            this.bModify.TabIndex = 1;
            this.bModify.Text = "Modifier";
            this.bModify.UseVisualStyleBackColor = true;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(725, 185);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(102, 50);
            this.bBack.TabIndex = 2;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(483, 55);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(344, 22);
            this.tbLibelle.TabIndex = 3;
            // 
            // tbAcronyme
            // 
            this.tbAcronyme.Location = new System.Drawing.Point(483, 106);
            this.tbAcronyme.Name = "tbAcronyme";
            this.tbAcronyme.Size = new System.Drawing.Size(140, 22);
            this.tbAcronyme.TabIndex = 4;
            // 
            // lLibelle
            // 
            this.lLibelle.AutoSize = true;
            this.lLibelle.Location = new System.Drawing.Point(397, 61);
            this.lLibelle.Name = "lLibelle";
            this.lLibelle.Size = new System.Drawing.Size(47, 16);
            this.lLibelle.TabIndex = 5;
            this.lLibelle.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Acronyme";
            // 
            // ModifierClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lLibelle);
            this.Controls.Add(this.tbAcronyme);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bModify);
            this.Controls.Add(this.cbListeClasse);
            this.Name = "ModifierClasse";
            this.Text = "ModifierClasse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListeClasse;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbAcronyme;
        private System.Windows.Forms.Label lLibelle;
        private System.Windows.Forms.Label label1;
    }
}