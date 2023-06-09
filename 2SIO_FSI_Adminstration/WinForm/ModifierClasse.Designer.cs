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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifierClasse));
            this.cbListeClasse = new System.Windows.Forms.ComboBox();
            this.bModify = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbAcronyme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lLibelle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbListeClasse
            // 
            this.cbListeClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeClasse.FormattingEnabled = true;
            this.cbListeClasse.Location = new System.Drawing.Point(24, 154);
            this.cbListeClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListeClasse.Name = "cbListeClasse";
            this.cbListeClasse.Size = new System.Drawing.Size(300, 28);
            this.cbListeClasse.TabIndex = 0;
            this.cbListeClasse.SelectedIndexChanged += new System.EventHandler(this.cbListeClasse_SelectedIndexChanged);
            // 
            // bModify
            // 
            this.bModify.BackColor = System.Drawing.Color.DarkGreen;
            this.bModify.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bModify.Location = new System.Drawing.Point(24, 299);
            this.bModify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(138, 62);
            this.bModify.TabIndex = 1;
            this.bModify.Text = "Modifier";
            this.bModify.UseVisualStyleBackColor = false;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.DarkGreen;
            this.bBack.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.White;
            this.bBack.Location = new System.Drawing.Point(820, 299);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(136, 62);
            this.bBack.TabIndex = 2;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(546, 150);
            this.tbLibelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(386, 26);
            this.tbLibelle.TabIndex = 3;
            // 
            // tbAcronyme
            // 
            this.tbAcronyme.Location = new System.Drawing.Point(546, 232);
            this.tbAcronyme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAcronyme.Name = "tbAcronyme";
            this.tbAcronyme.Size = new System.Drawing.Size(157, 26);
            this.tbAcronyme.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(345, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "Modifier une Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Choisir une Classe";
            // 
            // lLibelle
            // 
            this.lLibelle.AutoSize = true;
            this.lLibelle.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLibelle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lLibelle.Location = new System.Drawing.Point(400, 141);
            this.lLibelle.Name = "lLibelle";
            this.lLibelle.Size = new System.Drawing.Size(118, 35);
            this.lLibelle.TabIndex = 32;
            this.lLibelle.Text = "Libelle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(354, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 35);
            this.label4.TabIndex = 33;
            this.label4.Text = "Acronyme";
            // 
            // ModifierClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAcronyme);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bModify);
            this.Controls.Add(this.cbListeClasse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModifierClasse";
            this.Text = "FSI Notes - Update Classe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListeClasse;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbAcronyme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lLibelle;
        private System.Windows.Forms.Label label4;
    }
}