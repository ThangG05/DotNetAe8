namespace Motobike.Baocao
{
    partial class Baocaohoatdongkinhdoanh
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboTieuchi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpbatdau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpketthuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpmmyyyy = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblden = new System.Windows.Forms.Label();
            this.lbldau = new System.Windows.Forms.Label();
            this.rdothoigian = new System.Windows.Forms.RadioButton();
            this.rdoMMYYYY = new System.Windows.Forms.RadioButton();
            this.Chartbaocao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvban = new System.Windows.Forms.DataGridView();
            this.butin = new Guna.UI2.WinForms.Guna2Button();
            this.buttimlai = new Guna.UI2.WinForms.Guna2Button();
            this.buttimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblname = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chartbaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cboTieuchi);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(74, 42);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(239, 200);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Tiêu chí";
            // 
            // cboTieuchi
            // 
            this.cboTieuchi.BackColor = System.Drawing.Color.Transparent;
            this.cboTieuchi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTieuchi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTieuchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTieuchi.FillColor = System.Drawing.Color.Khaki;
            this.cboTieuchi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTieuchi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTieuchi.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTieuchi.ForeColor = System.Drawing.Color.Black;
            this.cboTieuchi.ItemHeight = 30;
            this.cboTieuchi.Items.AddRange(new object[] {
            "Tên hàng",
            "Tên hãng sản xuất"});
            this.cboTieuchi.Location = new System.Drawing.Point(17, 60);
            this.cboTieuchi.Name = "cboTieuchi";
            this.cboTieuchi.Size = new System.Drawing.Size(140, 36);
            this.cboTieuchi.TabIndex = 2;
            this.cboTieuchi.SelectedIndexChanged += new System.EventHandler(this.cboTieuchi_SelectedIndexChanged);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.dtpbatdau);
            this.guna2GroupBox2.Controls.Add(this.dtpketthuc);
            this.guna2GroupBox2.Controls.Add(this.dtpmmyyyy);
            this.guna2GroupBox2.Controls.Add(this.lblden);
            this.guna2GroupBox2.Controls.Add(this.lbldau);
            this.guna2GroupBox2.Controls.Add(this.rdothoigian);
            this.guna2GroupBox2.Controls.Add(this.rdoMMYYYY);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(417, 33);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(654, 200);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Mốc thời gian";
            // 
            // dtpbatdau
            // 
            this.dtpbatdau.Checked = true;
            this.dtpbatdau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpbatdau.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbatdau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpbatdau.Location = new System.Drawing.Point(221, 146);
            this.dtpbatdau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpbatdau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpbatdau.Name = "dtpbatdau";
            this.dtpbatdau.Size = new System.Drawing.Size(196, 36);
            this.dtpbatdau.TabIndex = 12;
            this.dtpbatdau.Value = new System.DateTime(2025, 5, 27, 10, 23, 32, 263);
            // 
            // dtpketthuc
            // 
            this.dtpketthuc.Checked = true;
            this.dtpketthuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpketthuc.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpketthuc.Location = new System.Drawing.Point(466, 146);
            this.dtpketthuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpketthuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpketthuc.Name = "dtpketthuc";
            this.dtpketthuc.Size = new System.Drawing.Size(185, 36);
            this.dtpketthuc.TabIndex = 11;
            this.dtpketthuc.Value = new System.DateTime(2025, 5, 27, 10, 23, 17, 355);
            // 
            // dtpmmyyyy
            // 
            this.dtpmmyyyy.Checked = true;
            this.dtpmmyyyy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpmmyyyy.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpmmyyyy.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpmmyyyy.Location = new System.Drawing.Point(231, 53);
            this.dtpmmyyyy.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpmmyyyy.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpmmyyyy.Name = "dtpmmyyyy";
            this.dtpmmyyyy.Size = new System.Drawing.Size(198, 36);
            this.dtpmmyyyy.TabIndex = 10;
            this.dtpmmyyyy.Value = new System.DateTime(2025, 5, 27, 10, 22, 59, 687);
            // 
            // lblden
            // 
            this.lblden.AutoSize = true;
            this.lblden.Location = new System.Drawing.Point(425, 158);
            this.lblden.Name = "lblden";
            this.lblden.Size = new System.Drawing.Size(35, 20);
            this.lblden.TabIndex = 5;
            this.lblden.Text = "Đến";
            this.lblden.Click += new System.EventHandler(this.lblden_Click);
            // 
            // lbldau
            // 
            this.lbldau.AutoSize = true;
            this.lbldau.Location = new System.Drawing.Point(189, 158);
            this.lbldau.Name = "lbldau";
            this.lbldau.Size = new System.Drawing.Size(26, 20);
            this.lbldau.TabIndex = 4;
            this.lbldau.Text = "Từ";
            // 
            // rdothoigian
            // 
            this.rdothoigian.AutoSize = true;
            this.rdothoigian.Location = new System.Drawing.Point(14, 158);
            this.rdothoigian.Name = "rdothoigian";
            this.rdothoigian.Size = new System.Drawing.Size(137, 24);
            this.rdothoigian.TabIndex = 1;
            this.rdothoigian.TabStop = true;
            this.rdothoigian.Text = "Khoảng thời gian";
            this.rdothoigian.UseVisualStyleBackColor = true;
            this.rdothoigian.CheckedChanged += new System.EventHandler(this.rdothoigian_CheckedChanged);
            // 
            // rdoMMYYYY
            // 
            this.rdoMMYYYY.AutoSize = true;
            this.rdoMMYYYY.Location = new System.Drawing.Point(14, 65);
            this.rdoMMYYYY.Name = "rdoMMYYYY";
            this.rdoMMYYYY.Size = new System.Drawing.Size(117, 24);
            this.rdoMMYYYY.TabIndex = 0;
            this.rdoMMYYYY.TabStop = true;
            this.rdoMMYYYY.Text = "DD/MM/YYYY";
            this.rdoMMYYYY.UseVisualStyleBackColor = true;
            this.rdoMMYYYY.CheckedChanged += new System.EventHandler(this.rdoMMYYYY_CheckedChanged);
            // 
            // Chartbaocao
            // 
            chartArea2.Name = "ChartArea1";
            this.Chartbaocao.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chartbaocao.Legends.Add(legend2);
            this.Chartbaocao.Location = new System.Drawing.Point(740, 239);
            this.Chartbaocao.Name = "Chartbaocao";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số lượng bán";
            this.Chartbaocao.Series.Add(series2);
            this.Chartbaocao.Size = new System.Drawing.Size(331, 240);
            this.Chartbaocao.TabIndex = 2;
            this.Chartbaocao.Text = "chart1";
            // 
            // dgvban
            // 
            this.dgvban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvban.Location = new System.Drawing.Point(74, 258);
            this.dgvban.Name = "dgvban";
            this.dgvban.RowHeadersWidth = 51;
            this.dgvban.Size = new System.Drawing.Size(631, 181);
            this.dgvban.TabIndex = 3;
            // 
            // butin
            // 
            this.butin.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.butin.BorderRadius = 14;
            this.butin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butin.FillColor = System.Drawing.Color.DodgerBlue;
            this.butin.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butin.ForeColor = System.Drawing.Color.White;
            this.butin.Image = global::Motobike.Properties.Resources.print;
            this.butin.Location = new System.Drawing.Point(565, 445);
            this.butin.Name = "butin";
            this.butin.Size = new System.Drawing.Size(94, 45);
            this.butin.TabIndex = 6;
            this.butin.Text = "In";
            this.butin.Click += new System.EventHandler(this.butin_Click);
            // 
            // buttimlai
            // 
            this.buttimlai.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttimlai.BorderRadius = 14;
            this.buttimlai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttimlai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttimlai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttimlai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttimlai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttimlai.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttimlai.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttimlai.ForeColor = System.Drawing.Color.White;
            this.buttimlai.Image = global::Motobike.Properties.Resources.research;
            this.buttimlai.Location = new System.Drawing.Point(339, 445);
            this.buttimlai.Name = "buttimlai";
            this.buttimlai.Size = new System.Drawing.Size(94, 45);
            this.buttimlai.TabIndex = 5;
            this.buttimlai.Text = "Tìm lại";
            this.buttimlai.Click += new System.EventHandler(this.buttimlai_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.buttimkiem.BorderRadius = 14;
            this.buttimkiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttimkiem.FillColor = System.Drawing.Color.DodgerBlue;
            this.buttimkiem.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttimkiem.ForeColor = System.Drawing.Color.White;
            this.buttimkiem.Image = global::Motobike.Properties.Resources.find;
            this.buttimkiem.Location = new System.Drawing.Point(91, 445);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(94, 45);
            this.buttimkiem.TabIndex = 4;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Motobike.Properties.Resources.username1;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(0, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(54, 37);
            this.guna2Button1.TabIndex = 13;
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.Maroon;
            this.lblname.Location = new System.Drawing.Point(60, 2);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(225, 37);
            this.lblname.TabIndex = 12;
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Baocaohoatdongkinhdoanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 491);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.butin);
            this.Controls.Add(this.buttimlai);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.dgvban);
            this.Controls.Add(this.Chartbaocao);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "Baocaohoatdongkinhdoanh";
            this.Text = "TopSanPham";
            this.Load += new System.EventHandler(this.Baocaohoatdongkinhdoanh_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chartbaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label lblden;
        private System.Windows.Forms.Label lbldau;
        private System.Windows.Forms.RadioButton rdothoigian;
        private System.Windows.Forms.RadioButton rdoMMYYYY;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chartbaocao;
        private System.Windows.Forms.DataGridView dgvban;
        private Guna.UI2.WinForms.Guna2Button buttimkiem;
        private Guna.UI2.WinForms.Guna2Button buttimlai;
        private Guna.UI2.WinForms.Guna2Button butin;
        private Guna.UI2.WinForms.Guna2ComboBox cboTieuchi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpbatdau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpketthuc;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpmmyyyy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lblname;
    }
}