using DoAnQuanLyTienGui.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyTienGui.Form
{
    public partial class frmDangNhap : System.Windows.Forms.Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            /*
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text.Trim();

            using (var db = new QLTGDbcontext())
            {
                var user = db.NhanVien
                    .FirstOrDefault(x => x.TenDangNhap == username && x.MatKhau == password);

                if (user != null)
                {
                    frmMain main = new frmMain(user); // truyền user
                    main.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }*/
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}

