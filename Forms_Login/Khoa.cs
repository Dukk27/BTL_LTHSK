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
    public partial class Khoa : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        private DataView dataViewKhoa = new DataView();
        private DataTable tblKhoa = new DataTable();
        private ErrorProvider errorProvider = new ErrorProvider();
        private string curMaKhoa;

        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            ListKhoa();
        }

        private void ListKhoa(string filter = "")
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
                        tblKhoa.Rows.Clear();
                        adapter.Fill(tblKhoa);
                        if (tblKhoa.Rows.Count > 0)
                        {
                            dataViewKhoa = tblKhoa.DefaultView;
                            dgv_Khoa.AutoGenerateColumns = false;
                            dataViewKhoa.RowFilter = filter;
                            dgv_Khoa.DataSource = dataViewKhoa;
                        }
                    }
                }
            }
        }

        private void dgv_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_Khoa.CurrentRow.Index;
            //chuyển dữ liệu từ các điều khiển tương ứng
            textBoxMaKhoa.Text = dgv_Khoa.Rows[index].Cells["sMaKhoa"].Value.ToString();
            textBoxTenKhoa.Text = dataViewKhoa[index]["sTenKhoa"].ToString();
            datetimeNTL.Text = dataViewKhoa[index]["dNgayThanhLap"].ToString();
           

            curMaKhoa = textBoxMaKhoa.Text;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn làm mới?", "Làm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                textBoxMaKhoa.Clear();
                textBoxTenKhoa.Clear();
                datetimeNTL.ResetText();  
                ListKhoa();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (textBoxMaKhoa.Text == "")
            {
                MessageBox.Show("Nhập mã khoa");
            }
            else if (textBoxTenKhoa.Text == "")
            {
                MessageBox.Show("Nhập tên khoa");
            }
            else
            {
                if (InsertKhoa("pr_InsertKhoa"))
                {
                    ListKhoa();
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
        }

        private bool InsertKhoa(string procName)
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


                        datetimeNTL.Format = DateTimePickerFormat.Custom;
                        datetimeNTL.CustomFormat = "MM/dd/yyyy hh:mm:ss";

                        sqlCommand.Parameters.AddWithValue("@sMaKhoa", textBoxMaKhoa.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@sTenKhoa", textBoxTenKhoa.Text.ToString().Trim());
                        sqlCommand.Parameters.AddWithValue("@dNgayThanhLap", datetimeNTL.Value);

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
            DialogResult result = MessageBox.Show("Bạn có muốn xóa dữ liệu khoa không?", "warning", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                if (DeleteKhoa("pr_DeleteKhoa"))
                {
                    MessageBox.Show("Xóa thành công !!!");
                    textBoxMaKhoa.Clear();
                    textBoxTenKhoa.Clear();
                    datetimeNTL.ResetText();
                    ListKhoa();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !!!");
                }
            }
        }

        private bool DeleteKhoa(string procName)
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

                        sqlCommand.Parameters.AddWithValue("@sMaKhoa", textBoxMaKhoa.Text.ToString().Trim());

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
            if (UpdateKhoa("pr_UpdateKhoa"))
            {
                ListKhoa();
                MessageBox.Show("Sửa mã khoa " + textBoxMaKhoa.Text + " thành công");
            }
            else
            {

            }
        }

        private bool UpdateKhoa(string procName)
        {
            try
            {

                if (textBoxMaKhoa.Text != curMaKhoa)
                {
                    MessageBox.Show("Không thể thay đổi mã khoa!!!");
                    return false;
                }
                else
                {
                    datetimeNTL.Format = DateTimePickerFormat.Custom;
                    datetimeNTL.CustomFormat = "MM/dd/yyyy";
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = procName;
                            sqlCommand.CommandType = CommandType.StoredProcedure;

                            sqlCommand.Parameters.AddWithValue("@sMaKhoa", textBoxMaKhoa.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@sTenKhoa", textBoxTenKhoa.Text.ToString().Trim());
                            sqlCommand.Parameters.AddWithValue("@dNgayThanhLap", datetimeNTL.Value.ToString());
                            
                            
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
    }
}
