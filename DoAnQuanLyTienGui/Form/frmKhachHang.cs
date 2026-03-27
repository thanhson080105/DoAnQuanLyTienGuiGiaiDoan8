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
    public partial class frmKhachHang : System.Windows.Forms.Form
    {
        QLTGDbcontext context = new QLTGDbcontext();
        bool xulythem = false;
        int id;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnLamMoi.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

            txtMaKH.Enabled = giaTri;
            txtTenKH.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;


        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.AutoGenerateColumns = true;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ActiveControl = btnThem;
            BatTatChucNang(false);

            List<KhachHang> dsKH = context.KhachHang.ToList();
            BindingSource binding = new BindingSource();
            binding.DataSource = dsKH;

            dgvKhachHang.DataSource = binding;

            // Ẩn navigation property để không gây lỗi
            if (dgvKhachHang.Columns["SoTietKiems"] != null)
                dgvKhachHang.Columns["SoTietKiems"].Visible = false;

            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();

            txtMaKH.DataBindings.Add("Text", binding, "MaKH");
            txtTenKH.DataBindings.Add("Text", binding, "TenKH");
            txtSDT.DataBindings.Add("Text", binding, "SDT");
            txtDiaChi.DataBindings.Add("Text", binding, "DiaChi");
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            xulythem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["Id"].Value.ToString());
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xulythem)
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMaKH.Text;
                kh.TenKH = txtTenKH.Text;
                kh.SDT = txtSDT.Text;
                kh.DiaChi = txtDiaChi.Text;

                context.KhachHang.Add(kh);
                context.SaveChanges();
            }
            else
            {
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    kh.MaKH = txtMaKH.Text;
                    kh.TenKH = txtTenKH.Text;
                    kh.SDT = txtSDT.Text;
                    kh.DiaChi = txtDiaChi.Text;

                    context.KhachHang.Update(kh);
                    context.SaveChanges();
                }
            }

            frmKhachHang_Load(sender, e);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            xulythem = true;
            BatTatChucNang(true);

            // NGĂN BINDING GHI ĐÈ
            txtMaKH.DataBindings.Clear();
            txtTenKH.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();

            // XÓA DỮ LIỆU
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tên khách hàng?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["ID"].Value.ToString());
                KhachHang kh = context.KhachHang.Find(id);
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                }
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
            }
        }
    }
}
