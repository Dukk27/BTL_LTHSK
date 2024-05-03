
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

namespace Forms_Login
{
    public partial class FormInBaoCao : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";

        public FormInBaoCao()
        {
            InitializeComponent();
        }

        //public void ShowReport()
        //{
        //    string sqlQuery = "SELECT dbo.tblSinhVien.sMaSV, sTenLop, sHoTen, dNgaySinh, fDiemTB, fDiemRL FROM dbo.tblSinhVien, dbo.tblLop, dbo.tblSV_KT\r\n\t" +
        //                "WHERE dbo.tblSinhVien.sMaLop = tblLop.sMaLop AND dbo.tblSinhVien.sMaSV = tblSV_KT.sMaSV";
        //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
        //        {
        //            sqlCommand.CommandText = "SELECT dbo.tblSinhVien.sMaSV, sTenLop, sHoTen, dNgaySinh, fDiemTB, fDiemRL FROM dbo.tblSinhVien, dbo.tblLop, dbo.tblSV_KT\r\n\t" +
        //                "WHERE dbo.tblSinhVien.sMaLop = tblLop.sMaLop AND dbo.tblSinhVien.sMaSV = tblSV_KT.sMaSV";
        //            sqlCommand.CommandType = CommandType.Text;

        //            sqlCommand.Parameters.Clear();
        //            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
        //            {
        //                sqlDataAdapter.SelectCommand = sqlCommand;
        //                using (DataTable dataTable = new DataTable("BangDiemSVKT"))
        //                {
        //                    sqlDataAdapter.Fill(dataTable);

        //                    ReportDocument reportDocument = new ReportDocument();

        //                    string path = "D:\\Code\\LTHSK\\BTL_LTHSK\\Forms_Login\\BaoCao\\DSSV_KT.rpt";
        //                    reportDocument.Load(path);
        //                    reportDocument.Database.Tables[sqlQuery].SetDataSource(dataTable);

        //                    crystalReportViewer.ReportSource = reportDocument;
        //                }
        //            }
        //        }
        //    }
        //}

        private void FormInBaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
