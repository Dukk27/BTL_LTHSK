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
    public partial class BaoCaoSVKT : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        private DataView dataViewSVKT = new DataView();
        private DataTable tblSVKT = new DataTable();
        private ErrorProvider errorProvider = new ErrorProvider();
        private string curMaSV, curMaKT;

        public BaoCaoSVKT()
        {
            InitializeComponent();
        }

        private void BaoCaoSVKT_Load(object sender, EventArgs e)
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

        private void buttonInBaoCao_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT dbo.tblSinhVien.sMaSV, sTenLop, sHoTen, dNgaySinh, fDiemTB, fDiemRL FROM dbo.tblSinhVien, dbo.tblLop, dbo.tblSV_KT\r\n\t" +
                        "WHERE dbo.tblSinhVien.sMaLop = tblLop.sMaLop AND dbo.tblSinhVien.sMaSV = tblSV_KT.sMaSV";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandText = "SELECT dbo.tblSinhVien.sMaSV, sTenLop, sHoTen, dNgaySinh, fDiemTB, fDiemRL FROM dbo.tblSinhVien, dbo.tblLop, dbo.tblSV_KT\r\n\t" +
                        "WHERE dbo.tblSinhVien.sMaLop = tblLop.sMaLop AND dbo.tblSinhVien.sMaSV = tblSV_KT.sMaSV";
                    sqlCommand.CommandType = CommandType.Text;

                    sqlCommand.Parameters.Clear();
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        sqlDataAdapter.SelectCommand = sqlCommand;
                        using (DataTable dataTable = new DataTable("BangDiemSVKT"))
                        {
                            sqlDataAdapter.Fill(dataTable);


                            DSSV_KT dSSV_KT = new DSSV_KT();
                            dSSV_KT.SetDataSource(dataTable);

                            FormInBaoCao formInBaoCao = new FormInBaoCao();
                            formInBaoCao.crystalReportViewer.ReportSource = dSSV_KT;

                            formInBaoCao.Show();
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

    }
}
