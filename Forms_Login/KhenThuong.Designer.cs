namespace Forms_Login
{
    partial class KhenThuong
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
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaKT = new System.Windows.Forms.TextBox();
            this.cbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenKT = new System.Windows.Forms.TextBox();
            this.textBoxHocKy = new System.Windows.Forms.TextBox();
            this.textBoxNamHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgv_KhenThuong = new System.Windows.Forms.DataGridView();
            this.sMaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.dateTimeNgayLap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhenThuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(412, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHEN THƯỞNG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã khen thưởng: ";
            // 
            // textBoxMaKT
            // 
            this.textBoxMaKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaKT.Location = new System.Drawing.Point(197, 61);
            this.textBoxMaKT.Name = "textBoxMaKT";
            this.textBoxMaKT.ReadOnly = true;
            this.textBoxMaKT.Size = new System.Drawing.Size(183, 27);
            this.textBoxMaKT.TabIndex = 17;
            // 
            // cbMaKhoa
            // 
            this.cbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhoa.FormattingEnabled = true;
            this.cbMaKhoa.Location = new System.Drawing.Point(507, 61);
            this.cbMaKhoa.Name = "cbMaKhoa";
            this.cbMaKhoa.Size = new System.Drawing.Size(187, 28);
            this.cbMaKhoa.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã khoa: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên khen thưởng: ";
            // 
            // textBoxTenKT
            // 
            this.textBoxTenKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenKT.Location = new System.Drawing.Point(197, 110);
            this.textBoxTenKT.Name = "textBoxTenKT";
            this.textBoxTenKT.Size = new System.Drawing.Size(183, 27);
            this.textBoxTenKT.TabIndex = 27;
            // 
            // textBoxHocKy
            // 
            this.textBoxHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHocKy.Location = new System.Drawing.Point(507, 110);
            this.textBoxHocKy.Name = "textBoxHocKy";
            this.textBoxHocKy.Size = new System.Drawing.Size(187, 27);
            this.textBoxHocKy.TabIndex = 29;
            // 
            // textBoxNamHoc
            // 
            this.textBoxNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamHoc.Location = new System.Drawing.Point(848, 110);
            this.textBoxNamHoc.Name = "textBoxNamHoc";
            this.textBoxNamHoc.Size = new System.Drawing.Size(175, 27);
            this.textBoxNamHoc.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(733, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ngày lập:  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Học kỳ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Năm học: ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(472, 173);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(134, 37);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.IndianRed;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(296, 173);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(134, 37);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.IndianRed;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(123, 173);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 37);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgv_KhenThuong
            // 
            this.dgv_KhenThuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhenThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhenThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKT,
            this.dNgayLap,
            this.sTenKT,
            this.sHocKy,
            this.sNamHoc,
            this.sMaKhoa});
            this.dgv_KhenThuong.Location = new System.Drawing.Point(16, 238);
            this.dgv_KhenThuong.Name = "dgv_KhenThuong";
            this.dgv_KhenThuong.RowHeadersWidth = 51;
            this.dgv_KhenThuong.RowTemplate.Height = 24;
            this.dgv_KhenThuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhenThuong.Size = new System.Drawing.Size(1040, 299);
            this.dgv_KhenThuong.TabIndex = 37;
            this.dgv_KhenThuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhenThuong_CellClick);
            // 
            // sMaKT
            // 
            this.sMaKT.DataPropertyName = "sMaKT";
            this.sMaKT.HeaderText = "Mã KT";
            this.sMaKT.MinimumWidth = 6;
            this.sMaKT.Name = "sMaKT";
            // 
            // dNgayLap
            // 
            this.dNgayLap.DataPropertyName = "dNgayLap";
            this.dNgayLap.HeaderText = "Ngày lập";
            this.dNgayLap.MinimumWidth = 6;
            this.dNgayLap.Name = "dNgayLap";
            // 
            // sTenKT
            // 
            this.sTenKT.DataPropertyName = "sTenKT";
            this.sTenKT.HeaderText = "Tên KT";
            this.sTenKT.MinimumWidth = 6;
            this.sTenKT.Name = "sTenKT";
            // 
            // sHocKy
            // 
            this.sHocKy.DataPropertyName = "sHocKy";
            this.sHocKy.HeaderText = "Học kỳ";
            this.sHocKy.MinimumWidth = 6;
            this.sHocKy.Name = "sHocKy";
            // 
            // sNamHoc
            // 
            this.sNamHoc.DataPropertyName = "sNamHoc";
            this.sNamHoc.HeaderText = "Năm học";
            this.sNamHoc.MinimumWidth = 6;
            this.sNamHoc.Name = "sNamHoc";
            // 
            // sMaKhoa
            // 
            this.sMaKhoa.DataPropertyName = "sMaKhoa";
            this.sMaKhoa.HeaderText = "Mã khoa";
            this.sMaKhoa.MinimumWidth = 6;
            this.sMaKhoa.Name = "sMaKhoa";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.IndianRed;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(645, 173);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(121, 37);
            this.btnTimKiem.TabIndex = 38;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.IndianRed;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(803, 173);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(134, 37);
            this.buttonReset.TabIndex = 39;
            this.buttonReset.Text = "Làm mới";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // dateTimeNgayLap
            // 
            this.dateTimeNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayLap.Location = new System.Drawing.Point(848, 61);
            this.dateTimeNgayLap.Name = "dateTimeNgayLap";
            this.dateTimeNgayLap.Size = new System.Drawing.Size(175, 27);
            this.dateTimeNgayLap.TabIndex = 40;
            // 
            // KhenThuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 549);
            this.Controls.Add(this.dateTimeNgayLap);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgv_KhenThuong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNamHoc);
            this.Controls.Add(this.textBoxHocKy);
            this.Controls.Add(this.textBoxTenKT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaKhoa);
            this.Controls.Add(this.textBoxMaKT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "KhenThuong";
            this.Text = "KhenThuong";
            this.Load += new System.EventHandler(this.KhenThuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhenThuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxMaKT;
        private System.Windows.Forms.ComboBox cbMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenKT;
        private System.Windows.Forms.TextBox textBoxHocKy;
        private System.Windows.Forms.TextBox textBoxNamHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgv_KhenThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.DateTimePicker dateTimeNgayLap;
    }
}