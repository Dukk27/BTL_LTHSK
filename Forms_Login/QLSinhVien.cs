using Forms_Login.BaoCao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Login
{
    public partial class QLSinhVien : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        private DataView dataViewSV = new DataView();
        private DataTable tblSV = new DataTable();
        private ErrorProvider errorProvider = new ErrorProvider();
        private string curMaSV;

        public QLSinhVien()
        {
            InitializeComponent();
        }

        private void QLSinhVien_Load(object sender, EventArgs e)
        {
            buttonThemMoi.Enabled = false;
            listMaLop();
            ListSinhVien();
        }

        private void listMaLop()
        {
            string procSelect = "pr_SelectLop";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = procSelect;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = sqlCommand;
                        using (DataTable dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                //Hien thi du lieu ra man hinh
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    string line = row["sMalop"].ToString();
                                    comboBoxMaLop.Items.Add(line);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ListSinhVien(string filter = "")
        {
            string procSelect = "pr_SelectedSV";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = procSelect;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = sqlCommand;
                        tblSV.Rows.Clear();
                        adapter.Fill(tblSV);
                        if (tblSV.Rows.Count > 0)
                        {
                            dataViewSV = tblSV.DefaultView;
                            dataGridViewSV.AutoGenerateColumns = false;
                            dataViewSV.RowFilter = filter;
                            dataGridViewSV.DataSource = dataViewSV;
                        }
                    }
                }
            }
        }

        private void buttonThemMoi_Click(object sender, EventArgs e)
        {
            if (textBoxHoTenSV.Text == "" || textBoxMaSV.Text == "")
            {
                MessageBox.Show("Nhập họ tên sinh viên");
                return;
            }
            else if (InsertSV("pr_InsertSV"))
            {
                ListSinhVien();
                MessageBox.Show("Thêm thành công");
            }
        }

        private bool InsertSV(string procName)
        {
            try
            {
                string procSelect = procName;
                string gioiTinh = "";
                if (radioButtonNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        //sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = procSelect;
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        //using (SqlDataAdapter adapter = new SqlDataAdapter())
                        //{
                        //    adapter.UpdateCommand = sqlCommand;
                        //}

                        dateTimeNgaySinh.Format = DateTimePickerFormat.Custom;
                        dateTimeNgaySinh.CustomFormat = "MM/dd/yyyy";

                        sqlCommand.Parameters.AddWithValue("@sMaSV", textBoxMaSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sHoTen", textBoxHoTenSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@dNgaySinh", dateTimeNgaySinh.Value);
                        sqlCommand.Parameters.AddWithValue("@sGioiTinh", gioiTinh);
                        sqlCommand.Parameters.AddWithValue("@sDiaChi", textBoxDiaChiSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sMail", textBoxEmailSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sSDT", textBoxSDTSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sMaLop", comboBoxMaLop.Text.ToString().Trim());

                        sqlConnection.Open();
                        int i = sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        return i > 0;
                    }
                }
            }
            catch (SqlException se)
            {
                string err = se.Message;
                if (err.Contains("FOREIGN"))
                {
                    MessageBox.Show("Lỗi khóa ngoại");
                }
                else
                {
                    MessageBox.Show(se.Message);
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }


        private void dataGridViewSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewSV.CurrentRow.Index;
            //chuyển dữ liệu từ các điều khiển tương ứng
            textBoxMaSV.Text = dataGridViewSV.Rows[index].Cells["sMaSV"].Value.ToString();
            textBoxHoTenSV.Text = dataViewSV[index]["sHoTen"].ToString();
            dateTimeNgaySinh.Text = dataViewSV[index]["dNgaySinh"].ToString();
            textBoxDiaChiSV.Text = dataViewSV[index]["sDiaChi"].ToString();
            textBoxEmailSV.Text = dataViewSV[index]["sMail"].ToString();
            comboBoxMaLop.Text = dataViewSV[index]["sMaLop"].ToString();
            textBoxSDTSV.Text = dataViewSV[index]["sSDT"].ToString();

            string gioiTinh = dataViewSV[index]["sGioiTinh"].ToString();
            if (gioiTinh == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (textBoxMaSV.Text == "")
            {
                MessageBox.Show("Nhập mã sinh viên cần sửa!!!");
            }
            else if (textBoxHoTenSV.Text == "")
            {
                MessageBox.Show("Họ tên không được để trống");
            }
            else if (comboBoxMaLop.Text == "")
            {
                MessageBox.Show("Mã lớp không được để trống");
            }
            else if (UpdateSV("pr_UpdateSV"))
            {
                MessageBox.Show("Sửa sinh viên có mã " + textBoxMaSV.Text + " thành công");

                ListSinhVien();
            }
            else
            {

            }
        }

        private bool UpdateSV(string procName)
        {
            try
            {
                dateTimeNgaySinh.Format = DateTimePickerFormat.Custom;
                dateTimeNgaySinh.CustomFormat = "MM/dd/yyyy";

                string gioiTinh = "";
                if (radioButtonNam.Checked)
                {
                    gioiTinh = "Nam";
                }
                else gioiTinh = "Nữ";
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = procName;
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.AddWithValue("@sMaSV", textBoxMaSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sHoTen", textBoxHoTenSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@dNgaySinh", dateTimeNgaySinh.Value);
                        sqlCommand.Parameters.AddWithValue("@sGioiTinh", gioiTinh);
                        sqlCommand.Parameters.AddWithValue("@sDiaChi", textBoxDiaChiSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sMail", textBoxEmailSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sSDT", textBoxSDTSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sMaLop", comboBoxMaLop.Text.ToString().Trim());

                        sqlConnection.Open();
                        int i = sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        return i > 0;
                    }
                }
            }
            catch (SqlException se)
            {
                string err = se.Message;
                if (err.Contains("FOREIGN"))
                {
                    MessageBox.Show("Lỗi khoá ngoại");
                }
                else
                {
                    MessageBox.Show(se.Message);
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
                return false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên không? (sẽ xóa cả khen thưởng nếu có)", "warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (DeleteSV("pr_DeleteSV"))
                {
                    MessageBox.Show("Xóa thành công !!!");
                    textBoxMaSV.Clear();
                    textBoxHoTenSV.Clear();
                    textBoxHoTenSV.Clear();
                    textBoxEmailSV.Clear();
                    comboBoxMaLop.ResetText();
                    dateTimeNgaySinh.ResetText();
                    textBoxDiaChiSV.Clear();
                    textBoxSDTSV.Clear();
                    ListSinhVien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!!");
                }
            }
        }

        private bool DeleteSV(string procName)
        {
            string procSelect = procName;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    //sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = procSelect;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    //using (SqlDataAdapter adapter = new SqlDataAdapter())
                    //{
                    //    adapter.UpdateCommand = sqlCommand;
                    //}

                    sqlCommand.Parameters.AddWithValue("@sMaSV", textBoxMaSV.Text.ToString().Trim());

                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    return i > 0;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaSV is not null";
            if (!string.IsNullOrEmpty(textBoxMaSV.Text))
            {
                filter += string.Format(" AND sMaSV LIKE '%{0}%'", textBoxMaSV.Text);
            }
            if (!string.IsNullOrEmpty(textBoxHoTenSV.Text))
            {
                filter += string.Format(" AND sHoTen LIKE '%{0}%'", textBoxHoTenSV.Text);
            }
            if (!string.IsNullOrEmpty(comboBoxMaLop.Text))
            {
                filter += string.Format(" AND sMaLop LIKE '%{0}%'", comboBoxMaLop.Text);
            }
            ListSinhVien(filter);
        }

        
        private void dataGridViewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewSV.CurrentRow.Index;
            //chuyển dữ liệu từ các điều khiển tương ứng
            textBoxMaSV.Text = dataGridViewSV.Rows[index].Cells["sMaSV"].Value.ToString();
            textBoxHoTenSV.Text = dataViewSV[index]["sHoTen"].ToString();
            dateTimeNgaySinh.Text = dataViewSV[index]["dNgaySinh"].ToString();
            textBoxDiaChiSV.Text = dataViewSV[index]["sDiaChi"].ToString();
            textBoxEmailSV.Text = dataViewSV[index]["sMail"].ToString();
            comboBoxMaLop.Text = dataViewSV[index]["sMaLop"].ToString();
            textBoxSDTSV.Text = dataViewSV[index]["sSDT"].ToString();
            curMaSV = textBoxMaSV.Text;

            string gioiTinh = dataViewSV[index]["sGioiTinh"].ToString();
            if (gioiTinh == "Nam")
            {
                radioButtonNam.Checked = true;
            }
            else
            {
                radioButtonNu.Checked = true;
            }
        }

        private bool isNumber(string strValue)
        {
            foreach (char ch in strValue)
            {
                if (!char.IsDigit(ch))
                    return false;
            }
            return true;
        }

        private void textBoxSDTSV_Validating(object sender, CancelEventArgs e)
        {
            if (isNumber(textBoxSDTSV.Text))
            {
                errorProvider.SetError(textBoxSDTSV, null);

            }
            else
                errorProvider.SetError(textBoxSDTSV, "SDT chỉ dùng số");
        }

        private void textBoxSDTSV_TextChanged(object sender, EventArgs e)
        {
            if (isNumber(textBoxSDTSV.Text))
            {
                buttonThemMoi.Enabled = true;
            }
            else
                buttonThemMoi.Enabled = false;
        }

        private void textBoxMaSV_Validating_1(object sender, CancelEventArgs e)
        {
            if (textBoxMaSV.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxMaSV, "Mã sinh viên không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxMaSV, null);
            }
        }

        private void textBoxMaSV_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMaSV.Text == "")
            {
                buttonThemMoi.Enabled = false;
            }
        }

        private void textBoxHoTenSV_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHoTenSV.Text == "")
            {
                buttonThemMoi.Enabled = false;
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn làm mới?", "Làm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                textBoxMaSV.Clear();
                textBoxHoTenSV.Clear();
                textBoxHoTenSV.Clear();
                textBoxEmailSV.Clear();
                comboBoxMaLop.ResetText();
                dateTimeNgaySinh.ResetText();
                textBoxDiaChiSV.Clear();
                textBoxSDTSV.Clear();
                ListSinhVien();
            }
            else
            {
                this.Show();
            }
        }
    }
}
