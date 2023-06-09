namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class SupprCour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupprCour));
            this.bClearText = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.cbListeCour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bClearText
            // 
            this.bClearText.BackColor = System.Drawing.Color.DarkGreen;
            this.bClearText.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClearText.ForeColor = System.Drawing.Color.Ivory;
            this.bClearText.Location = new System.Drawing.Point(268, 273);
            this.bClearText.Name = "bClearText";
            this.bClearText.Size = new System.Drawing.Size(210, 55);
            this.bClearText.TabIndex = 11;
            this.bClearText.Text = "Supprimer";
            this.bClearText.UseVisualStyleBackColor = false;
            this.bClearText.Click += new System.EventHandler(this.bClearText_Click);
            // 
            // bBack
            // 
            this.bBack.BackColor = System.Drawing.Color.DarkGreen;
            this.bBack.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBack.ForeColor = System.Drawing.Color.Ivory;
            this.bBack.Location = new System.Drawing.Point(584, 367);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(175, 55);
            this.bBack.TabIndex = 12;
            this.bBack.Text = "Retour";
            this.bBack.UseVisualStyleBackColor = false;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // cbListeCour
            // 
            this.cbListeCour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListeCour.FormattingEnabled = true;
            this.cbListeCour.Location = new System.Drawing.Point(223, 177);
            this.cbListeCour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbListeCour.Name = "cbListeCour";
            this.cbListeCour.Size = new System.Drawing.Size(351, 28);
            this.cbListeCour.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(226, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Suprimmez votre cours";
            // 
            // SupprCour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbListeCour);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bClearText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupprCour";
            this.Text = "FSI Notes - Suprimmer un Cour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClearText;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.ComboBox cbListeCour;
        private System.Windows.Forms.Label label1;
    }
}