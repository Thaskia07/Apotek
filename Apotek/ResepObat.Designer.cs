namespace Apotek
{
    partial class ResepObat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResepObat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PcF = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtResepObat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnAddPasien = new Guna.UI2.WinForms.Guna2Button();
            this.BtnCariResep = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDetailResep = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResepObat)).BeginInit();
            this.SuspendLayout();
            // 
            // PcF
            // 
            this.PcF.Image = ((System.Drawing.Image)(resources.GetObject("PcF.Image")));
            this.PcF.ImageRotate = 0F;
            this.PcF.Location = new System.Drawing.Point(363, 12);
            this.PcF.Name = "PcF";
            this.PcF.Size = new System.Drawing.Size(191, 105);
            this.PcF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcF.TabIndex = 0;
            this.PcF.TabStop = false;
            // 
            // dtResepObat
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtResepObat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtResepObat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtResepObat.ColumnHeadersHeight = 4;
            this.dtResepObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtResepObat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtResepObat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtResepObat.Location = new System.Drawing.Point(23, 184);
            this.dtResepObat.MaximumSize = new System.Drawing.Size(858, 276);
            this.dtResepObat.MinimumSize = new System.Drawing.Size(858, 276);
            this.dtResepObat.Name = "dtResepObat";
            this.dtResepObat.RowHeadersVisible = false;
            this.dtResepObat.RowHeadersWidth = 62;
            this.dtResepObat.RowTemplate.Height = 28;
            this.dtResepObat.Size = new System.Drawing.Size(858, 276);
            this.dtResepObat.TabIndex = 1;
            this.dtResepObat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtResepObat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtResepObat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtResepObat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtResepObat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtResepObat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtResepObat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtResepObat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtResepObat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtResepObat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtResepObat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtResepObat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtResepObat.ThemeStyle.HeaderStyle.Height = 4;
            this.dtResepObat.ThemeStyle.ReadOnly = false;
            this.dtResepObat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtResepObat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtResepObat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtResepObat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtResepObat.ThemeStyle.RowsStyle.Height = 28;
            this.dtResepObat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtResepObat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BtnAddPasien
            // 
            this.BtnAddPasien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddPasien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddPasien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddPasien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddPasien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAddPasien.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnAddPasien.ForeColor = System.Drawing.Color.White;
            this.BtnAddPasien.Location = new System.Drawing.Point(69, 133);
            this.BtnAddPasien.Name = "BtnAddPasien";
            this.BtnAddPasien.Size = new System.Drawing.Size(179, 45);
            this.BtnAddPasien.TabIndex = 6;
            this.BtnAddPasien.Text = "Tambah Pasien";
            this.BtnAddPasien.Click += new System.EventHandler(this.BtnAddPasien_Click_1);
            // 
            // BtnCariResep
            // 
            this.BtnCariResep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCariResep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCariResep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCariResep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCariResep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCariResep.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCariResep.ForeColor = System.Drawing.Color.White;
            this.BtnCariResep.Location = new System.Drawing.Point(384, 133);
            this.BtnCariResep.Name = "BtnCariResep";
            this.BtnCariResep.Size = new System.Drawing.Size(142, 45);
            this.BtnCariResep.TabIndex = 7;
            this.BtnCariResep.Text = "Cari Resep";
            this.BtnCariResep.Click += new System.EventHandler(this.BtnCariResep_Click_1);
            // 
            // BtnDetailResep
            // 
            this.BtnDetailResep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDetailResep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDetailResep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDetailResep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDetailResep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDetailResep.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnDetailResep.ForeColor = System.Drawing.Color.White;
            this.BtnDetailResep.Location = new System.Drawing.Point(681, 133);
            this.BtnDetailResep.Name = "BtnDetailResep";
            this.BtnDetailResep.PressedColor = System.Drawing.Color.Aqua;
            this.BtnDetailResep.Size = new System.Drawing.Size(142, 45);
            this.BtnDetailResep.TabIndex = 8;
            this.BtnDetailResep.Text = "Detail Resep";
            this.BtnDetailResep.Click += new System.EventHandler(this.BtnDetailResep_Click_1);
            // 
            // BtnBack
            // 
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnBack.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(774, 466);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(107, 44);
            this.BtnBack.TabIndex = 9;
            this.BtnBack.Text = "Back";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // ResepObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 522);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDetailResep);
            this.Controls.Add(this.BtnCariResep);
            this.Controls.Add(this.BtnAddPasien);
            this.Controls.Add(this.dtResepObat);
            this.Controls.Add(this.PcF);
            this.MaximumSize = new System.Drawing.Size(915, 578);
            this.MinimumSize = new System.Drawing.Size(915, 578);
            this.Name = "ResepObat";
            this.Text = "ResepObat";
            this.Load += new System.EventHandler(this.ResepObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtResepObat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox PcF;
        private Guna.UI2.WinForms.Guna2DataGridView dtResepObat;
        private Guna.UI2.WinForms.Guna2Button BtnAddPasien;
        private Guna.UI2.WinForms.Guna2Button BtnCariResep;
        private Guna.UI2.WinForms.Guna2Button BtnDetailResep;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
    }
}