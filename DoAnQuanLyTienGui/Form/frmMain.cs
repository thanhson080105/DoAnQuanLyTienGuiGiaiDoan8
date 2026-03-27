using DoAnQuanLyTienGui.Data;
using DoAnQuanLyTienGui.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace DoAnQuanLyTienGui.Form
{
    public partial class frmMain : System.Windows.Forms.Form
    {
        QLTGDbcontext context = new QLTGDbcontext(); // khai báo context để có thể truy cập dữ liệu từ các form con
        NhanVien currentUser;
        frmKhachHang khachhang = null;
        frmNhanVien nhanvien = null;
        frmSoTietKiem sotietkiem = null;
        frmGiaoDich giaodich = null;
        frmRutTien ruttien = null;
        frmGuiTien guitien = null;
        frmDangNhap dangnhap = null; // form đăng nhập để có thể gọi lại khi đăng xuất
        string hotennhanvien = ""; // lấy tên nhân viên để hiển thị ở form main 
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(NhanVien user)
        {
            InitializeComponent();
            currentUser = user;
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void mởSổTiếtKiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSoTietKiem stk = new frmSoTietKiem();
            stk.MdiParent = this;
            stk.Show();
        }

        private void giaoDịchTổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiaoDich gd = new frmGiaoDich();
            gd.MdiParent = this;
            gd.Show();
        }

        private void gửiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGuiTien gt = new frmGuiTien();
            gt.MdiParent = this;
            gt.Show();
        }

        private void rútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRutTien rt = new frmRutTien();
            rt.MdiParent = this;
            rt.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();
        }

        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        // xay dung ham dang nhap 
        private void DangNhap()
        {
        LamLai:
            dangnhap = new frmDangNhap(); // luôn tạo form mới để tránh lỗi khi đăng xuất và đăng nhập lại

            if (dangnhap == null || dangnhap.IsDisposed)
                dangnhap = new frmDangNhap();
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangnhap.txtTenDangNhap.Text;
                string matKhau = dangnhap.txtMatKhau.Text;
                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangnhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangnhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var nhanVien = context.NhanVien.Where(r => r.TenDangNhap == tenDangNhap).FirstOrDefault();
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangnhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (matKhau == nhanVien.MatKhau)
                        {
                            hotennhanvien = nhanVien.TenNV;
                            if (nhanVien.VaiTro == "Admin")
                                QuyenQuanLy();
                            else if (nhanVien.VaiTro == "NhanVien")
                                QuyenNhanVien();
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangnhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        public void ChuaDangNhap()
        {
            // Sáng đăng nhập
            đăngNhậpToolStripMenuItem.Enabled = true;
            // Mờ tất cả
            đăngXuấtToolStripMenuItem.Enabled = false;
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            mởSổTiếtKiệmToolStripMenuItem.Enabled = false;
            giaoDịchTổngHợpToolStripMenuItem.Enabled = false;
            gửiTiềnToolStripMenuItem.Enabled = false;
            rútTiềnToolStripMenuItem.Enabled = false;
            kháchHàngToolStripMenuItem.Enabled = false;
            nhânViênToolStripMenuItem.Enabled = false;
            // còn lại các form thông kê bổ sung sau 

            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        // Quyền quản lý
        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            đăngNhậpToolStripMenuItem.Enabled = false;
            // Sáng tất cả
            đăngXuấtToolStripMenuItem.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            mởSổTiếtKiệmToolStripMenuItem.Enabled = true;
            giaoDịchTổngHợpToolStripMenuItem.Enabled = true;
            gửiTiềnToolStripMenuItem.Enabled = true;
            rútTiềnToolStripMenuItem.Enabled = true;
            kháchHàngToolStripMenuItem.Enabled = true;
            nhânViênToolStripMenuItem.Enabled = true;
            // hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = $"Quản lý: {hotennhanvien}";
        }

        public void QuyenNhanVien()
        {
            // Mờ đăng nhập
            đăngNhậpToolStripMenuItem.Enabled = false;
            // Sáng một số chức năng
            đăngXuấtToolStripMenuItem.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            mởSổTiếtKiệmToolStripMenuItem.Enabled = true;
            giaoDịchTổngHợpToolStripMenuItem.Enabled = true;
            gửiTiềnToolStripMenuItem.Enabled = true;
            rútTiềnToolStripMenuItem.Enabled = true;
            kháchHàngToolStripMenuItem.Enabled = true;
            // Mờ chức năng quản lý nhân viên
            nhânViênToolStripMenuItem.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = $"Nhân viên: {hotennhanvien}";
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form child in this.MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thốngKêChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeChiTiet tk = new frmThongKeChiTiet();
            tk.MdiParent = this;
            tk.Show();
        }

        private void thốngKêNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeNhanVien nv = new frmThongKeNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void thốngKêKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeKhachHang kh = new frmThongKeKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }
    }
}

