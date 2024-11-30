namespace Apotek
{
    partial class DeleteObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteObat));
            this.Apotek = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Id = new System.Windows.Forms.Label();
            this.txtIdObat = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbDelete = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.PcF = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GbDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).BeginInit();
            this.SuspendLayout();
            // 
            // Apotek
            // 
            this.Apotek.BackColor = System.Drawing.Color.Transparent;
            this.Apotek.Font = new System.Drawing.Font("Edwardian Script ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apotek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Apotek.Location = new System.Drawing.Point(212, 12);
            this.Apotek.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Apotek.Name = "Apotek";
            this.Apotek.Size = new System.Drawing.Size(149, 40);
            this.Apotek.TabIndex = 3;
            this.Apotek.Text = "Apotek Nakii";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.Color.Black;
            this.Id.Location = new System.Drawing.Point(22, 65);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(106, 25);
            this.Id.TabIndex = 4;
            this.Id.Text = "Id Obat :";
            // 
            // txtIdObat
            // 
            this.txtIdObat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdObat.DefaultText = "";
            this.txtIdObat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdObat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdObat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdObat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdObat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdObat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdObat.ForeColor = System.Drawing.Color.Black;
            this.txtIdObat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdObat.Location = new System.Drawing.Point(147, 65);
            this.txtIdObat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtIdObat.Name = "txtIdObat";
            this.txtIdObat.PasswordChar = '\0';
            this.txtIdObat.PlaceholderText = "";
            this.txtIdObat.SelectedText = "";
            this.txtIdObat.Size = new System.Drawing.Size(273, 25);
            this.txtIdObat.TabIndex = 9;
            // 
            // GbDelete
            // 
            this.GbDelete.Controls.Add(this.BtnBack);
            this.GbDelete.Controls.Add(this.BtnDelete);
            this.GbDelete.Controls.Add(this.txtIdObat);
            this.GbDelete.Controls.Add(this.Id);
            this.GbDelete.CustomBorderColor = System.Drawing.Color.White;
            this.GbDelete.FillColor = System.Drawing.Color.IndianRed;
            this.GbDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GbDelete.Location = new System.Drawing.Point(199, 291);
            this.GbDelete.MaximumSize = new System.Drawing.Size(456, 250);
            this.GbDelete.MinimumSize = new System.Drawing.Size(456, 250);
            this.GbDelete.Name = "GbDelete";
            this.GbDelete.Size = new System.Drawing.Size(456, 250);
            this.GbDelete.TabIndex = 16;
            this.GbDelete.Text = "Delete";
            // 
            // BtnBack
            // 
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.FillColor = System.Drawing.Color.Orange;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(272, 138);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(112, 41);
            this.BtnBack.TabIndex = 17;
            this.BtnBack.Text = "Back";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.Orange;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(92, 138);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 41);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // PcF
            // 
            this.PcF.Image = ((System.Drawing.Image)(resources.GetObject("PcF.Image")));
            this.PcF.ImageRotate = 0F;
            this.PcF.Location = new System.Drawing.Point(13, 12);
            this.PcF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PcF.Name = "PcF";
            this.PcF.Size = new System.Drawing.Size(191, 101);
            this.PcF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcF.TabIndex = 17;
            this.PcF.TabStop = false;
            // 
            // DeleteObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 553);
            this.Controls.Add(this.PcF);
            this.Controls.Add(this.GbDelete);
            this.Controls.Add(this.Apotek);
            this.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(859, 609);
            this.MinimumSize = new System.Drawing.Size(859, 609);
            this.Name = "DeleteObat";
            this.Text = "DeleteObat";
            this.Load += new System.EventHandler(this.DeleteObat_Load);
            this.GbDelete.ResumeLayout(false);
            this.GbDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel Apotek;
        private System.Windows.Forms.Label Id;
        private Guna.UI2.WinForms.Guna2TextBox txtIdObat;
        private Guna.UI2.WinForms.Guna2GroupBox GbDelete;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
        private Guna.UI2.WinForms.Guna2PictureBox PcF;
    }
}