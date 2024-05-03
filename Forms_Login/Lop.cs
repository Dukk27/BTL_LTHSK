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
    public partial class Lop : Form
    {

        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        private DataView dataViewLop = new DataView();
        private DataTable tblLop = new DataTable();
        private ErrorProvider errorProvider = new ErrorProvider();
        private string curMaLop;

        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            ListLop();
            listMaKhoa();
        }

        private void ListLop(string filter = "")
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
                        tblLop.Rows.Clear();
                        adapter.Fill(tblLop);
                        if (tblLop.Rows.Count > 0)
                        {
                            dataViewLop = tblLop.DefaultView;
                            dgv_Lop.AutoGenerateColumns = false;
                            dataViewLop.RowFilter = filter;
                            dgv_Lop.DataSource = dataViewLop;
                        }
                    }
                }
            }
        }

        private void dgv_Lop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_Lop.CurrentRow.Index;
            //chuyển dữ liệu từ các điều khiển tương ứng
            textBoxMaLop.Text = dgv_Lop.Rows[index].Cells["sMaLop"].Value.ToString();
            textBoxSiSo.Text = dataViewLop[index]["iSiSo"].ToString();
            textBoxTenLop.Text = dataViewLop[index]["sTenLop"].ToString();
            comboBoxMaKhoa.Text = dataViewLop[index]["sMaKhoa"].ToString();

            curMaLop = textBoxMaLop.Text;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaLop.Text == "")
            {
                MessageBox.Show("Nhập mã lớp");
            }
            else if (textBoxTenLop.Text == "")
            {
                MessageBox.Show("Nhập tên lớp");
            }
          
            //else if (textBoxMaKhoa.Text == "")
            //{
            //    MessageBox.Show("Nhập mã khoa");
            //}
            else
            {
                if (InsertLop("pr_InsertLop"))
                {
                    ListLop();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private bool InsertLop(string procName)
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

                        sqlCommand.Parameters.AddWithValue("@sMaLop", textBoxMaLop.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@iSiSo", textBoxSiSo.Text.ToString());
                        sqlCommand.Parameters.AddWithValue("@sTenLop", textBoxTenLop.Text.ToString().Trim());     
                        sqlCommand.Parameters.AddWithValue("@sMaKhoa", comboBoxMaKhoa.Text.ToString().Trim());

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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu lớp không?", "warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                if (DeleteLop("pr_DeleteLop"))
                {
                    MessageBox.Show("Xóa thành công !!!");
                    textBoxMaLop.Clear();
                    textBoxSiSo.Clear();
                    textBoxTenLop.Clear();
                    comboBoxMaKhoa.ResetText();
                    ListLop();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!!");
                }
            }
        }

        private bool DeleteLop(string procName)
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

                        sqlCommand.Parameters.AddWithValue("@sMaLop", textBoxMaLop.Text.ToString().Trim());

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

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (UpdateLop("pr_UpdateLop"))
            {
                ListLop();
                MessageBox.Show("Sửa mã lớp " + textBoxMaLop.Text + " thành công");
            }
            else
            {

            }
        }

        private bool UpdateLop(string procName)
        {
            try
            {

                if (textBoxMaLop.Text != curMaLop)
                {
                    MessageBox.Show("Không thể thay đổi mã lớp!!!");
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

                            sqlCommand.Parameters.AddWithValue("@sMaLop", textBoxMaLop.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@sTenLop", textBoxTenLop.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@sMaKhoa", comboBoxMaKhoa.Text.ToString().Trim());


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
            }
        }

        private void listMaKhoa()
        {
            string procSelect = "pr_SelectKhoa";
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
                                    string line = row["sMaKhoa"].ToString();
                                    comboBoxMaKhoa.Items.Add(line);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn làm mới?", "Làm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                textBoxMaLop.Clear();
                textBoxSiSo.Clear();    
                textBoxTenLop.Clear();
                comboBoxMaKhoa.ResetText();
                ListLop();
            }
            else
            {
                this.Show();
            }
        }
    }
}
