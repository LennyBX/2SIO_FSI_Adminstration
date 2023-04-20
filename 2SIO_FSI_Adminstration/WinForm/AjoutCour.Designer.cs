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
            this.bAddCour = new System.Windows.Forms.Button();
            this.bClearText = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.cbCour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDesCour = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAddCour
            // 
            this.bAddCour.BackColor = System.Drawing.Color.Honeydew;
            this.bAddCour.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddCour.ForeColor = System.Drawing.Color.DarkGreen;
            this.bAddCour.Location = new System.Drawing.Point(320, 427);
            this.bAddCour.Name = "bAddCour";
            this.bAddCour.Size = new System.Drawing.Size(174, 55);
            this.bAddCour.TabIndex = 7;
            this.bAddCour.Text = "Ajouter";
            this.bAddCour.UseVisualStyleBackColor = false;
            // 
            // bClearText
            // 
            this.bClearText.BackColor = System.Drawing.Color.Honeydew;
            this.bClearText.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClearText.ForeColor = System.Drawing.Color.DarkGreen;
            this.bClearText.Location = new System.Drawing.Point(729, 351);
            this.bClearText.Name = "bClearText";
            this.bClearText.Size = new System.Drawing.Size(172, 55);
            this.bClearText.TabIndex = 10;
            this.bClearText.Text = "Effacer";
            this.bClearText.UseVisualStyleBackColor = false;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.Honeydew;
            this.bBack.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.DarkGreen;
            this.bBack.Location = new System.Drawing.Point(729, 427);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(175, 55);
            this.bBack.TabIndex = 11;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            // 
            // cbCour
            // 
            this.cbCour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCour.FormattingEnabled = true;
            this.cbCour.Location = new System.Drawing.Point(302, 317);
            this.cbCour.MinimumSize = new System.Drawing.Size(300, 0);
            this.cbCour.Name = "cbCour";
            this.cbCour.Size = new System.Drawing.Size(326, 28);
            this.cbCour.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(136, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "Classe";
            // 
            // tbDesCour
            // 
            this.tbDesCour.Location = new System.Drawing.Point(302, 132);
            this.tbDesCour.MinimumSize = new System.Drawing.Size(300, 130);
            this.tbDesCour.Name = "tbDesCour";
            this.tbDesCour.Size = new System.Drawing.Size(519, 130);
            this.tbDesCour.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(302, 52);
            this.textBox1.MinimumSize = new System.Drawing.Size(300, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 50);
            this.textBox1.TabIndex = 15;
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(171, 52);
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
            this.label2.Location = new System.Drawing.Point(94, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Description";
            // 
            // AjoutCour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbDesCour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCour);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bClearText);
            this.Controls.Add(this.bAddCour);
            this.Name = "AjoutCour";
            this.Text = "AjoutCour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddCour;
        private System.Windows.Forms.Button bClearText;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDesCour;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbCour;
    }
}