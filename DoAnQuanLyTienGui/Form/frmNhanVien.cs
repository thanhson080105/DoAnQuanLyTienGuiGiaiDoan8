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
    public partial class frmNhanVien : System.Windows.Forms.Form
    {
        QLTGDbcontext context = new QLTGDbcontext();
        bool xulythem = false;
        int id;
        public frmNhanVien()
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

            txtMaNV.Enabled = giaTri;
            txtTenNV.Enabled = giaTri;
            txtSDT.Enabled = giaTri;
            txtChucVu.Enabled = giaTri;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.AutoGenerateColumns = true;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.AllowUserToAddRows = false;
            this.ActiveControl = btnThem;

            BatTatChucNang(false);

            List<NhanVien> dsNV = context.NhanVien.ToList();
            BindingSource binding = new BindingSource();
            binding.DataSource = dsNV;

            dgvNhanVien.DataSource = binding;

            // Ẩn navigation property GiaoDich
            if (dgvNhanVien.Columns["GiaoDich"] != null)
                dgvNhanVien.Columns["GiaoDich"].Visible = false;

            // Xóa binding cũ
            txtMaNV.DataBindings.Clear();
            txtTenNV.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();

            // Tạo binding đúng tên thuộc tính
            txtMaNV.DataBindings.Add("Text", binding, "MaNV");
            txtTenNV.DataBindings.Add("Text", binding, "TenNV");
            txtSDT.DataBindings.Add("Text", binding, "SDT");
            txtChucVu.DataBindings.Add("Text", binding, "ChucVu");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulythem = true;
            BatTatChucNang(true);

            // NGĂN BINDING GHI ĐÈ
            txtMaNV.DataBindings.Clear();
            txtTenNV.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtChucVu.DataBindings.Clear();

            // XÓA DỮ LIỆU
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtChucVu.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulythem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa tên nhân viên?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["ID"].Value.ToString());
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                }
                context.SaveChanges();
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xulythem)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = txtMaNV.Text;
                nv.TenNV = txtTenNV.Text;
                nv.SDT = txtSDT.Text;
                nv.ChucVu = txtChucVu.Text;

                context.NhanVien.Add(nv);
                context.SaveChanges();
            }
            else
            {
                NhanVien nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    nv.MaNV = txtMaNV.Text;
                    nv.TenNV = txtTenNV.Text;
                    nv.SDT = txtSDT.Text;
                    nv.ChucVu = txtChucVu.Text;

                    context.NhanVien.Update(nv);
                    context.SaveChanges();
                }
            }

            frmNhanVien_Load(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDT.Clear();
            txtChucVu.Clear();
        }
    }
}



        

