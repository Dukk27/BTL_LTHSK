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
    public partial class ThongKeSVKT : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        private DataView dataViewSV = new DataView();
        private DataTable tblSV = new DataTable();
        private ErrorProvider errorProvider = new ErrorProvider();

        public ThongKeSVKT()
        {
            InitializeComponent();
        }

        private void ThongKeSVKT_Load(object sender, EventArgs e)
        {
            ListSinhVien();
        }

        private void ListSinhVien(string filter = "")
        {
            string procSelect = "pr_SelectedSVKT";
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
                            dataViewSV.Sort = "sMaSV ASC"; //DESC
                            dataGridViewSV.DataSource = dataViewSV;
                        }
                    }
                }
            }
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
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
            ListSinhVien(filter);
        }

        private void dataGridViewSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridViewSV.CurrentRow.Index;
            //chuyển dữ liệu từ các điều khiển tương ứng
            textBoxMaSV.Text = dataGridViewSV.Rows[index].Cells["sMaSV"].Value.ToString();
            textBoxHoTenSV.Text = dataViewSV[index]["sHoTen"].ToString();
        }

        private void buttonInBaoCao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMaSV.Text))
            {
                MessageBox.Show("Nhập mã sv");
                return;
            }
            string sqlQuery = "pr_KhenThuongCuaSV";
            //MessageBox.Show(sqlQuery);
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = sqlQuery;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.Clear();
                    sqlCommand.Parameters.AddWithValue("@sMaSV", textBoxMaSV.Text.ToString().Trim());
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        sqlDataAdapter.SelectCommand = sqlCommand;
                        using (DataTable dataTable = new DataTable("dtKTcuaSV"))
                        {
                            sqlDataAdapter.Fill(dataTable);


                            KTCuaSV ktCuaSV = new KTCuaSV();
                            ktCuaSV.SetParameterValue("NguoiLap", "a");
                            ktCuaSV.SetDataSource(dataTable);

                            

                            FormInBaoCao formInBaoCao = new FormInBaoCao();
                            formInBaoCao.crystalReportViewer.ReportSource = ktCuaSV;
                            

                            formInBaoCao.Show();
                        }
                    }
                }
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
                textBoxMaSV.Focus();
                ListSinhVien();
            }
            else
            {
                this.Show();
            }
        }
    }
}
