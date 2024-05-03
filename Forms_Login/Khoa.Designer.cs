namespace Forms_Login
{
    partial class Khoa
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
            this.dgv_Khoa = new System.Windows.Forms.DataGridView();
            this.sMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgayThanhLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxMaKhoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTenKhoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimeNTL = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Khoa
            // 
            this.dgv_Khoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKhoa,
            this.sTenKhoa,
            this.dNgayThanhLap});
            this.dgv_Khoa.Location = new System.Drawing.Point(12, 254);
            this.dgv_Khoa.Name = "dgv_Khoa";
            this.dgv_Khoa.RowHeadersWidth = 51;
            this.dgv_Khoa.RowTemplate.Height = 24;
            this.dgv_Khoa.Size = new System.Drawing.Size(779, 272);
            this.dgv_Khoa.TabIndex = 0;
            this.dgv_Khoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Khoa_CellClick);
            // 
            // sMaKhoa
            // 
            this.sMaKhoa.DataPropertyName = "sMaKhoa";
            this.sMaKhoa.HeaderText = "Mã khoa";
            this.sMaKhoa.MinimumWidth = 6;
            this.sMaKhoa.Name = "sMaKhoa";
            // 
            // sTenKhoa
            // 
            this.sTenKhoa.DataPropertyName = "sTenKhoa";
            this.sTenKhoa.HeaderText = "Tên khoa";
            this.sTenKhoa.MinimumWidth = 6;
            this.sTenKhoa.Name = "sTenKhoa";
            // 
            // dNgayThanhLap
            // 
            this.dNgayThanhLap.DataPropertyName = "dNgayThanhLap";
            this.dNgayThanhLap.HeaderText = "Ngày thành lập";
            this.dNgayThanhLap.MinimumWidth = 6;
            this.dNgayThanhLap.Name = "dNgayThanhLap";
            // 
            // textBoxMaKhoa
            // 
            this.textBoxMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaKhoa.Location = new System.Drawing.Point(158, 81);
            this.textBoxMaKhoa.Name = "textBoxMaKhoa";
            this.textBoxMaKhoa.Size = new System.Drawing.Size(183, 27);
            this.textBoxMaKhoa.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "KHOA";
            // 
            // textBoxTenKhoa
            // 
            this.textBoxTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenKhoa.Location = new System.Drawing.Point(158, 133);
            this.textBoxTenKhoa.Name = "textBoxTenKhoa";
            this.textBoxTenKhoa.Size = new System.Drawing.Size(183, 27);
            this.textBoxTenKhoa.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(64, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mã khoa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên khoa:";
            // 
            // datetimeNTL
            // 
            this.datetimeNTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeNTL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeNTL.Location = new System.Drawing.Point(551, 79);
            this.datetimeNTL.Name = "datetimeNTL";
            this.datetimeNTL.Size = new System.Drawing.Size(172, 27);
            this.datetimeNTL.TabIndex = 23;
            this.datetimeNTL.Value = new System.DateTime(2023, 4, 27, 19, 43, 48, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày thành lập:";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(597, 191);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 34);
            this.buttonReset.TabIndex = 65;
            this.buttonReset.Text = "Làm mới";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(411, 191);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(150, 34);
            this.buttonXoa.TabIndex = 66;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(229, 191);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(150, 34);
            this.buttonSua.TabIndex = 67;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(42, 191);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(150, 34);
            this.buttonThem.TabIndex = 68;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 538);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetimeNTL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTenKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaKhoa);
            this.Controls.Add(this.dgv_Khoa);
            this.Name = "Khoa";
            this.Text = "Khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgayThanhLap;
        private System.Windows.Forms.TextBox textBoxMaKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTenKhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimeNTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
    }
}