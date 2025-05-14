namespace Motobike.Baocao
{
    partial class Baocaotopsanpham
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtketthuc = new System.Windows.Forms.MaskedTextBox();
            this.txtbatdau = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtloinhuan = new System.Windows.Forms.TextBox();
            this.txtdautu = new System.Windows.Forms.TextBox();
            this.txtdoanhthu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnin = new Guna.UI2.WinForms.Guna2Button();
            this.btntinhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtketthuc);
            this.guna2GroupBox1.Controls.Add(this.txtbatdau);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(44, 78);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(324, 314);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Mốc thời gian";
            // 
            // txtketthuc
            // 
            this.txtketthuc.Location = new System.Drawing.Point(152, 216);
            this.txtketthuc.Mask = "00/00/0000";
            this.txtketthuc.Name = "txtketthuc";
            this.txtketthuc.Size = new System.Drawing.Size(142, 29);
            this.txtketthuc.TabIndex = 3;
            this.txtketthuc.ValidatingType = typeof(System.DateTime);
            // 
            // txtbatdau
            // 
            this.txtbatdau.Location = new System.Drawing.Point(152, 99);
            this.txtbatdau.Mask = "00/00/0000";
            this.txtbatdau.Name = "txtbatdau";
            this.txtbatdau.Size = new System.Drawing.Size(142, 29);
            this.txtbatdau.TabIndex = 2;
            this.txtbatdau.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.txtloinhuan);
            this.guna2GroupBox2.Controls.Add(this.txtdautu);
            this.guna2GroupBox2.Controls.Add(this.txtdoanhthu);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(415, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(689, 380);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Hoạt động";
            // 
            // txtloinhuan
            // 
            this.txtloinhuan.Location = new System.Drawing.Point(314, 292);
            this.txtloinhuan.Name = "txtloinhuan";
            this.txtloinhuan.Size = new System.Drawing.Size(288, 27);
            this.txtloinhuan.TabIndex = 5;
            // 
            // txtdautu
            // 
            this.txtdautu.Location = new System.Drawing.Point(314, 189);
            this.txtdautu.Name = "txtdautu";
            this.txtdautu.Size = new System.Drawing.Size(288, 27);
            this.txtdautu.TabIndex = 4;
            // 
            // txtdoanhthu
            // 
            this.txtdoanhthu.Location = new System.Drawing.Point(314, 97);
            this.txtdoanhthu.Name = "txtdoanhthu";
            this.txtdoanhthu.Size = new System.Drawing.Size(288, 27);
            this.txtdoanhthu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lợi nhuận";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tổng đầu tư";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng doanh thu";
            // 
            // btnin
            // 
            this.btnin.BorderRadius = 14;
            this.btnin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnin.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnin.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.White;
            this.btnin.Image = global::Motobike.Properties.Resources.print;
            this.btnin.Location = new System.Drawing.Point(781, 421);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(136, 45);
            this.btnin.TabIndex = 3;
            this.btnin.Text = "In báo cáo";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btntinhtoan
            // 
            this.btntinhtoan.BorderRadius = 14;
            this.btntinhtoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntinhtoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntinhtoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntinhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntinhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntinhtoan.FillColor = System.Drawing.Color.DodgerBlue;
            this.btntinhtoan.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinhtoan.ForeColor = System.Drawing.Color.White;
            this.btntinhtoan.Image = global::Motobike.Properties.Resources.money;
            this.btntinhtoan.Location = new System.Drawing.Point(141, 421);
            this.btntinhtoan.Name = "btntinhtoan";
            this.btntinhtoan.Size = new System.Drawing.Size(136, 45);
            this.btntinhtoan.TabIndex = 2;
            this.btntinhtoan.Text = "Tính toán";
            this.btntinhtoan.Click += new System.EventHandler(this.btntinhtoan_Click);
            // 
            // Baocaotopsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 491);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btntinhtoan);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "Baocaotopsanpham";
            this.Text = "Baocaotopsanpham";
            this.Load += new System.EventHandler(this.Baocaotopsanpham_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.TextBox txtloinhuan;
        private System.Windows.Forms.TextBox txtdautu;
        private System.Windows.Forms.TextBox txtdoanhthu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btntinhtoan;
        private Guna.UI2.WinForms.Guna2Button btnin;
        private System.Windows.Forms.MaskedTextBox txtketthuc;
        private System.Windows.Forms.MaskedTextBox txtbatdau;
    }
}