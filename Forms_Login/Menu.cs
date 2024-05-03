using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Login
{
    public partial class Menu : Form
    {
        private ChangePassword changePassword = new ChangePassword();
        private SVKT SvKt = new SVKT();
        private KhenThuong kt = new KhenThuong();
        private QLSinhVien sv = new QLSinhVien();
        private ThongKeSVKT tkSV = new ThongKeSVKT();
        private Khoa khoa = new Khoa();
        private Lop lop = new Lop();   
        private BaoCaoSVKT baoCao = new BaoCaoSVKT();

        public Menu()
        {
            InitializeComponent();
        }

        private void ToolStrip_HeThong_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            LoadMDI();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void LoadMDI()
        {
            changePassword.MdiParent = this;
            SvKt.MdiParent = this;
            kt.MdiParent = this;
            sv.MdiParent = this;
            tkSV.MdiParent = this;
            khoa.MdiParent = this;
            lop.MdiParent = this;
            baoCao.MdiParent = this;    
        }

        private void ToolStrip_HeThong_DoiMK_Click(object sender, EventArgs e)
        {
            changePassword.Show();
        }

        private void ToolStripMenuItemQuanLySV_Click(object sender, EventArgs e)
        {
            //studentManager.Show();
            sv.Show();
        }

        private void ToolStripMenuSVKT_Click(object sender, EventArgs e)
        {
            SvKt.Show();
        }

        private void ToolStripMenuKT_Click(object sender, EventArgs e)
        {
            kt.Show();
        }

        private void ToolStripTimKiemSV_Click(object sender, EventArgs e)
        {
            baoCao.Show();
        }

        private void ToolStripMenuItemSVKT_Click(object sender, EventArgs e)
        {
            tkSV.Show();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            khoa.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lop.Show();
        }
    }
}
