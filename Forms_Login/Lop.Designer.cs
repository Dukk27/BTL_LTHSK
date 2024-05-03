namespace Forms_Login
{
    partial class Lop
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
            this.dgv_Lop = new System.Windows.Forms.DataGridView();
            this.sMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.textBoxSiSo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxMaKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Lop
            // 
            this.dgv_Lop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Lop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaLop,
            this.iSiSo,
            this.sTenLop,
            this.sMaKhoa});
            this.dgv_Lop.Location = new System.Drawing.Point(12, 280);
            this.dgv_Lop.Name = "dgv_Lop";
            this.dgv_Lop.RowHeadersWidth = 51;
            this.dgv_Lop.RowTemplate.Height = 24;
            this.dgv_Lop.Size = new System.Drawing.Size(815, 276);
            this.dgv_Lop.TabIndex = 0;
            this.dgv_Lop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lop_CellClick);
            // 
            // sMaLop
            // 
            this.sMaLop.DataPropertyName = "sMaLop";
            this.sMaLop.HeaderText = "Mã lớp";
            this.sMaLop.MinimumWidth = 6;
            this.sMaLop.Name = "sMaLop";
            // 
            // iSiSo
            // 
            this.iSiSo.DataPropertyName = "iSiSo";
            this.iSiSo.HeaderText = "Sĩ số";
            this.iSiSo.MinimumWidth = 6;
            this.iSiSo.Name = "iSiSo";
            // 
            // sTenLop
            // 
            this.sTenLop.DataPropertyName = "sTenLop";
            this.sTenLop.HeaderText = "Tên lớp";
            this.sTenLop.MinimumWidth = 6;
            this.sTenLop.Name = "sTenLop";
            // 
            // sMaKhoa
            // 
            this.sMaKhoa.DataPropertyName = "sMaKhoa";
            this.sMaKhoa.HeaderText = "Mã khoa";
            this.sMaKhoa.MinimumWidth = 6;
            this.sMaKhoa.Name = "sMaKhoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(367, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "LỚP";
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaLop.Location = new System.Drawing.Point(167, 88);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(183, 27);
            this.textBoxMaLop.TabIndex = 21;
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenLop.Location = new System.Drawing.Point(167, 152);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(183, 27);
            this.textBoxTenLop.TabIndex = 22;
            // 
            // textBoxSiSo
            // 
            this.textBoxSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSiSo.Location = new System.Drawing.Point(550, 88);
            this.textBoxSiSo.Name = "textBoxSiSo";
            this.textBoxSiSo.Size = new System.Drawing.Size(183, 27);
            this.textBoxSiSo.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sĩ số:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Mã khoa:";
            // 
            // buttonThem
            // 
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(60, 223);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(150, 34);
            this.buttonThem.TabIndex = 69;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(249, 223);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(150, 34);
            this.buttonSua.TabIndex = 70;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(446, 223);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(150, 34);
            this.buttonXoa.TabIndex = 71;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(636, 223);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(150, 34);
            this.buttonRefresh.TabIndex = 72;
            this.buttonRefresh.Text = "Làm mới";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxMaKhoa
            // 
            this.comboBoxMaKhoa.FormattingEnabled = true;
            this.comboBoxMaKhoa.Location = new System.Drawing.Point(550, 151);
            this.comboBoxMaKhoa.Name = "comboBoxMaKhoa";
            this.comboBoxMaKhoa.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMaKhoa.TabIndex = 73;
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 564);
            this.Controls.Add(this.comboBoxMaKhoa);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSiSo);
            this.Controls.Add(this.textBoxTenLop);
            this.Controls.Add(this.textBoxMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Lop);
            this.Name = "Lop";
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.TextBox textBoxSiSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.ComboBox comboBoxMaKhoa;
    }
}