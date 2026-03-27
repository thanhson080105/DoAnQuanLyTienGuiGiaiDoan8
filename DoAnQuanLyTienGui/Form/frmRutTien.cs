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
    public partial class frmRutTien : System.Windows.Forms.Form
    {
        public frmRutTien()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSo = txtMaSo.Text.Trim();

            if (string.IsNullOrEmpty(maSo))
            {
                MessageBox.Show("Vui lòng nhập mã sổ!");
                return;
            }

            using (var db = new QLTGDbcontext())
            {
                var stk = db.SoTietKiem.FirstOrDefault(x => x.MaSo == maSo);

                if (stk == null)
                {
                    MessageBox.Show("Không tìm thấy sổ tiết kiệm!");
                    return;
                }

                txtLaiSuat.Text = stk.LaiSuat.ToString();
                txtKyHan.Text = stk.KyHan.ToString();
                txtSoDu.Text = stk.SoTien.ToString("N0");
                dtpNgayGD.Value = DateTime.Now;

                txtLaiSuat.ReadOnly = true;
                txtKyHan.ReadOnly = true;
                txtSoDu.ReadOnly = true;

                txtSoTienRut.ReadOnly = false;

                cboNhanVien.DataSource = db.NhanVien.ToList();
                cboNhanVien.DisplayMember = "TenNV";
                cboNhanVien.ValueMember = "Id";
            }
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            string maSo = txtMaSo.Text.Trim();

            if (string.IsNullOrEmpty(maSo))
            {
                MessageBox.Show("Vui lòng nhập mã sổ!");
                return;
            }

            if (!decimal.TryParse(txtSoTienRut.Text.Replace(",", ""), out decimal soTienRut))
            {
                MessageBox.Show("Số tiền rút không hợp lệ!");
                return;
            }

            using (var db = new QLTGDbcontext())
            {
                // ✔ tìm theo MaSo giống btnTimKiem
                var stk = db.SoTietKiem.FirstOrDefault(x => x.MaSo == maSo);

                if (stk == null)
                {
                    MessageBox.Show("Không tìm thấy sổ tiết kiệm!");
                    return;
                }

                if (soTienRut <= 0)
                {
                    MessageBox.Show("Số tiền rút phải lớn hơn 0!");
                    return;
                }

                if (soTienRut > stk.SoTien)
                {
                    MessageBox.Show("Số dư không đủ để rút!");
                    return;
                }

                // ✔ trừ tiền
                stk.SoTien -= soTienRut;

                db.Entry(stk).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                // ✔ lấy loại giao dịch Rút
                var loaiGD = db.LoaiGiaoDich.FirstOrDefault(x => x.TenLoai == "Rút");

                if (loaiGD == null)
                {
                    MessageBox.Show("Không tìm thấy loại giao dịch 'Rút'!");
                    return;
                }

                // ✔ tạo mã giao dịch tự động
                var lastGD = db.GiaoDich
                    .OrderByDescending(x => x.Id)
                    .FirstOrDefault();

                int nextNumber = 1;

                if (lastGD != null && int.TryParse(lastGD.MaGD, out int lastNumber))
                {
                    nextNumber = lastNumber + 1;
                }

                string newMaGD = nextNumber.ToString("D3");

                // ✔ tạo giao dịch
                GiaoDich gd = new GiaoDich
                {
                    MaGD = newMaGD,
                    NgayGD = dtpNgayGD.Value,
                    SoTien = soTienRut,
                    SoTietKiemId = stk.Id,
                    LoaiGiaoDichId = loaiGD.Id,
                    NhanVienId = (int)cboNhanVien.SelectedValue
                };

                db.GiaoDich.Add(gd);

                db.SaveChanges();
                // làm mới số tiền rút để tránh rút tiếp mà không tìm kiếm lại
                txtSoTienRut.Clear();


                // ✔ cập nhật lại form sổ tiết kiệm
                var frm = Application.OpenForms["frmSoTietKiem"] as frmSoTietKiem;
                if (frm != null)
                {
                    frm.LoadSoTietKiem();
                }

                // ✔ cập nhật số dư trên form
                txtSoDu.Text = stk.SoTien.ToString("N0");

                MessageBox.Show("Rút tiền thành công!\nSố dư còn lại: "
                                + stk.SoTien.ToString("N0") + " VND");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Tự động định dạng số tiền khi nhập
        private void txtSoTienRut_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienRut.Text == "")
                return;

            string s = txtSoTienRut.Text.Replace(",", "").Replace(".", "");

            if (decimal.TryParse(s, out decimal value))
            {
                txtSoTienRut.Text = string.Format("{0:N0}", value);
                txtSoTienRut.SelectionStart = txtSoTienRut.Text.Length;
            }
        }
        // Chỉ cho phép nhập số 
        private void txtSoTienRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // Làm mờ các thông tin sau khi tìm kiếm để tránh chỉnh sửa
        private void SetThongTinReadOnly()
        {
            txtLaiSuat.ReadOnly = true;
            txtKyHan.ReadOnly = true;
            txtSoDu.ReadOnly = true;
            dtpNgayGD.Enabled = false;

            txtLaiSuat.BackColor = Color.White;
            txtKyHan.BackColor = Color.White;
            txtSoDu.BackColor = Color.White;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSo.Clear();
            txtLaiSuat.Clear();
            txtKyHan.Clear();
            txtSoDu.Clear();
            txtSoTienRut.Clear();

            txtLaiSuat.ReadOnly = true;
            txtKyHan.ReadOnly = true;
            txtSoDu.ReadOnly = true;
            txtSoTienRut.ReadOnly = true;

            cboNhanVien.DataSource = null;
        }
    }
}
