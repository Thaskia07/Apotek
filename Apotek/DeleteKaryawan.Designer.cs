namespace Apotek
{
    partial class DeleteKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteKaryawan));
            this.PcF = new Guna.UI2.WinForms.Guna2PictureBox();
            this.apotek = new System.Windows.Forms.Label();
            this.GbDelete = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDeleteKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdKaryawan = new Guna.UI2.WinForms.Guna2TextBox();
            this.id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).BeginInit();
            this.GbDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // PcF
            // 
            this.PcF.Image = ((System.Drawing.Image)(resources.GetObject("PcF.Image")));
            this.PcF.ImageRotate = 0F;
            this.PcF.Location = new System.Drawing.Point(2, 2);
            this.PcF.Name = "PcF";
            this.PcF.Size = new System.Drawing.Size(217, 111);
            this.PcF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcF.TabIndex = 0;
            this.PcF.TabStop = false;
            // 
            // apotek
            // 
            this.apotek.AutoSize = true;
            this.apotek.BackColor = System.Drawing.Color.Transparent;
            this.apotek.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apotek.Location = new System.Drawing.Point(24, 116);
            this.apotek.Name = "apotek";
            this.apotek.Size = new System.Drawing.Size(172, 27);
            this.apotek.TabIndex = 4;
            this.apotek.Text = "Apotek Nakii";
            // 
            // GbDelete
            // 
            this.GbDelete.Controls.Add(this.BtnBack);
            this.GbDelete.Controls.Add(this.BtnDeleteKaryawan);
            this.GbDelete.Controls.Add(this.txtIdKaryawan);
            this.GbDelete.Controls.Add(this.id);
            this.GbDelete.CustomBorderColor = System.Drawing.Color.Lavender;
            this.GbDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GbDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GbDelete.Location = new System.Drawing.Point(41, 243);
            this.GbDelete.MaximumSize = new System.Drawing.Size(512, 266);
            this.GbDelete.MinimumSize = new System.Drawing.Size(512, 266);
            this.GbDelete.Name = "GbDelete";
            this.GbDelete.Size = new System.Drawing.Size(512, 266);
            this.GbDelete.TabIndex = 8;
            this.GbDelete.Text = "Delete Data Karyawan";
            // 
            // BtnBack
            // 
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(281, 178);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(131, 42);
            this.BtnBack.TabIndex = 12;
            this.BtnBack.Text = "Back";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // BtnDeleteKaryawan
            // 
            this.BtnDeleteKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteKaryawan.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteKaryawan.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteKaryawan.Location = new System.Drawing.Point(47, 178);
            this.BtnDeleteKaryawan.Name = "BtnDeleteKaryawan";
            this.BtnDeleteKaryawan.Size = new System.Drawing.Size(131, 42);
            this.BtnDeleteKaryawan.TabIndex = 11;
            this.BtnDeleteKaryawan.Text = "Delete Data Karyawan";
            this.BtnDeleteKaryawan.Click += new System.EventHandler(this.BtnDeleteKaryawan_Click_1);
            // 
            // txtIdKaryawan
            // 
            this.txtIdKaryawan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdKaryawan.DefaultText = "";
            this.txtIdKaryawan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdKaryawan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdKaryawan.FillColor = System.Drawing.Color.SeaShell;
            this.txtIdKaryawan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdKaryawan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtIdKaryawan.ForeColor = System.Drawing.Color.Black;
            this.txtIdKaryawan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdKaryawan.Location = new System.Drawing.Point(216, 87);
            this.txtIdKaryawan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdKaryawan.Name = "txtIdKaryawan";
            this.txtIdKaryawan.PasswordChar = '\0';
            this.txtIdKaryawan.PlaceholderText = "";
            this.txtIdKaryawan.SelectedText = "";
            this.txtIdKaryawan.Size = new System.Drawing.Size(223, 36);
            this.txtIdKaryawan.TabIndex = 10;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.BackColor = System.Drawing.Color.Transparent;
            this.id.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(49, 87);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(149, 24);
            this.id.TabIndex = 9;
            this.id.Text = "Id Karyawan :";
            // 
            // DeleteKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.GbDelete);
            this.Controls.Add(this.apotek);
            this.Controls.Add(this.PcF);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "DeleteKaryawan";
            this.Text = "DeleteKaryawan";
            this.Load += new System.EventHandler(this.DeleteKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).EndInit();
            this.GbDelete.ResumeLayout(false);
            this.GbDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PcF;
        private System.Windows.Forms.Label apotek;
        private Guna.UI2.WinForms.Guna2GroupBox GbDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtIdKaryawan;
        private System.Windows.Forms.Label id;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteKaryawan;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
    }
}