﻿namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class SupprEtudiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprEtudiant));
            this.cbListeEtudiant = new System.Windows.Forms.ComboBox();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbListeEtudiant
            // 
            this.cbListeEtudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeEtudiant.FormattingEnabled = true;
            this.cbListeEtudiant.Location = new System.Drawing.Point(231, 154);
            this.cbListeEtudiant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListeEtudiant.Name = "cbListeEtudiant";
            this.cbListeEtudiant.Size = new System.Drawing.Size(260, 28);
            this.cbListeEtudiant.TabIndex = 0;
            // 
            // bSupprimer
            // 
            this.bSupprimer.BackColor = System.Drawing.Color.DarkGreen;
            this.bSupprimer.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupprimer.ForeColor = System.Drawing.Color.Ivory;
            this.bSupprimer.Location = new System.Drawing.Point(276, 249);
            this.bSupprimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(177, 72);
            this.bSupprimer.TabIndex = 1;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = false;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.DarkGreen;
            this.bBack.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.Transparent;
            this.bBack.Location = new System.Drawing.Point(558, 342);
            this.bBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(143, 62);
            this.bBack.TabIndex = 2;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(164, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Suprimmez votre Etudiant";
            // 
            // SupprEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.cbListeEtudiant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SupprEtudiant";
            this.Text = "FSI Notes - Supprimer un étudiant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbListeEtudiant;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.Label label1;
    }
}