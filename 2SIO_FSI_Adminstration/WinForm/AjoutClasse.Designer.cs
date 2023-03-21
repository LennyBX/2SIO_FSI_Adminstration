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
            this.SuspendLayout();
            // 
            // tbLibelleClasse
            // 
            this.tbLibelleClasse.Location = new System.Drawing.Point(54, 75);
            this.tbLibelleClasse.Name = "tbLibelleClasse";
            this.tbLibelleClasse.Size = new System.Drawing.Size(164, 22);
            this.tbLibelleClasse.TabIndex = 0;
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.Honeydew;
            this.bBack.ForeColor = System.Drawing.Color.DarkGreen;
            this.bBack.Location = new System.Drawing.Point(249, 154);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(172, 54);
            this.bBack.TabIndex = 8;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // bConfirm
            // 
            this.bConfirm.BackColor = System.Drawing.Color.Honeydew;
            this.bConfirm.ForeColor = System.Drawing.Color.DarkGreen;
            this.bConfirm.Location = new System.Drawing.Point(46, 154);
            this.bConfirm.Name = "bConfirm";
            this.bConfirm.Size = new System.Drawing.Size(172, 54);
            this.bConfirm.TabIndex = 9;
            this.bConfirm.Text = "Ajouter";
            this.bConfirm.UseVisualStyleBackColor = false;
            this.bConfirm.Click += new System.EventHandler(this.bConfirm_Click);
            // 
            // AjoutClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 263);
            this.Controls.Add(this.bConfirm);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.tbLibelleClasse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutClasse";
            this.Text = "AjoutClasse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLibelleClasse;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Button bConfirm;
    }
}