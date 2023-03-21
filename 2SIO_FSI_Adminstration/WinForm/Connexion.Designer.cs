namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.lMDP = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.bConnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(11, 9);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(165, 148);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLogin.ForeColor = System.Drawing.Color.Green;
            this.lLogin.Location = new System.Drawing.Point(258, 24);
            this.lLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(85, 27);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Login";
            // 
            // lMDP
            // 
            this.lMDP.AutoSize = true;
            this.lMDP.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMDP.ForeColor = System.Drawing.Color.Green;
            this.lMDP.Location = new System.Drawing.Point(186, 66);
            this.lMDP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMDP.Name = "lMDP";
            this.lMDP.Size = new System.Drawing.Size(158, 26);
            this.lMDP.TabIndex = 2;
            this.lMDP.Text = "Mot de passe";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(348, 17);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(196, 34);
            this.tbLogin.TabIndex = 3;
            // 
            // tbMdp
            // 
            this.tbMdp.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMdp.Location = new System.Drawing.Point(348, 55);
            this.tbMdp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '*';
            this.tbMdp.Size = new System.Drawing.Size(196, 34);
            this.tbMdp.TabIndex = 4;
            // 
            // bConnexion
            // 
            this.bConnexion.BackColor = System.Drawing.Color.Green;
            this.bConnexion.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConnexion.ForeColor = System.Drawing.Color.Transparent;
            this.bConnexion.Location = new System.Drawing.Point(427, 121);
            this.bConnexion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bConnexion.Name = "bConnexion";
            this.bConnexion.Size = new System.Drawing.Size(166, 36);
            this.bConnexion.TabIndex = 5;
            this.bConnexion.Text = "Connexion";
            this.bConnexion.UseVisualStyleBackColor = false;
            this.bConnexion.Click += new System.EventHandler(this.bConnexion_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 169);
            this.Controls.Add(this.bConnexion);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lMDP);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Connexion";
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lMDP;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button bConnexion;
 
    }
}