namespace Motobike.Danhmuc
{
    partial class Danhmucnhanvien
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtsdt = new System.Windows.Forms.MaskedTextBox();
            this.cbochucvu = new System.Windows.Forms.ComboBox();
            this.cbogioitinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtma = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtten = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnluu = new Guna.UI2.WinForms.Guna2Button();
            this.btnboqua = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnsua = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Controls.Add(this.guna2GroupBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(530, 556);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txtsdt);
            this.guna2GroupBox1.Controls.Add(this.cbochucvu);
            this.guna2GroupBox1.Controls.Add(this.cbogioitinh);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.txtma);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txtten);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.txtdate);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.txtdiachi);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(13, 25);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(497, 519);
            this.guna2GroupBox1.TabIndex = 0;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(161, 375);
            this.txtsdt.Mask = "(999) 000-0000";
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(200, 29);
            this.txtsdt.TabIndex = 21;
            // 
            // cbochucvu
            // 
            this.cbochucvu.FormattingEnabled = true;
            this.cbochucvu.Items.AddRange(new object[] {
            "Thủ kho",
            "Bán hàng",
            "Kế toán",
            "IT"});
            this.cbochucvu.Location = new System.Drawing.Point(161, 210);
            this.cbochucvu.Name = "cbochucvu";
            this.cbochucvu.Size = new System.Drawing.Size(121, 29);
            this.cbochucvu.TabIndex = 20;
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.FormattingEnabled = true;
            this.cbogioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.cbogioitinh.Location = new System.Drawing.Point(161, 431);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(121, 29);
            this.cbogioitinh.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 4;
            this.label1.Tag = "";
            this.label1.Text = "Mã nhân viên";
            // 
            // txtma
            // 
            this.txtma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtma.DefaultText = "";
            this.txtma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtma.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.ForeColor = System.Drawing.Color.Black;
            this.txtma.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtma.Location = new System.Drawing.Point(161, 75);
            this.txtma.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtma.Name = "txtma";
            this.txtma.PlaceholderText = "";
            this.txtma.SelectedText = "";
            this.txtma.Size = new System.Drawing.Size(209, 36);
            this.txtma.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtten
            // 
            this.txtten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtten.DefaultText = "";
            this.txtten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtten.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.ForeColor = System.Drawing.Color.Black;
            this.txtten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtten.Location = new System.Drawing.Point(161, 139);
            this.txtten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtten.Name = "txtten";
            this.txtten.PlaceholderText = "";
            this.txtten.SelectedText = "";
            this.txtten.Size = new System.Drawing.Size(200, 36);
            this.txtten.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Điện thoại";
            // 
            // txtdate
            // 
            this.txtdate.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(161, 313);
            this.txtdate.Mask = "00/00/0000";
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 28);
            this.txtdate.TabIndex = 15;
            this.txtdate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày sinh";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdiachi.DefaultText = "";
            this.txtdiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachi.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiachi.ForeColor = System.Drawing.Color.Black;
            this.txtdiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdiachi.Location = new System.Drawing.Point(161, 253);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.PlaceholderText = "";
            this.txtdiachi.SelectedText = "";
            this.txtdiachi.Size = new System.Drawing.Size(200, 36);
            this.txtdiachi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvnhanvien);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(530, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(418, 398);
            this.guna2Panel2.TabIndex = 1;
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvnhanvien.Location = new System.Drawing.Point(25, 62);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 51;
            this.dgvnhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhanvien.Size = new System.Drawing.Size(381, 277);
            this.dgvnhanvien.TabIndex = 1;
            this.dgvnhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhanvien_CellContentClick);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.SystemColors.Info;
            this.guna2Panel3.Controls.Add(this.btnluu);
            this.guna2Panel3.Controls.Add(this.btnboqua);
            this.guna2Panel3.Controls.Add(this.btnxoa);
            this.guna2Panel3.Controls.Add(this.btnsua);
            this.guna2Panel3.Controls.Add(this.btnthem);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(530, 398);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(418, 158);
            this.guna2Panel3.TabIndex = 2;
            // 
            // btnluu
            // 
            this.btnluu.BorderRadius = 17;
            this.btnluu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnluu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnluu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnluu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnluu.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnluu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.ForeColor = System.Drawing.Color.White;
            this.btnluu.Image = global::Motobike.Properties.Resources.save;
            this.btnluu.Location = new System.Drawing.Point(6, 108);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(97, 45);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.BorderRadius = 17;
            this.btnboqua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnboqua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnboqua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnboqua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnboqua.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnboqua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.ForeColor = System.Drawing.Color.White;
            this.btnboqua.Image = global::Motobike.Properties.Resources.cancel;
            this.btnboqua.Location = new System.Drawing.Point(141, 108);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(97, 45);
            this.btnboqua.TabIndex = 8;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BorderRadius = 17;
            this.btnxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoa.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Image = global::Motobike.Properties.Resources.delete;
            this.btnxoa.Location = new System.Drawing.Point(288, 33);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(97, 45);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BorderRadius = 17;
            this.btnsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsua.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnsua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.White;
            this.btnsua.Image = global::Motobike.Properties.Resources.edit;
            this.btnsua.Location = new System.Drawing.Point(141, 33);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(97, 45);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BorderRadius = 17;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Image = global::Motobike.Properties.Resources.add;
            this.btnthem.Location = new System.Drawing.Point(6, 33);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(97, 45);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Danhmucnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 556);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Danhmucnhanvien";
            this.Text = "Danhmucnhanvien";
            this.Load += new System.EventHandler(this.Danhmucnhanvien_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private Guna.UI2.WinForms.Guna2Button btnluu;
        private Guna.UI2.WinForms.Guna2Button btnboqua;
        private Guna.UI2.WinForms.Guna2Button btnxoa;
        private Guna.UI2.WinForms.Guna2Button btnsua;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtten;
        private Guna.UI2.WinForms.Guna2TextBox txtma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtdate;
        private Guna.UI2.WinForms.Guna2TextBox txtdiachi;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ComboBox cbogioitinh;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbochucvu;
        private System.Windows.Forms.MaskedTextBox txtsdt;
    }
}