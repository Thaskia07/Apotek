namespace Apotek
{
    partial class DeletePenjualan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePenjualan));
            this.PcF = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Apotek = new System.Windows.Forms.Label();
            this.GbDelete = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdPenjualan = new Guna.UI2.WinForms.Guna2TextBox();
            this.Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).BeginInit();
            this.GbDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // PcF
            // 
            this.PcF.Image = ((System.Drawing.Image)(resources.GetObject("PcF.Image")));
            this.PcF.ImageRotate = 0F;
            this.PcF.Location = new System.Drawing.Point(-1, -3);
            this.PcF.Name = "PcF";
            this.PcF.Size = new System.Drawing.Size(185, 139);
            this.PcF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcF.TabIndex = 0;
            this.PcF.TabStop = false;
            // 
            // Apotek
            // 
            this.Apotek.AutoSize = true;
            this.Apotek.BackColor = System.Drawing.Color.Transparent;
            this.Apotek.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apotek.Location = new System.Drawing.Point(12, 139);
            this.Apotek.Name = "Apotek";
            this.Apotek.Size = new System.Drawing.Size(184, 28);
            this.Apotek.TabIndex = 4;
            this.Apotek.Text = "Apotek Nakii";
            // 
            // GbDelete
            // 
            this.GbDelete.Controls.Add(this.BtnBack);
            this.GbDelete.Controls.Add(this.BtnDelete);
            this.GbDelete.Controls.Add(this.txtIdPenjualan);
            this.GbDelete.Controls.Add(this.Id);
            this.GbDelete.CustomBorderColor = System.Drawing.Color.LightCoral;
            this.GbDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbDelete.ForeColor = System.Drawing.Color.Black;
            this.GbDelete.Location = new System.Drawing.Point(370, 228);
            this.GbDelete.MaximumSize = new System.Drawing.Size(446, 233);
            this.GbDelete.MinimumSize = new System.Drawing.Size(446, 233);
            this.GbDelete.Name = "GbDelete";
            this.GbDelete.Size = new System.Drawing.Size(446, 233);
            this.GbDelete.TabIndex = 5;
            this.GbDelete.Text = "Delete Penjualan";
            // 
            // BtnBack
            // 
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.FillColor = System.Drawing.Color.IndianRed;
            this.BtnBack.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(259, 131);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(118, 45);
            this.BtnBack.TabIndex = 5;
            this.BtnBack.Text = "Back";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.FillColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(76, 131);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(118, 45);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete ";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // txtIdPenjualan
            // 
            this.txtIdPenjualan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPenjualan.DefaultText = "";
            this.txtIdPenjualan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPenjualan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPenjualan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPenjualan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPenjualan.FillColor = System.Drawing.Color.IndianRed;
            this.txtIdPenjualan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPenjualan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPenjualan.ForeColor = System.Drawing.Color.Black;
            this.txtIdPenjualan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPenjualan.Location = new System.Drawing.Point(192, 79);
            this.txtIdPenjualan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPenjualan.Name = "txtIdPenjualan";
            this.txtIdPenjualan.PasswordChar = '\0';
            this.txtIdPenjualan.PlaceholderText = "";
            this.txtIdPenjualan.SelectedText = "";
            this.txtIdPenjualan.Size = new System.Drawing.Size(248, 24);
            this.txtIdPenjualan.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.Color.Black;
            this.Id.Location = new System.Drawing.Point(24, 79);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(151, 24);
            this.Id.TabIndex = 0;
            this.Id.Text = "Id Penjualan :";
            // 
            // DeletePenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 483);
            this.Controls.Add(this.GbDelete);
            this.Controls.Add(this.Apotek);
            this.Controls.Add(this.PcF);
            this.MaximumSize = new System.Drawing.Size(866, 539);
            this.MinimumSize = new System.Drawing.Size(866, 539);
            this.Name = "DeletePenjualan";
            this.Text = "DeletePenjualan";
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).EndInit();
            this.GbDelete.ResumeLayout(false);
            this.GbDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PcF;
        private System.Windows.Forms.Label Apotek;
        private Guna.UI2.WinForms.Guna2GroupBox GbDelete;
        private System.Windows.Forms.Label Id;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPenjualan;
        private Guna.UI2.WinForms.Guna2Button BtnDelete;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
    }
}