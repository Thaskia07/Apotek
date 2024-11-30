namespace Apotek
{
    partial class DataKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataKaryawan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dtKaryawan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BtnAddKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDeleteKaryawan = new Guna.UI2.WinForms.Guna2Button();
            this.BtnBack = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(421, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(149, 119);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // dtKaryawan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtKaryawan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtKaryawan.BackgroundColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtKaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtKaryawan.ColumnHeadersHeight = 4;
            this.dtKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtKaryawan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtKaryawan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtKaryawan.Location = new System.Drawing.Point(25, 244);
            this.dtKaryawan.MaximumSize = new System.Drawing.Size(932, 305);
            this.dtKaryawan.MinimumSize = new System.Drawing.Size(932, 305);
            this.dtKaryawan.Name = "dtKaryawan";
            this.dtKaryawan.RowHeadersVisible = false;
            this.dtKaryawan.RowHeadersWidth = 62;
            this.dtKaryawan.RowTemplate.Height = 28;
            this.dtKaryawan.Size = new System.Drawing.Size(932, 305);
            this.dtKaryawan.TabIndex = 3;
            this.dtKaryawan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtKaryawan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtKaryawan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtKaryawan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtKaryawan.ThemeStyle.BackColor = System.Drawing.Color.RosyBrown;
            this.dtKaryawan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtKaryawan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtKaryawan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtKaryawan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtKaryawan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtKaryawan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtKaryawan.ThemeStyle.HeaderStyle.Height = 4;
            this.dtKaryawan.ThemeStyle.ReadOnly = false;
            this.dtKaryawan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtKaryawan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtKaryawan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtKaryawan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtKaryawan.ThemeStyle.RowsStyle.Height = 28;
            this.dtKaryawan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtKaryawan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BtnAddKaryawan
            // 
            this.BtnAddKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddKaryawan.FillColor = System.Drawing.Color.DarkSalmon;
            this.BtnAddKaryawan.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnAddKaryawan.ForeColor = System.Drawing.Color.White;
            this.BtnAddKaryawan.Location = new System.Drawing.Point(149, 193);
            this.BtnAddKaryawan.Name = "BtnAddKaryawan";
            this.BtnAddKaryawan.Size = new System.Drawing.Size(154, 45);
            this.BtnAddKaryawan.TabIndex = 8;
            this.BtnAddKaryawan.Text = "Add Karyawan";
            this.BtnAddKaryawan.Click += new System.EventHandler(this.BtnAddKaryawan_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apotek Nakii";
            // 
            // BtnDeleteKaryawan
            // 
            this.BtnDeleteKaryawan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteKaryawan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDeleteKaryawan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDeleteKaryawan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDeleteKaryawan.FillColor = System.Drawing.Color.DarkSalmon;
            this.BtnDeleteKaryawan.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BtnDeleteKaryawan.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteKaryawan.Location = new System.Drawing.Point(408, 193);
            this.BtnDeleteKaryawan.Name = "BtnDeleteKaryawan";
            this.BtnDeleteKaryawan.Size = new System.Drawing.Size(180, 45);
            this.BtnDeleteKaryawan.TabIndex = 10;
            this.BtnDeleteKaryawan.Text = "Delete Karyawan";
            this.BtnDeleteKaryawan.Click += new System.EventHandler(this.BtnDeleteKaryawan_Click_1);
            // 
            // BtnBack
            // 
            this.BtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnBack.FillColor = System.Drawing.Color.Gray;
            this.BtnBack.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(740, 193);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(150, 45);
            this.BtnBack.TabIndex = 11;
            this.BtnBack.Text = "Back";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // DataKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 561);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnDeleteKaryawan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAddKaryawan);
            this.Controls.Add(this.dtKaryawan);
            this.Controls.Add(this.guna2PictureBox1);
            this.MaximumSize = new System.Drawing.Size(991, 617);
            this.MinimumSize = new System.Drawing.Size(991, 617);
            this.Name = "DataKaryawan";
            this.Text = "DataKaryawan";
            this.Load += new System.EventHandler(this.DataKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtKaryawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dtKaryawan;
        private Guna.UI2.WinForms.Guna2Button BtnAddKaryawan;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button BtnDeleteKaryawan;
        private Guna.UI2.WinForms.Guna2Button BtnBack;
    }
}