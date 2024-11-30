namespace Apotek
{
    partial class Pencarian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pencarian));
            this.PcF = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Id = new System.Windows.Forms.Label();
            this.IdR = new System.Windows.Forms.Label();
            this.txtIdResep = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdPasien = new Guna.UI2.WinForms.Guna2TextBox();
            this.TglResep = new System.Windows.Forms.Label();
            this.txtTglResep = new Guna.UI2.WinForms.Guna2TextBox();
            this.Apotek = new System.Windows.Forms.Label();
            this.BtnCari = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).BeginInit();
            this.SuspendLayout();
            // 
            // PcF
            // 
            this.PcF.Image = ((System.Drawing.Image)(resources.GetObject("PcF.Image")));
            this.PcF.ImageRotate = 0F;
            this.PcF.Location = new System.Drawing.Point(1, 12);
            this.PcF.Name = "PcF";
            this.PcF.Size = new System.Drawing.Size(186, 116);
            this.PcF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcF.TabIndex = 0;
            this.PcF.TabStop = false;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.LightSteelBlue;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(551, 41);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(267, 36);
            this.guna2DateTimePicker1.TabIndex = 5;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 11, 23, 22, 49, 8, 148);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.BackColor = System.Drawing.Color.AliceBlue;
            this.Id.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(157, 229);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(106, 36);
            this.Id.TabIndex = 6;
            this.Id.Text = "Id Resep :";
            // 
            // IdR
            // 
            this.IdR.AutoSize = true;
            this.IdR.BackColor = System.Drawing.Color.AliceBlue;
            this.IdR.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdR.Location = new System.Drawing.Point(157, 295);
            this.IdR.Name = "IdR";
            this.IdR.Size = new System.Drawing.Size(105, 36);
            this.IdR.TabIndex = 7;
            this.IdR.Text = "Id Pasien:";
            // 
            // txtIdResep
            // 
            this.txtIdResep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdResep.DefaultText = "";
            this.txtIdResep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdResep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdResep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdResep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdResep.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdResep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdResep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdResep.ForeColor = System.Drawing.Color.Black;
            this.txtIdResep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdResep.Location = new System.Drawing.Point(372, 229);
            this.txtIdResep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdResep.Name = "txtIdResep";
            this.txtIdResep.PasswordChar = '\0';
            this.txtIdResep.PlaceholderText = "";
            this.txtIdResep.SelectedText = "";
            this.txtIdResep.Size = new System.Drawing.Size(286, 36);
            this.txtIdResep.TabIndex = 9;
            // 
            // txtIdPasien
            // 
            this.txtIdPasien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdPasien.DefaultText = "";
            this.txtIdPasien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdPasien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdPasien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPasien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdPasien.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdPasien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPasien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdPasien.ForeColor = System.Drawing.Color.Black;
            this.txtIdPasien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdPasien.Location = new System.Drawing.Point(372, 295);
            this.txtIdPasien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdPasien.Name = "txtIdPasien";
            this.txtIdPasien.PasswordChar = '\0';
            this.txtIdPasien.PlaceholderText = "";
            this.txtIdPasien.SelectedText = "";
            this.txtIdPasien.Size = new System.Drawing.Size(286, 36);
            this.txtIdPasien.TabIndex = 10;
            // 
            // TglResep
            // 
            this.TglResep.AutoSize = true;
            this.TglResep.BackColor = System.Drawing.Color.AliceBlue;
            this.TglResep.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TglResep.Location = new System.Drawing.Point(157, 354);
            this.TglResep.Name = "TglResep";
            this.TglResep.Size = new System.Drawing.Size(164, 36);
            this.TglResep.TabIndex = 8;
            this.TglResep.Text = "Tanggal Resep :";
            // 
            // txtTglResep
            // 
            this.txtTglResep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTglResep.DefaultText = "";
            this.txtTglResep.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTglResep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTglResep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTglResep.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTglResep.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTglResep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTglResep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTglResep.ForeColor = System.Drawing.Color.Black;
            this.txtTglResep.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTglResep.Location = new System.Drawing.Point(372, 354);
            this.txtTglResep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTglResep.Name = "txtTglResep";
            this.txtTglResep.PasswordChar = '\0';
            this.txtTglResep.PlaceholderText = "";
            this.txtTglResep.SelectedText = "";
            this.txtTglResep.Size = new System.Drawing.Size(286, 36);
            this.txtTglResep.TabIndex = 11;
            // 
            // Apotek
            // 
            this.Apotek.AutoSize = true;
            this.Apotek.BackColor = System.Drawing.Color.Transparent;
            this.Apotek.Font = new System.Drawing.Font("Edwardian Script ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apotek.Location = new System.Drawing.Point(30, 131);
            this.Apotek.Name = "Apotek";
            this.Apotek.Size = new System.Drawing.Size(182, 43);
            this.Apotek.TabIndex = 14;
            this.Apotek.Text = "Apotek Nakii";
            // 
            // BtnCari
            // 
            this.BtnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCari.FillColor = System.Drawing.Color.MediumBlue;
            this.BtnCari.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnCari.ForeColor = System.Drawing.Color.White;
            this.BtnCari.Location = new System.Drawing.Point(481, 423);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(130, 50);
            this.BtnCari.TabIndex = 15;
            this.BtnCari.Text = "Cari";
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click_1);
            // 
            // BtnBack
            // 
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.FillColor = System.Drawing.Color.MediumBlue;
            this.BtnBack.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(680, 423);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(138, 53);
            this.BtnBack.TabIndex = 16;
            this.BtnBack.Text = "Back";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // Pencarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 508);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.Apotek);
            this.Controls.Add(this.txtTglResep);
            this.Controls.Add(this.txtIdPasien);
            this.Controls.Add(this.txtIdResep);
            this.Controls.Add(this.TglResep);
            this.Controls.Add(this.IdR);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.PcF);
            this.MaximumSize = new System.Drawing.Size(896, 564);
            this.MinimumSize = new System.Drawing.Size(896, 564);
            this.Name = "Pencarian";
            this.Text = "Pencarian";
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PcF;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label IdR;
        private Guna.UI2.WinForms.Guna2TextBox txtIdResep;
        private Guna.UI2.WinForms.Guna2TextBox txtIdPasien;
        private System.Windows.Forms.Label TglResep;
        private Guna.UI2.WinForms.Guna2TextBox txtTglResep;
        private System.Windows.Forms.Label Apotek;
        private Guna.UI2.WinForms.Guna2Button BtnCari;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
    }
}