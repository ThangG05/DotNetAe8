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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdotenhangx = new System.Windows.Forms.RadioButton();
            this.rdotenhang = new System.Windows.Forms.RadioButton();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtketthuc = new System.Windows.Forms.MaskedTextBox();
            this.txtbdau = new System.Windows.Forms.MaskedTextBox();
            this.txtYYYY = new System.Windows.Forms.TextBox();
            this.txtMM = new System.Windows.Forms.TextBox();
            this.lblden = new System.Windows.Forms.Label();
            this.lbldau = new System.Windows.Forms.Label();
            this.lblYYYY = new System.Windows.Forms.Label();
            this.lblMM = new System.Windows.Forms.Label();
            this.rdothoigian = new System.Windows.Forms.RadioButton();
            this.rdoMMYYYY = new System.Windows.Forms.RadioButton();
            this.Chartbaocao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvban = new System.Windows.Forms.DataGridView();
            this.butin = new Guna.UI2.WinForms.Guna2Button();
            this.buttimlai = new Guna.UI2.WinForms.Guna2Button();
            this.buttimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chartbaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.rdotenhangx);
            this.guna2GroupBox1.Controls.Add(this.rdotenhang);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(74, 21);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(239, 200);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Tiêu chí";
            // 
            // rdotenhangx
            // 
            this.rdotenhangx.AutoSize = true;
            this.rdotenhangx.Location = new System.Drawing.Point(31, 152);
            this.rdotenhangx.Name = "rdotenhangx";
            this.rdotenhangx.Size = new System.Drawing.Size(90, 25);
            this.rdotenhangx.TabIndex = 1;
            this.rdotenhangx.TabStop = true;
            this.rdotenhangx.Text = "Tên hãng";
            this.rdotenhangx.UseVisualStyleBackColor = true;
            // 
            // rdotenhang
            // 
            this.rdotenhang.AutoSize = true;
            this.rdotenhang.Location = new System.Drawing.Point(31, 64);
            this.rdotenhang.Name = "rdotenhang";
            this.rdotenhang.Size = new System.Drawing.Size(90, 25);
            this.rdotenhang.TabIndex = 0;
            this.rdotenhang.TabStop = true;
            this.rdotenhang.Text = "Tên hàng";
            this.rdotenhang.UseVisualStyleBackColor = true;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.txtketthuc);
            this.guna2GroupBox2.Controls.Add(this.txtbdau);
            this.guna2GroupBox2.Controls.Add(this.txtYYYY);
            this.guna2GroupBox2.Controls.Add(this.txtMM);
            this.guna2GroupBox2.Controls.Add(this.lblden);
            this.guna2GroupBox2.Controls.Add(this.lbldau);
            this.guna2GroupBox2.Controls.Add(this.lblYYYY);
            this.guna2GroupBox2.Controls.Add(this.lblMM);
            this.guna2GroupBox2.Controls.Add(this.rdothoigian);
            this.guna2GroupBox2.Controls.Add(this.rdoMMYYYY);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(417, 21);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(654, 200);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Mốc thời gian";
            // 
            // txtketthuc
            // 
            this.txtketthuc.Location = new System.Drawing.Point(441, 152);
            this.txtketthuc.Mask = "00/00/0000";
            this.txtketthuc.Name = "txtketthuc";
            this.txtketthuc.Size = new System.Drawing.Size(100, 27);
            this.txtketthuc.TabIndex = 9;
            this.txtketthuc.ValidatingType = typeof(System.DateTime);
            // 
            // txtbdau
            // 
            this.txtbdau.Location = new System.Drawing.Point(258, 152);
            this.txtbdau.Mask = "00/00/0000";
            this.txtbdau.Name = "txtbdau";
            this.txtbdau.Size = new System.Drawing.Size(100, 27);
            this.txtbdau.TabIndex = 8;
            this.txtbdau.ValidatingType = typeof(System.DateTime);
            // 
            // txtYYYY
            // 
            this.txtYYYY.Location = new System.Drawing.Point(441, 69);
            this.txtYYYY.Name = "txtYYYY";
            this.txtYYYY.Size = new System.Drawing.Size(100, 27);
            this.txtYYYY.TabIndex = 7;
            // 
            // txtMM
            // 
            this.txtMM.Location = new System.Drawing.Point(258, 64);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(100, 27);
            this.txtMM.TabIndex = 6;
            // 
            // lblden
            // 
            this.lblden.AutoSize = true;
            this.lblden.Location = new System.Drawing.Point(387, 158);
            this.lblden.Name = "lblden";
            this.lblden.Size = new System.Drawing.Size(35, 20);
            this.lblden.TabIndex = 5;
            this.lblden.Text = "Đến";
            // 
            // lbldau
            // 
            this.lbldau.AutoSize = true;
            this.lbldau.Location = new System.Drawing.Point(213, 158);
            this.lbldau.Name = "lbldau";
            this.lbldau.Size = new System.Drawing.Size(26, 20);
            this.lbldau.TabIndex = 4;
            this.lbldau.Text = "Từ";
            // 
            // lblYYYY
            // 
            this.lblYYYY.AutoSize = true;
            this.lblYYYY.Location = new System.Drawing.Point(384, 70);
            this.lblYYYY.Name = "lblYYYY";
            this.lblYYYY.Size = new System.Drawing.Size(41, 20);
            this.lblYYYY.TabIndex = 3;
            this.lblYYYY.Text = "YYYY";
            // 
            // lblMM
            // 
            this.lblMM.AutoSize = true;
            this.lblMM.Location = new System.Drawing.Point(213, 69);
            this.lblMM.Name = "lblMM";
            this.lblMM.Size = new System.Drawing.Size(35, 20);
            this.lblMM.TabIndex = 2;
            this.lblMM.Text = "MM";
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
            this.rdoMMYYYY.Size = new System.Drawing.Size(91, 24);
            this.rdoMMYYYY.TabIndex = 0;
            this.rdoMMYYYY.TabStop = true;
            this.rdoMMYYYY.Text = "MM/YYYY";
            this.rdoMMYYYY.UseVisualStyleBackColor = true;
            this.rdoMMYYYY.CheckedChanged += new System.EventHandler(this.rdoMMYYYY_CheckedChanged);
            // 
            // Chartbaocao
            // 
            chartArea1.Name = "ChartArea1";
            this.Chartbaocao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chartbaocao.Legends.Add(legend1);
            this.Chartbaocao.Location = new System.Drawing.Point(740, 227);
            this.Chartbaocao.Name = "Chartbaocao";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng bán";
            this.Chartbaocao.Series.Add(series1);
            this.Chartbaocao.Size = new System.Drawing.Size(331, 240);
            this.Chartbaocao.TabIndex = 2;
            this.Chartbaocao.Text = "chart1";
            // 
            // dgvban
            // 
            this.dgvban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvban.Location = new System.Drawing.Point(74, 239);
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
            this.butin.Location = new System.Drawing.Point(556, 434);
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
            this.buttimlai.Location = new System.Drawing.Point(339, 434);
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
            this.buttimkiem.Location = new System.Drawing.Point(105, 434);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(94, 45);
            this.buttimkiem.TabIndex = 4;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // Baocaohoatdongkinhdoanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 491);
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
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chartbaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.RadioButton rdotenhangx;
        private System.Windows.Forms.RadioButton rdotenhang;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.MaskedTextBox txtketthuc;
        private System.Windows.Forms.MaskedTextBox txtbdau;
        private System.Windows.Forms.TextBox txtYYYY;
        private System.Windows.Forms.TextBox txtMM;
        private System.Windows.Forms.Label lblden;
        private System.Windows.Forms.Label lbldau;
        private System.Windows.Forms.Label lblYYYY;
        private System.Windows.Forms.Label lblMM;
        private System.Windows.Forms.RadioButton rdothoigian;
        private System.Windows.Forms.RadioButton rdoMMYYYY;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chartbaocao;
        private System.Windows.Forms.DataGridView dgvban;
        private Guna.UI2.WinForms.Guna2Button buttimkiem;
        private Guna.UI2.WinForms.Guna2Button buttimlai;
        private Guna.UI2.WinForms.Guna2Button butin;
    }
}