namespace Motobike.Hoadon
{
    partial class Hoadonmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hoadonmain));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnhoadonnhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnhoadonban = new Guna.UI2.WinForms.Guna2Button();
            this.pbody = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.pbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Controls.Add(this.btnhoadonnhap);
            this.guna2Panel1.Controls.Add(this.btnhoadonban);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1151, 56);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnhoadonnhap
            // 
            this.btnhoadonnhap.BorderRadius = 14;
            this.btnhoadonnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhoadonnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhoadonnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhoadonnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhoadonnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhoadonnhap.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoadonnhap.ForeColor = System.Drawing.Color.White;
            this.btnhoadonnhap.Location = new System.Drawing.Point(724, 0);
            this.btnhoadonnhap.Name = "btnhoadonnhap";
            this.btnhoadonnhap.Size = new System.Drawing.Size(143, 45);
            this.btnhoadonnhap.TabIndex = 1;
            this.btnhoadonnhap.Text = "Hóa đơn nhập";
            this.btnhoadonnhap.Click += new System.EventHandler(this.btnhoadonnhap_Click);
            // 
            // btnhoadonban
            // 
            this.btnhoadonban.BorderRadius = 14;
            this.btnhoadonban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhoadonban.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhoadonban.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhoadonban.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhoadonban.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhoadonban.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoadonban.ForeColor = System.Drawing.Color.White;
            this.btnhoadonban.Location = new System.Drawing.Point(219, 3);
            this.btnhoadonban.Name = "btnhoadonban";
            this.btnhoadonban.Size = new System.Drawing.Size(143, 45);
            this.btnhoadonban.TabIndex = 0;
            this.btnhoadonban.Text = "Hóa đơn bán";
            this.btnhoadonban.Click += new System.EventHandler(this.btnhoadonban_Click);
            // 
            // pbody
            // 
            this.pbody.Controls.Add(this.pictureBox1);
            this.pbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbody.Location = new System.Drawing.Point(0, 56);
            this.pbody.Name = "pbody";
            this.pbody.Size = new System.Drawing.Size(1151, 534);
            this.pbody.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Motobike.Properties.Resources.hoadonmain;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1151, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Hoadonmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 590);
            this.Controls.Add(this.pbody);
            this.Controls.Add(this.guna2Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoadonmain";
            this.Text = "Hoadonmain";
            this.Load += new System.EventHandler(this.Hoadonmain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.pbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnhoadonnhap;
        private Guna.UI2.WinForms.Guna2Button btnhoadonban;
        private Guna.UI2.WinForms.Guna2Panel pbody;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}