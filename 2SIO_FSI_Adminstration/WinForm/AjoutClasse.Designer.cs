namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutClasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutClasse));
            this.tbLibelleClasse = new System.Windows.Forms.TextBox();
            this.bBack = new System.Windows.Forms.Button();
            this.bConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLibelleClasse
            // 
            this.tbLibelleClasse.Location = new System.Drawing.Point(247, 209);
            this.tbLibelleClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLibelleClasse.Name = "tbLibelleClasse";
            this.tbLibelleClasse.Size = new System.Drawing.Size(200, 26);
            this.tbLibelleClasse.TabIndex = 0;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.Honeydew;
            this.bBack.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.DarkGreen;
            this.bBack.Location = new System.Drawing.Point(338, 349);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(194, 68);
            this.bBack.TabIndex = 8;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bConfirm
            // 
            this.bConfirm.BackColor = System.Drawing.Color.Honeydew;
            this.bConfirm.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConfirm.ForeColor = System.Drawing.Color.DarkGreen;
            this.bConfirm.Location = new System.Drawing.Point(60, 349);
            this.bConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(194, 68);
            this.bConfirm.TabIndex = 9;
            this.bConfirm.Text = "Ajouter";
            this.bConfirm.UseVisualStyleBackColor = false;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(138, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ajouter votre classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(42, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nom Classe";
            // 
            // AjoutClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.tbLibelleClasse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AjoutClasse";
            this.Text = "AjoutClasse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLibelleClasse;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}