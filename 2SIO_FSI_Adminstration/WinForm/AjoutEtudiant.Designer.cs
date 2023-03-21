namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class AjoutEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutEtudiant));
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.bAddUser = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bClearText = new System.Windows.Forms.Button();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lNom.Location = new System.Drawing.Point(29, 60);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(70, 31);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.ForeColor = System.Drawing.Color.DarkGreen;
            this.lPrenom.Location = new System.Drawing.Point(29, 136);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(105, 31);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(29, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Classe";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(159, 57);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(190, 46);
            this.tbLastName.TabIndex = 3;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(159, 133);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(190, 46);
            this.tbFirstName.TabIndex = 4;
            // 
            // bAddUser
            // 
            this.bAddUser.BackColor = System.Drawing.Color.Honeydew;
            this.bAddUser.ForeColor = System.Drawing.Color.DarkGreen;
            this.bAddUser.Location = new System.Drawing.Point(35, 327);
            this.bAddUser.Name = "bAddUser";
            this.bAddUser.Size = new System.Drawing.Size(174, 55);
            this.bAddUser.TabIndex = 6;
            this.bAddUser.Text = "Ajouter";
            this.bAddUser.UseVisualStyleBackColor = false;
            this.bAddUser.Click += new System.EventHandler(this.bAddUser_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.Honeydew;
            this.bBack.ForeColor = System.Drawing.Color.DarkGreen;
            this.bBack.Location = new System.Drawing.Point(252, 417);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(172, 54);
            this.bBack.TabIndex = 7;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bClearText
            // 
            this.bClearText.BackColor = System.Drawing.Color.Honeydew;
            this.bClearText.ForeColor = System.Drawing.Color.DarkGreen;
            this.bClearText.Location = new System.Drawing.Point(252, 327);
            this.bClearText.Name = "bClearText";
            this.bClearText.Size = new System.Drawing.Size(172, 55);
            this.bClearText.TabIndex = 9;
            this.bClearText.Text = "Effacer";
            this.bClearText.UseVisualStyleBackColor = false;
            this.bClearText.Click += new System.EventHandler(this.bClearText_Click);
            // 
            // cbClasse
            // 
            this.cbClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Location = new System.Drawing.Point(159, 208);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(190, 39);
            this.cbClasse.TabIndex = 10;
            // 
            // AjoutEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 492);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.bClearText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bAddUser);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AjoutEtudiant";
            this.Text = "Ajouter un étudiant";
            this.Load += new System.EventHandler(this.AjoutEtudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button bAddUser;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bClearText;
        private System.Windows.Forms.ComboBox cbClasse;
    //    private P2022_Appli_AdministrationDataSet1TableAdapters.classeTableAdapter classeTableAdapter;
    }
}