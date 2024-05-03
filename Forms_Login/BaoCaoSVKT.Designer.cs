namespace Forms_Login
{
    partial class BaoCaoSVKT
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
            this.dgv_SVKT = new System.Windows.Forms.DataGridView();
            this.sMaKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiemRL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaSV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaKT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSoTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDiemTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDiemRL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonInBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SVKT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_SVKT
            // 
            this.dgv_SVKT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SVKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SVKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaKT,
            this.sMaSV,
            this.iSoTC,
            this.fDiemTB,
            this.fDiemRL});
            this.dgv_SVKT.Location = new System.Drawing.Point(12, 287);
            this.dgv_SVKT.Name = "dgv_SVKT";
            this.dgv_SVKT.RowHeadersWidth = 51;
            this.dgv_SVKT.RowTemplate.Height = 24;
            this.dgv_SVKT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SVKT.Size = new System.Drawing.Size(1044, 297);
            this.dgv_SVKT.TabIndex = 29;
            this.dgv_SVKT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SVKT_CellClick);
            // 
            // sMaKT
            // 
            this.sMaKT.DataPropertyName = "sMaKT";
            this.sMaKT.HeaderText = "Mã khen thưởng";
            this.sMaKT.MinimumWidth = 6;
            this.sMaKT.Name = "sMaKT";
            // 
            // sMaSV
            // 
            this.sMaSV.DataPropertyName = "sMaSV";
            this.sMaSV.HeaderText = "Mã sinh viên";
            this.sMaSV.MinimumWidth = 6;
            this.sMaSV.Name = "sMaSV";
            // 
            // iSoTC
            // 
            this.iSoTC.DataPropertyName = "iSoTC";
            this.iSoTC.HeaderText = "Số tín chỉ";
            this.iSoTC.MinimumWidth = 6;
            this.iSoTC.Name = "iSoTC";
            // 
            // fDiemTB
            // 
            this.fDiemTB.DataPropertyName = "fDiemTB";
            this.fDiemTB.HeaderText = "Điểm trung bình";
            this.fDiemTB.MinimumWidth = 6;
            this.fDiemTB.Name = "fDiemTB";
            // 
            // fDiemRL
            // 
            this.fDiemRL.DataPropertyName = "fDiemRL";
            this.fDiemRL.HeaderText = "Điểm rèn luyện";
            this.fDiemRL.MinimumWidth = 6;
            this.fDiemRL.Name = "fDiemRL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(344, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 36);
            this.label1.TabIndex = 30;
            this.label1.Text = "SINH VIÊN - KHEN THƯỞNG";
            // 
            // cbMaSV
            // 
            this.cbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSV.FormattingEnabled = true;
            this.cbMaSV.Location = new System.Drawing.Point(209, 81);
            this.cbMaSV.Name = "cbMaSV";
            this.cbMaSV.Size = new System.Drawing.Size(283, 28);
            this.cbMaSV.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã SV: ";
            // 
            // cbMaKT
            // 
            this.cbMaKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKT.FormattingEnabled = true;
            this.cbMaKT.Location = new System.Drawing.Point(693, 81);
            this.cbMaKT.Name = "cbMaKT";
            this.cbMaKT.Size = new System.Drawing.Size(283, 28);
            this.cbMaKT.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(534, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Mã khen thưởng: ";
            // 
            // textBoxSoTC
            // 
            this.textBoxSoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoTC.Location = new System.Drawing.Point(150, 151);
            this.textBoxSoTC.Name = "textBoxSoTC";
            this.textBoxSoTC.Size = new System.Drawing.Size(157, 27);
            this.textBoxSoTC.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Số tín chỉ: ";
            // 
            // textBoxDiemTB
            // 
            this.textBoxDiemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiemTB.Location = new System.Drawing.Point(514, 151);
            this.textBoxDiemTB.Name = "textBoxDiemTB";
            this.textBoxDiemTB.Size = new System.Drawing.Size(157, 27);
            this.textBoxDiemTB.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Điểm trung bình: ";
            // 
            // textBoxDiemRL
            // 
            this.textBoxDiemRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiemRL.Location = new System.Drawing.Point(871, 151);
            this.textBoxDiemRL.Name = "textBoxDiemRL";
            this.textBoxDiemRL.Size = new System.Drawing.Size(157, 27);
            this.textBoxDiemRL.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(720, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Điểm rèn luyện: ";
            // 
            // buttonInBaoCao
            // 
            this.buttonInBaoCao.BackColor = System.Drawing.Color.IndianRed;
            this.buttonInBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInBaoCao.Location = new System.Drawing.Point(466, 227);
            this.buttonInBaoCao.Name = "buttonInBaoCao";
            this.buttonInBaoCao.Size = new System.Drawing.Size(134, 37);
            this.buttonInBaoCao.TabIndex = 41;
            this.buttonInBaoCao.Text = "In báo cáo";
            this.buttonInBaoCao.UseVisualStyleBackColor = false;
            this.buttonInBaoCao.Click += new System.EventHandler(this.buttonInBaoCao_Click);
            // 
            // BaoCaoSVKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 596);
            this.Controls.Add(this.buttonInBaoCao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDiemRL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDiemTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSoTC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbMaKT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_SVKT);
            this.Name = "BaoCaoSVKT";
            this.Text = "BaoCaoSVKT";
            this.Load += new System.EventHandler(this.BaoCaoSVKT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SVKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_SVKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiemTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiemRL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaKT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSoTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDiemTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDiemRL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonInBaoCao;
    }
}