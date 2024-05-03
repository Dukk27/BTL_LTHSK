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
using System.Configuration;
using System.Diagnostics;

namespace Forms_Login
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        ErrorProvider errorProvider = new ErrorProvider();

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //if (textBoxUserName.Text == null || textBoxUserName.Text == "")
            //{
            //    DialogResult dialogResult = MessageBox.Show("Tên đăng nhập đang để trống!");
            //}
            //else if (textBoxPassword.Text == null || textBoxPassword.Text == "")
            //{
            //    MessageBox.Show("Mật khẩu đang để trống!");
            //}
            //else
            //{
                LogIn();
            
        }

        private void LogIn()
        {
            string procSelectTK = "pr_SelectTaiKhoan";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = procSelectTK;
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = sqlCommand;
                        using (DataTable dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                foreach (DataRow row in dataTable.Rows)
                                {
                                    if (row["sTenDangNhap"].ToString() == textBoxUserName.Text.Trim())
                                    {
                                        if (row["sPassword"].ToString() == textBoxPassword.Text.Trim())
                                        {
                                            User.MaDangNhap = row["sMaDangNhap"].ToString();
                                            User.TenDangNhap = row["sTenDangNhap"].ToString();
                                            User.Password = row["sPassword"].ToString();
                                            Menu menuForm = new Menu();
                                            menuForm.ShowDialog();
                                            return;
                                        }
                                    }
                                }
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                            }
                            else
                            {
                                MessageBox.Show("Khong ton tai ban ghi nao!");
                            }
                        }
                    }
                }
            }
        }

        private void textBoxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn làm mới?", "Làm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                textBoxUserName.Clear();
                textBoxPassword.Clear();
                textBoxUserName.Focus();
            }
            else
            {
                this.Show();
            }
        }

        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxUserName.Text == "")
            { 
                e.Cancel = true;
                errorProvider.SetError(textBoxUserName, "!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxUserName, null);
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxPassword.Text.Length > 0) == true)
            {
                buttonLogin.Enabled = true;
            }
            else
                buttonLogin.Enabled = false;
        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if(textBoxUserName.Text == "")
            {
                buttonLogin.Enabled = false;
            }    
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPass.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
