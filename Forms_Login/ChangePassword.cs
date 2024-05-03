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
    public partial class ChangePassword : Form
    {
        private string connectionString = "Data Source=DUKK;Initial Catalog=BTL_QLKT;Integrated Security=True";
        private ErrorProvider errorProvider = new ErrorProvider();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            textBoxUser.Text = User.TenDangNhap;
            btnCapnhat.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == null || textBoxNewPassword.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu mới");
            }
            else if (textBoxConfirmPassword.Text == null || textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Nhập xác nhận mật khẩu");
            }
            else if (textBoxNewPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận lại mật khẩu phải giống nhau");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn cập nhật không?", "Warning", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if(result == DialogResult.Yes)
                {
                    if (ChangePasswordEvent())
                    {
                        MessageBox.Show("Cập nhật thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                }
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ChangePasswordEvent()
        {
            string procSelect = "pr_ChangePassword";
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

                    sqlCommand.Parameters.AddWithValue("@sMaDangNhap", User.MaDangNhap);
                    sqlCommand.Parameters.AddWithValue("@sNewPassword", textBoxConfirmPassword.Text);

                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                    return i > 0;
                }
            }
        }

        private void textBoxNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBoxConfirmPassword.Focus();
            }
        }

        private void textBoxConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCapnhat.Focus();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn làm mới?", "Làm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                textBoxNewPassword.Clear();
                textBoxConfirmPassword.Clear(); 
            }
            else
            {
                this.Show();
            }
        }

        private void textBoxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxConfirmPassword.Text == "")
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxConfirmPassword, "Xác nhận lại mật khẩu mới!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxConfirmPassword, null);
            }
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                btnCapnhat.Enabled = false;
            }
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxConfirmPassword.Text.Length > 0) == true)
            {
                btnCapnhat.Enabled = true;
            }
            else
                btnCapnhat.Enabled = false;
        }
    }
}
