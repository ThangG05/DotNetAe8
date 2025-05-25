namespace Motobike.ACC
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butcreate = new Guna.UI2.WinForms.Guna2Button();
            this.Lblforget = new System.Windows.Forms.Label();
            this.txtmatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButDangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnview = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnview);
            this.panel1.Controls.Add(this.butcreate);
            this.panel1.Controls.Add(this.Lblforget);
            this.panel1.Controls.Add(this.txtmatkhau);
            this.panel1.Controls.Add(this.txttaikhoan);
            this.panel1.Controls.Add(this.ButDangnhap);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 461);
            this.panel1.TabIndex = 0;
            // 
            // butcreate
            // 
            this.butcreate.BackColor = System.Drawing.Color.Transparent;
            this.butcreate.BorderRadius = 14;
            this.butcreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butcreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butcreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butcreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butcreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butcreate.FillColor = System.Drawing.Color.Brown;
            this.butcreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcreate.ForeColor = System.Drawing.Color.White;
            this.butcreate.Location = new System.Drawing.Point(161, 393);
            this.butcreate.Name = "butcreate";
            this.butcreate.Size = new System.Drawing.Size(180, 45);
            this.butcreate.TabIndex = 6;
            this.butcreate.Text = "Tạo tài khoản mới";
            this.butcreate.UseTransparentBackground = true;
            this.butcreate.Click += new System.EventHandler(this.butcreate_Click);
            // 
            // Lblforget
            // 
            this.Lblforget.AutoSize = true;
            this.Lblforget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lblforget.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblforget.Location = new System.Drawing.Point(192, 347);
            this.Lblforget.Name = "Lblforget";
            this.Lblforget.Size = new System.Drawing.Size(122, 19);
            this.Lblforget.TabIndex = 5;
            this.Lblforget.Text = "Quên mật khẩu ?";
            this.Lblforget.Click += new System.EventHandler(this.Lblforget_Click);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmatkhau.DefaultText = "";
            this.txtmatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatkhau.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmatkhau.Location = new System.Drawing.Point(83, 219);
            this.txtmatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PlaceholderText = "";
            this.txtmatkhau.SelectedText = "";
            this.txtmatkhau.Size = new System.Drawing.Size(354, 45);
            this.txtmatkhau.TabIndex = 4;
            this.txtmatkhau.UseSystemPasswordChar = true;
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttaikhoan.DefaultText = "";
            this.txttaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttaikhoan.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttaikhoan.Location = new System.Drawing.Point(83, 135);
            this.txttaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.PlaceholderText = "";
            this.txttaikhoan.SelectedText = "";
            this.txttaikhoan.Size = new System.Drawing.Size(354, 45);
            this.txttaikhoan.TabIndex = 3;
            this.txttaikhoan.TextChanged += new System.EventHandler(this.txttaikhoan_TextChanged);
            // 
            // ButDangnhap
            // 
            this.ButDangnhap.BackColor = System.Drawing.Color.Transparent;
            this.ButDangnhap.BorderRadius = 14;
            this.ButDangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButDangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButDangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButDangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButDangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButDangnhap.FillColor = System.Drawing.Color.Black;
            this.ButDangnhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButDangnhap.ForeColor = System.Drawing.Color.White;
            this.ButDangnhap.Location = new System.Drawing.Point(161, 283);
            this.ButDangnhap.Name = "ButDangnhap";
            this.ButDangnhap.Size = new System.Drawing.Size(180, 45);
            this.ButDangnhap.TabIndex = 2;
            this.ButDangnhap.Text = "Đăng nhập";
            this.ButDangnhap.UseTransparentBackground = true;
            this.ButDangnhap.Click += new System.EventHandler(this.ButDangnhap_Click);
            // 
            // btnview
            // 
            this.btnview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnview.FillColor = System.Drawing.Color.Tan;
            this.btnview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Image = global::Motobike.Properties.Resources.ngu1;
            this.btnview.ImageSize = new System.Drawing.Size(40, 40);
            this.btnview.Location = new System.Drawing.Point(392, 219);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(45, 45);
            this.btnview.TabIndex = 7;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Motobike.Properties.Resources.Đăng_nhâp;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 461);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dangnhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button ButDangnhap;
        private System.Windows.Forms.Label Lblforget;
        private Guna.UI2.WinForms.Guna2TextBox txtmatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txttaikhoan;
        private Guna.UI2.WinForms.Guna2Button butcreate;
        private Guna.UI2.WinForms.Guna2Button btnview;
    }
}