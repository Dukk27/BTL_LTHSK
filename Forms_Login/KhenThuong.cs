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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Forms_Login
{
    public partial class KhenThuong : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        private DataView dataViewSV = new DataView();
        private DataTable tblKT = new DataTable();
        private ErrorProvider errorProvider = new ErrorProvider();
        private string curMaKT;

        public KhenThuong()
        {
            InitializeComponent();
        }

        private void KhenThuong_Load(object sender, EventArgs e)
        {
            listMaKhoa();

            ListKhenThuong();
        }

        private void listMaKhoa()
        {
            string procName = "pr_SelectMaKhoa";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = procName;
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
                                    string line = row["sMaKhoa"].ToString();
                                    cbMaKhoa.Items.Add(line);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ListKhenThuong(string filter = "")
        {
            string procSelect = "pr_SelectKT";
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
                        tblKT.Rows.Clear();
                        adapter.Fill(tblKT);
                        if (tblKT.Rows.Count > 0)
                        {
                            dataViewSV = tblKT.DefaultView;
                            dgv_KhenThuong.AutoGenerateColumns = false;
                            dataViewSV.RowFilter = filter;
                            dgv_KhenThuong.DataSource = dataViewSV;
                        }
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaKT.Text == "")
            {
                MessageBox.Show("Nhập mã khen thưởng");
            }
            else if (cbMaKhoa.Text == "")
            {
                MessageBox.Show("Chọn mã khoa");
            }
            else if (textBoxTenKT.Text == "")
            {
                MessageBox.Show("Nhập tên khen thưởng");
            }
            else if (textBoxHocKy.Text == "")
            {
                MessageBox.Show("Nhập học kỳ");
            }
            else if (textBoxNamHoc.Text == "")
            {
                MessageBox.Show("Nhập năm học");
            }
            else
            {
                if (InsertKT("pr_InsertKT"))
                {
                    ListKhenThuong();
                    MessageBox.Show("Thêm khen thưởng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm khen không thưởng thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (UpdatKT("pr_UpdateKT"))
            {
                ListKhenThuong();
                MessageBox.Show("Sửa mã khen thưởng " + textBoxMaKT.Text + " thành công");
            }
            else
            {

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa khen thưởng không? (sẽ xóa cả khen thưởng của sinh viên nếu có)", "warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (DeleteKT("pr_DeleteKT"))
                {
                    MessageBox.Show("Xóa thành công !!!");
                    textBoxMaKT.Clear();
                    textBoxTenKT.Clear();
                    cbMaKhoa.ResetText();
                    textBoxHocKy.Clear();
                    dateTimeNgayLap.ResetText();
                    textBoxNamHoc.Clear();
                    ListKhenThuong();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!!");
                }
            }
        }

        private bool InsertKT(string procName)
        {
            try
            {
                string procSelect = procName;

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = procSelect;
                        sqlCommand.CommandType = CommandType.StoredProcedure;


                        dateTimeNgayLap.Format = DateTimePickerFormat.Custom;
                        dateTimeNgayLap.CustomFormat = "MM/dd/yyyy hh:mm:ss";

                        sqlCommand.Parameters.AddWithValue("@sMaKT", textBoxMaKT.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@dNgayLap", dateTimeNgayLap.Value);
                        sqlCommand.Parameters.AddWithValue("@sTenKT", textBoxTenKT.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sHocKy", textBoxHocKy.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sNamHoc", textBoxNamHoc.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sMaKhoa", cbMaKhoa.Text.ToString().Trim());

                        sqlConnection.Open();
                        int i = sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        return i > 0;
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        private bool UpdatKT(string procName)
        {
            try
            {

                if (textBoxMaKT.Text != curMaKT)
                {
                    MessageBox.Show("Không thể thay đổi mã khen thưởng!!!");
                    return false;
                }
                else
                {
                    dateTimeNgayLap.Format = DateTimePickerFormat.Custom;
                    dateTimeNgayLap.CustomFormat = "MM/dd/yyyy";
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = procName;
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.AddWithValue("@sMaKT", textBoxMaKT.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@sMaKhoa", cbMaKhoa.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@dNgayLap", dateTimeNgayLap.Value.ToString());
                            sqlCommand.Parameters.AddWithValue("@sTenKT", textBoxTenKT.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@sHocKy", textBoxHocKy.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@sNamHoc", textBoxNamHoc.Text.ToString().Trim());

                            sqlConnection.Open();
                            int i = sqlCommand.ExecuteNonQuery();
                            sqlConnection.Close();

                            return i > 0;
                        }
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
                return false;
            }
        }

        private bool DeleteKT(string procName)
        {
            try
            {
                string procSelect = procName;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        sqlCommand.CommandText = procSelect;
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        sqlCommand.Parameters.AddWithValue("@sMaKT", textBoxMaKT.Text.ToString().Trim());

                        sqlConnection.Open();
                        int i = sqlCommand.ExecuteNonQuery();
                        sqlConnection.Close();

                        return i > 0;
                    }
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
                return false;
            }
        }

        private void dgv_KhenThuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_KhenThuong.CurrentRow.Index;
            //chuyển dữ liệu từ các điều khiển tương ứng
            textBoxMaKT.Text = dgv_KhenThuong.Rows[index].Cells["sMaKT"].Value.ToString();
            textBoxTenKT.Text = dataViewSV[index]["sTenKT"].ToString();
            dateTimeNgayLap.Text = dataViewSV[index]["dNgayLap"].ToString();
            textBoxHocKy.Text = dataViewSV[index]["sHocKy"].ToString();
            textBoxNamHoc.Text = dataViewSV[index]["sNamHoc"].ToString();
            cbMaKhoa.Text = dataViewSV[index]["sMaKhoa"].ToString();

            curMaKT = textBoxMaKT.Text;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string filter = "sMaKT is not null";
            if (!string.IsNullOrEmpty(textBoxMaKT.Text))
            {
                filter += string.Format(" AND sMaKT LIKE '%{0}%'", textBoxMaKT.Text);
            }
            if (!string.IsNullOrEmpty(textBoxTenKT.Text))
            {
                filter += string.Format(" AND sTenKT LIKE '%{0}%'", textBoxTenKT.Text);
            }
            if (!string.IsNullOrEmpty(cbMaKhoa.Text))
            {
                filter += string.Format(" AND sMaKhoa LIKE '%{0}%'", cbMaKhoa.Text);
            }

            if (!string.IsNullOrEmpty(textBoxHocKy.Text))
            {
                filter += string.Format(" AND sHocKy LIKE '%{0}%'", textBoxHocKy.Text);
            }

            if (!string.IsNullOrEmpty(textBoxNamHoc.Text))
            {
                filter += string.Format(" AND sNamHoc LIKE '%{0}%'", textBoxNamHoc.Text);
            }
            ListKhenThuong(filter);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn làm mới?", "Làm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                textBoxMaKT.Clear();
                textBoxTenKT.Clear();
                cbMaKhoa.ResetText();
                textBoxHocKy.Clear();
                dateTimeNgayLap.ResetText();
                textBoxNamHoc.Clear();
                ListKhenThuong();
            }
            else
            {
                this.Show();
            }
        }
    }
}
