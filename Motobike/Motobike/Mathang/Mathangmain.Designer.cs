namespace Motobike.Mathang
{
    partial class Mathangmain
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnsuzuki = new Guna.UI2.WinForms.Guna2Button();
            this.btnyamaha = new Guna.UI2.WinForms.Guna2Button();
            this.btnhonda = new Guna.UI2.WinForms.Guna2Button();
            this.pbody = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.pbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.btnsuzuki);
            this.guna2Panel1.Controls.Add(this.btnyamaha);
            this.guna2Panel1.Controls.Add(this.btnhonda);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1154, 77);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnsuzuki
            // 
            this.btnsuzuki.BorderRadius = 14;
            this.btnsuzuki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuzuki.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuzuki.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuzuki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuzuki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuzuki.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuzuki.ForeColor = System.Drawing.Color.White;
            this.btnsuzuki.Location = new System.Drawing.Point(930, 14);
            this.btnsuzuki.Name = "btnsuzuki";
            this.btnsuzuki.Size = new System.Drawing.Size(136, 45);
            this.btnsuzuki.TabIndex = 2;
            this.btnsuzuki.Text = "SUZUKI";
            this.btnsuzuki.Click += new System.EventHandler(this.btnsuzuki_Click);
            // 
            // btnyamaha
            // 
            this.btnyamaha.BorderRadius = 14;
            this.btnyamaha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyamaha.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnyamaha.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnyamaha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnyamaha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnyamaha.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyamaha.ForeColor = System.Drawing.Color.White;
            this.btnyamaha.Location = new System.Drawing.Point(499, 14);
            this.btnyamaha.Name = "btnyamaha";
            this.btnyamaha.Size = new System.Drawing.Size(136, 45);
            this.btnyamaha.TabIndex = 1;
            this.btnyamaha.Text = "HONDA";
            this.btnyamaha.Click += new System.EventHandler(this.btnyamaha_Click);
            // 
            // btnhonda
            // 
            this.btnhonda.BorderRadius = 14;
            this.btnhonda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhonda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnhonda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnhonda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnhonda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnhonda.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhonda.ForeColor = System.Drawing.Color.White;
            this.btnhonda.Location = new System.Drawing.Point(49, 14);
            this.btnhonda.Name = "btnhonda";
            this.btnhonda.Size = new System.Drawing.Size(136, 45);
            this.btnhonda.TabIndex = 0;
            this.btnhonda.Text = "YAMAHA";
            this.btnhonda.Click += new System.EventHandler(this.btnhonda_Click);
            // 
            // pbody
            // 
            this.pbody.Controls.Add(this.pictureBox1);
            this.pbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbody.Location = new System.Drawing.Point(0, 77);
            this.pbody.Name = "pbody";
            this.pbody.Size = new System.Drawing.Size(1154, 474);
            this.pbody.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Motobike.Properties.Resources.mathangmian;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1154, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Mathangmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 551);
            this.Controls.Add(this.pbody);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Mathangmain";
            this.Text = "Mathangmain";
            this.Load += new System.EventHandler(this.Mathangmain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.pbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnsuzuki;
        private Guna.UI2.WinForms.Guna2Button btnyamaha;
        private Guna.UI2.WinForms.Guna2Button btnhonda;
        private Guna.UI2.WinForms.Guna2Panel pbody;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}