namespace Forms_Login
{
    partial class ThongKeSVKT
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHoTenSV = new System.Windows.Forms.TextBox();
            this.buttonInBaoCao = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.sMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 51);
            this.label1.TabIndex = 41;
            this.label1.Text = "Thống kê sinh viên";
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaSV.Location = new System.Drawing.Point(188, 87);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(283, 27);
            this.textBoxMaSV.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Mã SV: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Họ Tên: ";
            // 
            // textBoxHoTenSV
            // 
            this.textBoxHoTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTenSV.Location = new System.Drawing.Point(665, 87);
            this.textBoxHoTenSV.Name = "textBoxHoTenSV";
            this.textBoxHoTenSV.Size = new System.Drawing.Size(283, 27);
            this.textBoxHoTenSV.TabIndex = 46;
            // 
            // buttonInBaoCao
            // 
            this.buttonInBaoCao.BackColor = System.Drawing.Color.IndianRed;
            this.buttonInBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInBaoCao.Location = new System.Drawing.Point(681, 160);
            this.buttonInBaoCao.Name = "buttonInBaoCao";
            this.buttonInBaoCao.Size = new System.Drawing.Size(134, 37);
            this.buttonInBaoCao.TabIndex = 47;
            this.buttonInBaoCao.Text = "In báo cáo";
            this.buttonInBaoCao.UseVisualStyleBackColor = false;
            this.buttonInBaoCao.Click += new System.EventHandler(this.buttonInBaoCao_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.IndianRed;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(247, 160);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(134, 37);
            this.buttonTimKiem.TabIndex = 48;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 285);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaSV,
            this.sHoTen,
            this.dNgaySinh,
            this.sGioiTinh,
            this.sDiaChi,
            this.sMaLop});
            this.dataGridViewSV.Location = new System.Drawing.Point(8, 21);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.RowHeadersWidth = 51;
            this.dataGridViewSV.RowTemplate.Height = 24;
            this.dataGridViewSV.Size = new System.Drawing.Size(1009, 258);
            this.dataGridViewSV.TabIndex = 60;
            this.dataGridViewSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellClick);
            // 
            // sMaSV
            // 
            this.sMaSV.DataPropertyName = "sMaSV";
            this.sMaSV.HeaderText = "Mã SV";
            this.sMaSV.MinimumWidth = 6;
            this.sMaSV.Name = "sMaSV";
            // 
            // sHoTen
            // 
            this.sHoTen.DataPropertyName = "sHoTen";
            this.sHoTen.HeaderText = "Họ Tên";
            this.sHoTen.MinimumWidth = 6;
            this.sHoTen.Name = "sHoTen";
            // 
            // dNgaySinh
            // 
            this.dNgaySinh.DataPropertyName = "dNgaySinh";
            this.dNgaySinh.HeaderText = "Ngày Sinh";
            this.dNgaySinh.MinimumWidth = 6;
            this.dNgaySinh.Name = "dNgaySinh";
            // 
            // sGioiTinh
            // 
            this.sGioiTinh.DataPropertyName = "sGioiTinh";
            this.sGioiTinh.HeaderText = "Giới tính";
            this.sGioiTinh.MinimumWidth = 6;
            this.sGioiTinh.Name = "sGioiTinh";
            // 
            // sDiaChi
            // 
            this.sDiaChi.DataPropertyName = "sDiaChi";
            this.sDiaChi.HeaderText = "Địa chỉ";
            this.sDiaChi.MinimumWidth = 6;
            this.sDiaChi.Name = "sDiaChi";
            // 
            // sMaLop
            // 
            this.sMaLop.DataPropertyName = "sMaLop";
            this.sMaLop.HeaderText = "Mã lớp";
            this.sMaLop.MinimumWidth = 6;
            this.sMaLop.Name = "sMaLop";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(465, 160);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(134, 37);
            this.buttonReset.TabIndex = 50;
            this.buttonReset.Text = "Làm mới";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ThongKeSVKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 538);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonTimKiem);
            this.Controls.Add(this.buttonInBaoCao);
            this.Controls.Add(this.textBoxHoTenSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMaSV);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeSVKT";
            this.Text = "ThongKeSVKT";
            this.Load += new System.EventHandler(this.ThongKeSVKT_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHoTenSV;
        private System.Windows.Forms.Button buttonInBaoCao;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLop;
        private System.Windows.Forms.Button buttonReset;
    }
}