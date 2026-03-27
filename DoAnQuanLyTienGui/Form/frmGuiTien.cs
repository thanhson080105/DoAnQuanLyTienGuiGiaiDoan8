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
    public partial class frmGuiTien : System.Windows.Forms.Form
    {
        public frmGuiTien()
        {
            InitializeComponent();
        }
        // TỰ ĐỘNG TẠO MÃ GIAO DỊCH DẠNG 001, 002, 003...
        private string GenerateMaGD()
        {
            using (var db = new QLTGDbcontext())
            {
                int lastId = db.GiaoDich
                    .OrderByDescending(g => g.Id)
                    .Select(g => g.Id)
                    .FirstOrDefault();

                return (lastId + 1).ToString("D3");   // 001, 002, 003...
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var db = new QLTGDbcontext())
            {
                var stk = db.SoTietKiem.FirstOrDefault(x => x.MaSo == txtMaSo.Text.Trim());
                if (stk == null)
                {
                    MessageBox.Show("Mã sổ không tồn tại!");
                    return;
                }

                string st = txtSoTienGui.Text.Replace(".", "").Replace(",", "");
                if (!decimal.TryParse(st, out decimal soTienGui) || soTienGui <= 0)
                {
                    MessageBox.Show("Số tiền gửi không hợp lệ!");
                    return;
                }

                if (cboNhanVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên!");
                    return;
                }

                int nvId = (int)cboNhanVien.SelectedValue;

                // ⭐ CẬP NHẬT SỐ DƯ TRONG SỔ TIẾT KIỆM
                stk.SoTien += soTienGui;
                db.SaveChanges();


                // ⭐ LƯU GIAO DỊCH
                GiaoDich gd = new GiaoDich
                {
                    MaGD = GenerateMaGD(),
                    SoTietKiemId = stk.Id,
                    SoTien = soTienGui,
                    NgayGD = dtpNgayGD.Value,
                    LoaiGiaoDichId = 1,
                    NhanVienId = nvId
                };

                db.GiaoDich.Add(gd);
                db.SaveChanges();

                MessageBox.Show("Gửi tiền thành công!");

                // ⭐ TẢI LẠI SỐ DƯ ĐÃ CẬP NHẬT
                txtMaSo_Leave(null, null);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSo.Clear();
            txtSoTienGui.Clear();
            txtLaiSuat.Clear();
            txtKyHan.Clear();
            txtSoDu.Clear();
            cboNhanVien.SelectedIndex = -1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGuiTien_Load(object sender, EventArgs e)
        {
            using (var db = new QLTGDbcontext())
            {
                cboNhanVien.DataSource = db.NhanVien.ToList();
                cboNhanVien.DisplayMember = "TenNV";
                cboNhanVien.ValueMember = "Id";
                cboNhanVien.SelectedIndex = -1;
            }
        }
        private void txtMaSo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSo.Text))
                return;

            using (var db = new QLTGDbcontext())
            {
                string ma = txtMaSo.Text.Trim();

                var stk = db.SoTietKiem.FirstOrDefault(x => x.MaSo == ma);

                if (stk != null)
                {
                    txtLaiSuat.Text = stk.LaiSuat + "%";
                    txtKyHan.Text = stk.KyHan + " tháng";
                    txtSoDu.Text = stk.SoTien.ToString("N0");   // ⭐ HIỂN THỊ SỐ DƯ
                }
                else
                {
                    txtLaiSuat.Clear();
                    txtKyHan.Clear();
                    txtSoDu.Clear();
                }
            }
        }
        // format số tiền khi nhập
        private void txtSoTienGui_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTienGui.Text == "")
                return;

            // Lấy vị trí con trỏ
            int selectionStart = txtSoTienGui.SelectionStart;

            // Bỏ format cũ
            string text = txtSoTienGui.Text.Replace(",", "");

            // Chỉ cho phép số
            if (!decimal.TryParse(text, out decimal value))
                return;

            // Format lại
            txtSoTienGui.Text = value.ToString("N0");

            // Đặt lại con trỏ cuối text
            txtSoTienGui.SelectionStart = txtSoTienGui.Text.Length;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
