using CrystalDecisions.CrystalReports.Engine;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Forms_Login
{
    public partial class SVKT : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        private DataView dataViewSVKT = new DataView();
        private DataTable tblSVKT = new DataTable();
        private ErrorProvider errorProvider = new ErrorProvider();
        private string curMaSV, curMaKT;

        public SVKT()
        {
            InitializeComponent();
        }

        private void SVKT_Load(object sender, EventArgs e)
        {
            listComBoBox("pr_SelectMaSV", cbMaSV, "sMaSV");
            listComBoBox("pr_SelectMaKT", cbMaKT, "sMaKT");

            ListSinhVien();
        }

        private void listComBoBox(string procName, ComboBox comboBoxFill, string rowFill)
        {
            string procSelect = procName;
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
                                    string line = row[rowFill].ToString();
                                    comboBoxFill.Items.Add(line);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void ListSinhVien(string filter = "")
        {
            string procSelect = "pr_SelectSVKT";
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
                        tblSVKT.Rows.Clear();
                        adapter.Fill(tblSVKT);
                        if (tblSVKT.Rows.Count > 0)
                        {
                            dataViewSVKT = tblSVKT.DefaultView;
                            dgv_SVKT.AutoGenerateColumns = false;
                            dataViewSVKT.RowFilter = filter;
                            dgv_SVKT.DataSource = dataViewSVKT;
                        }
                    }
                }
            }
        }


        private void dgv_SVKT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_SVKT.CurrentRow.Index;
            //chuyển dữ liệu từ các điều khiển tương ứng
            cbMaKT.Text = dgv_SVKT.Rows[index].Cells["sMaKT"].Value.ToString();
            cbMaSV.Text = dgv_SVKT.Rows[index].Cells["sMaSV"].Value.ToString();
            textBoxSoTC.Text = dataViewSVKT[index]["iSoTC"].ToString();
            textBoxDiemTB.Text = dataViewSVKT[index]["fDiemTB"].ToString();
            textBoxDiemRL.Text = dataViewSVKT[index]["fDiemRL"].ToString();

            curMaKT = cbMaKT.Text;
            curMaSV = cbMaSV.Text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbMaSV.Text == "")
            {
                MessageBox.Show("Chọn mã sinh viên");
            }
            else if (cbMaKT.Text == "")
            {
                MessageBox.Show("Chọn mã khen thưởng");
            }
            else if (textBoxSoTC.Text == "")
            {
                MessageBox.Show("Nhập số tín chỉ");
            }
            else if (int.Parse(textBoxSoTC.Text.ToString()) <= 15)
            {
                MessageBox.Show("Số tín chỉ phải lớn hơn 15");
            }
            else if (textBoxDiemTB.Text == "")
            {
                MessageBox.Show("Nhập điểm trung bình");
            }
            else if (textBoxDiemRL.Text == "")
            {
                MessageBox.Show("Nhập điểm rèn luyện");
            }
            
            else if (int.Parse(textBoxDiemRL.Text.ToString()) < 70)
            {
                MessageBox.Show("Điểm rèn luyện phải lớn hơn 70");
            }
            else
            {
                if (InsertSVKT("pr_InsertSVKT"))
                {
                    ListSinhVien();
                    MessageBox.Show("Them sinh viên khen thưởng thành công");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (textBoxSoTC.Text == "")
            {
                MessageBox.Show("Nhập số tín chỉ");
            }
            else if (textBoxDiemTB.Text == "")
            {
                MessageBox.Show("Nhập điểm trung bình");
            }
            else if (textBoxDiemRL.Text == "")
            {
                MessageBox.Show("Nhập điểm rèn luyện");
            }
            else if (int.Parse(textBoxSoTC.Text.ToString()) <= 15)
            {
                MessageBox.Show("Số tín chỉ phải lớn hơn 15");
            }
            else if (int.Parse(textBoxDiemRL.Text.ToString()) < 70)
            {
                MessageBox.Show("Điểm rèn luyện phải lớn hơn 70");
            }
            else
            {
                if (UpdateSVKT("pr_UpdateSVKT"))
                {
                    ListSinhVien();
                    MessageBox.Show("Sửa sinh viên khen thưởng thành công");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbMaSV.Text == "")
            {
                MessageBox.Show("Chọn mã sinh viên");
            }
            else if (cbMaKT.Text == "")
            {
                MessageBox.Show("Chọn mã khen thưởng");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên khen thưởng không?", "warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if (DeleteSVKT("pr_DeleteSVKT"))
                    {
                        ListSinhVien();
                        MessageBox.Show("Xóa thành công !!!");
                        cbMaKT.ResetText();
                        cbMaSV.ResetText();
                        textBoxSoTC.Clear();
                        textBoxDiemTB.Clear();
                        textBoxDiemRL.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại !!!");
                    }
                }
            }
        }


        private bool InsertSVKT(string procName)
        {
            try
            {
                string procSelect = procName;
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                    {
                        //sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = procSelect;
                        sqlCommand.CommandType = CommandType.StoredProcedure;


                        sqlCommand.Parameters.AddWithValue("@sMaKT", cbMaKT.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sMaSV", cbMaSV.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@iSoTC", int.Parse(textBoxSoTC.Text.ToString()));
                        sqlCommand.Parameters.AddWithValue("@fDiemTB", float.Parse(textBoxDiemTB.Text.ToString()));
                        sqlCommand.Parameters.AddWithValue("@fDiemRL", float.Parse(textBoxDiemRL.Text.ToString()));

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

        private bool UpdateSVKT(string procName)
        {
            try
            {

                if (cbMaKT.Text != curMaKT || cbMaSV.Text != curMaSV)
                {
                    MessageBox.Show("Không thể thay đổi mã sinh viên hoặc mã khen thưởng!!!");
                    return false;
                }
                else
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = procName;
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.AddWithValue("@sMaKT", cbMaKT.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@sMaSV", cbMaSV.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@iSoTC", int.Parse(textBoxSoTC.Text.ToString().Trim()));
                            sqlCommand.Parameters.AddWithValue("@fDiemTB", float.Parse(textBoxDiemTB.Text.ToString().Trim()));
                            sqlCommand.Parameters.AddWithValue("@fDiemRL", float.Parse(textBoxDiemRL.Text.ToString().Trim()));

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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaKT is not null";
            if (!string.IsNullOrEmpty(cbMaSV.Text))
            {
                filter += string.Format(" AND sMaSV LIKE '%{0}%'", cbMaSV.Text);
            }
            if (!string.IsNullOrEmpty(cbMaKT.Text))
            {
                filter += string.Format(" AND sMaKT LIKE '%{0}%'", cbMaKT.Text);
            }
            if (!string.IsNullOrEmpty(textBoxSoTC.Text))
            {
                filter += string.Format(" AND iSoTC LIKE '%{0}%'", textBoxSoTC.Text);
            }

            if (!string.IsNullOrEmpty(textBoxDiemTB.Text))
            {
                filter += string.Format(" AND fDiemTB LIKE '%{0}%'", textBoxDiemTB.Text);
            }

            if (!string.IsNullOrEmpty(textBoxDiemRL.Text))
            {
                filter += string.Format(" AND fDiemRL LIKE '%{0}%'", textBoxDiemRL.Text);
            }
            ListSinhVien(filter);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn làm mới?", "Làm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                cbMaKT.ResetText();
                cbMaSV.ResetText();
                textBoxSoTC.Clear();
                textBoxDiemTB.Clear();
                textBoxDiemRL.Clear();
                ListSinhVien();
            }
            else
            {
                this.Show();
            }
        }

        private bool DeleteSVKT(string procName)
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

                        sqlCommand.Parameters.AddWithValue("@sMaKT", cbMaKT.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sMaSV", cbMaSV.Text.ToString().Trim());

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
    }
}
