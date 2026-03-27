using ClosedXML.Excel;
using DoAnQuanLyTienGui.Data;
using DoAnQuanLyTienGui.Reports;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmGiaoDich : System.Windows.Forms.Form
    {
        QLTGDbcontext context = new QLTGDbcontext();
        bool xulythem = false;
        int id;
        public frmGiaoDich()
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

            txtMaGD.Enabled = giaTri;
            txtSoTien.Enabled = giaTri;
            dtpNgayGD.Enabled = giaTri;
            txtTienLai.Enabled = giaTri;
            txtKyHan.Enabled = giaTri;
            txtLaiSuat.Enabled = giaTri;

            cboLoaiGD.Enabled = giaTri;
            cboNhanVien.Enabled = giaTri;
            txtMaSo.Enabled = giaTri;
        }
        private void LoadComboboxNhanVien()
        {
            var dsNV = context.NhanVien
                              .Select(n => new { n.Id, n.TenNV })
                              .ToList();

            cboNhanVien.DataSource = dsNV;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "Id";

            if (dsNV.Count > 0)
                cboNhanVien.SelectedIndex = 0;
        }
        private void LoadLoaiGiaoDich()
        {
            var loaiGD = context.LoaiGiaoDich
                                .Select(l => new
                                {
                                    l.Id,
                                    l.TenLoai
                                })
                                .ToList();

            cboLoaiGD.DataSource = loaiGD;
            cboLoaiGD.DisplayMember = "TenLoai";
            cboLoaiGD.ValueMember = "Id";

            if (loaiGD.Count > 0)
                cboLoaiGD.SelectedIndex = 0;
        }
        // thông tin chung hiển thị 
        private void HienThiDuLieu()
        {
            dgvGiaoDich.Columns.Clear();
            // Lấy dữ liệu mới nhất từ Context
            var data = context.GiaoDich
                .Select(g => new
                {
                    g.Id,
                    g.MaGD,
                    g.NgayGD,
                    g.SoTien,
                    MaSo = g.SoTietKiem.MaSo,
                    KyHan = g.SoTietKiem.KyHan,
                    LaiSuat = g.SoTietKiem.LaiSuat,
                    // Tính tiền lãi dự kiến
                    TienLaiDuKien = g.SoTien * (g.SoTietKiem.LaiSuat / 100) * ((decimal)g.SoTietKiem.KyHan / 12),
                    LoaiGiaoDich = g.LoaiGiaoDich.TenLoai,
                    NhanVien = g.NhanVien.TenNV
                })
                .OrderByDescending(x => x.Id) // Hiện giao dịch mới nhất lên đầu
                .ToList();

            dgvGiaoDich.DataSource = data;

            // 1. Tự động giãn các cột để lấp đầy chiều ngang bảng
            dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (dgvGiaoDich.Columns.Contains("NhanVien"))
            {
                dgvGiaoDich.Columns["NhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // 2. Đặt tên tiếng Việt và căn chỉnh từng cột
            if (dgvGiaoDich.Columns.Contains("Id"))
            {
                dgvGiaoDich.Columns["Id"].HeaderText = "STT";
                dgvGiaoDich.Columns["Id"].FillWeight = 40; // Cột này nhỏ thôi
                dgvGiaoDich.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvGiaoDich.Columns.Contains("MaGD"))
            {
                dgvGiaoDich.Columns["MaGD"].HeaderText = "Mã GD";
                dgvGiaoDich.Columns["MaGD"].FillWeight = 90;
                dgvGiaoDich.Columns["MaGD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvGiaoDich.Columns.Contains("NgayGD"))
            {
                dgvGiaoDich.Columns["NgayGD"].HeaderText = "Ngày GD";
                dgvGiaoDich.Columns["NgayGD"].FillWeight = 110;
                dgvGiaoDich.Columns["NgayGD"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvGiaoDich.Columns.Contains("SoTien"))
            {
                dgvGiaoDich.Columns["SoTien"].HeaderText = "Tiền gốc";
                dgvGiaoDich.Columns["SoTien"].DefaultCellStyle.Format = "N0"; // Phân cách hàng nghìn
                dgvGiaoDich.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvGiaoDich.Columns.Contains("MaSo"))
            {
                dgvGiaoDich.Columns["MaSo"].HeaderText = "Mã sổ";
                dgvGiaoDich.Columns["MaSo"].FillWeight = 80;
                dgvGiaoDich.Columns["MaSo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            if (dgvGiaoDich.Columns.Contains("LoaiGiaoDich"))
            {
                dgvGiaoDich.Columns["LoaiGiaoDich"].HeaderText = "Loại GD";
                dgvGiaoDich.Columns["LoaiGiaoDich"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            if (dgvGiaoDich.Columns.Contains("NhanVien"))
            {
                dgvGiaoDich.Columns["NhanVien"].HeaderText = "Nhân viên";
            }


            if (dgvGiaoDich.Columns.Contains("KyHan"))
            {
                dgvGiaoDich.Columns["KyHan"].HeaderText = "Kỳ hạn";
                dgvGiaoDich.Columns["KyHan"].DefaultCellStyle.Format = "#,##0' tháng'"; //
                dgvGiaoDich.Columns["KyHan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvGiaoDich.Columns.Contains("LaiSuat"))
            {
                dgvGiaoDich.Columns["LaiSuat"].HeaderText = "Lãi suất";
                dgvGiaoDich.Columns["LaiSuat"].DefaultCellStyle.Format = "#,##0.00'%'"; //
                dgvGiaoDich.Columns["LaiSuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvGiaoDich.Columns.Contains("TienLaiDuKien"))
            {
                dgvGiaoDich.Columns["TienLaiDuKien"].HeaderText = "Tiền lãi";
                dgvGiaoDich.Columns["TienLaiDuKien"].DefaultCellStyle.Format = "N0";
                dgvGiaoDich.Columns["TienLaiDuKien"].DefaultCellStyle.ForeColor = Color.Black; // Cho tiền lãi hiện màu đỏ cho nổi bật
                dgvGiaoDich.Columns["TienLaiDuKien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


            // Làm sạch và Bind lại dữ liệu lên TextBox
            txtMaGD.DataBindings.Clear();
            txtSoTien.DataBindings.Clear();
            txtTienLai.DataBindings.Clear();
            dtpNgayGD.DataBindings.Clear();
            cboLoaiGD.DataBindings.Clear();
            txtMaSo.DataBindings.Clear();
            cboNhanVien.DataBindings.Clear();

            if (data.Count > 0)
            {
                txtMaGD.DataBindings.Add("Text", data, "MaGD");
                txtSoTien.DataBindings.Add("Text", data, "SoTien");
                txtTienLai.DataBindings.Add("Text", data, "TienLaiDuKien", true, DataSourceUpdateMode.OnPropertyChanged, "0", "N0");
                dtpNgayGD.DataBindings.Add("Value", data, "NgayGD");
                cboLoaiGD.DataBindings.Add("Text", data, "LoaiGiaoDich");
                cboNhanVien.DataBindings.Add("Text", data, "NhanVien");
            }
        }

        // hàm tự động tính lãi khi nhập
        private void TinhLaiNhanh()
        {
            try
            {
                // Lấy dữ liệu từ các ô nhập
                decimal soTien = 0;
                if (!decimal.TryParse(txtSoTien.Text.Replace(",", ""), out soTien)) return;

                decimal laiSuat = 0;
                decimal.TryParse(txtLaiSuat.Text, out laiSuat);

                int kyHan = 0;
                int.TryParse(txtKyHan.Text, out kyHan);

                // Tính toán
                decimal lai = soTien * (laiSuat / 100) * (kyHan / 12m);

                // Hiển thị lên txtTienLai
                txtTienLai.Text = lai.ToString("N0");
            }
            catch
            {
                txtTienLai.Text = "0";
            }
        }
        private void frmGiaoDich_Load(object sender, EventArgs e)
        {
            LoadLoaiGiaoDich();  // Đổ Gửi – Rút vào ComboBox
            LoadComboboxNhanVien(); // Đổ danh sách nhân viên vào ComboBox
            dgvGiaoDich.AutoGenerateColumns = true;
            dgvGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ActiveControl = btnThem;
            BatTatChucNang(false);

            HienThiDuLieu(); // Gọi hàm hiển thị ở đây

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            xulythem = true;
            BatTatChucNang(true);


            LoadLoaiGiaoDich();

            // Chỉ clear DataBindings, KHÔNG đụng tới DataSource
            txtMaGD.DataBindings.Clear();
            txtSoTien.DataBindings.Clear();
            dtpNgayGD.DataBindings.Clear();
            cboNhanVien.DataBindings.Clear();

            // Reset dữ liệu nhập
            txtMaGD.Clear();
            txtSoTien.Clear();
            dtpNgayGD.Value = DateTime.Now;

            // Set combobox mặc định
            if (cboLoaiGD.Items.Count > 0)
                cboLoaiGD.SelectedIndex = 0;

            if (cboNhanVien.Items.Count > 0)
                cboNhanVien.SelectedIndex = 0;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvGiaoDich.CurrentRow == null)
                return;

            xulythem = false;
            BatTatChucNang(true);
            txtMaGD.Enabled = false; // Mã giao dịch không được sửa
            // Lấy dòng hiện tại
            var row = dgvGiaoDich.CurrentRow;
            // Lấy ID giao dịch đang chọn
            id = Convert.ToInt32(dgvGiaoDich.CurrentRow.Cells["Id"].Value);
            txtMaSo.Text = row.Cells["MaSo"].Value?.ToString();
            txtKyHan.Text = row.Cells["KyHan"].Value?.ToString();
            txtLaiSuat.Text = row.Cells["LaiSuat"].Value?.ToString();
        }

        private void dgvGiaoDich_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgvGiaoDich.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvGiaoDich.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn giao dịch cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa giao dịch này?",
                                "Xác nhận",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                // ⭐ Lấy ID giao dịch từ DGV
                int id = Convert.ToInt32(dgvGiaoDich.CurrentRow.Cells["Id"].Value);

                using (var db = new QLTGDbcontext())
                {
                    // ⭐ Lấy giao dịch
                    var gd = db.GiaoDich.FirstOrDefault(g => g.Id == id);
                    if (gd == null)
                    {
                        MessageBox.Show("Không tìm thấy giao dịch!");
                        return;
                    }

                    // ⭐ Lấy sổ tiết kiệm tương ứng
                    var stk = db.SoTietKiem.FirstOrDefault(s => s.Id == gd.SoTietKiemId);
                    if (stk == null)
                    {
                        MessageBox.Show("Không tìm thấy sổ tiết kiệm!");
                        return;
                    }

                    // ⭐ Trừ số dư
                    stk.SoTien -= gd.SoTien;

                    // ⭐ Xóa giao dịch
                    db.GiaoDich.Remove(gd);

                    // ⭐ Lưu thay đổi
                    db.SaveChanges();
                }

                MessageBox.Show("Xóa giao dịch thành công! Số dư đã được cập nhật.");

                frmGiaoDich_Load(sender, e); // Reload DGV

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGD.Clear();
            txtSoTien.Clear();
            txtMaSo.Clear();
            txtTienLai.Clear();
            dtpNgayGD.Value = DateTime.Now;
            cboLoaiGD.SelectedIndex = 0;
            cboNhanVien.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra các trường bắt buộc
                if (string.IsNullOrWhiteSpace(txtMaSo.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sổ!", "Thông báo");
                    return;
                }

                // 2. Lấy dữ liệu từ giao diện
                decimal soTienNhap = decimal.Parse(txtSoTien.Text.Replace(",", ""));
                int loaiGDId = (int)cboLoaiGD.SelectedValue;
                int nvId = (int)cboNhanVien.SelectedValue;

                // Lấy Lãi suất và Kỳ hạn từ TextBox mới thêm (Giả sử tên là txtLaiSuat và txtKyHan)
                // Nếu để trống thì mặc định là 0
                decimal laiSuat = 0;
                int kyHan = 0;
                decimal.TryParse(txtLaiSuat.Text, out laiSuat);
                int.TryParse(txtKyHan.Text, out kyHan);

                // 3. Tìm hoặc Tạo mới Sổ tiết kiệm
                var so = context.SoTietKiem.FirstOrDefault(x => x.MaSo == txtMaSo.Text.Trim());

                if (so == null)
                {
                    // Nếu chưa có sổ, Admin tạo mới luôn với thông tin Kỳ hạn/Lãi suất đã nhập
                    so = new SoTietKiem
                    {
                        MaSo = txtMaSo.Text.Trim(),
                        SoTien = 0, // Sẽ được cộng dồn ở phần Giao dịch bên dưới
                        NgayMoSo = DateTime.Now,
                        LaiSuat = laiSuat,   // Gán giá trị Admin nhập
                        KyHan = kyHan,       // Gán giá trị Admin nhập
                        KhachHangId = 1      // Bạn có thể thêm ComboBox chọn khách hàng nếu cần
                    };
                    context.SoTietKiem.Add(so);
                    context.SaveChanges(); // Lưu để lấy ID cho Giao dịch
                }

                // 4. Xử lý Giao dịch
                if (xulythem)
                {
                    // Kiểm tra xem MaGD đã tồn tại trong Database chưa
                    var checkMaGD = context.GiaoDich.Any(g => g.MaGD == txtMaGD.Text.Trim());
                    if (checkMaGD)
                    {
                        MessageBox.Show("Mã giao dịch này đã tồn tại! Vui lòng nhập mã khác.", "Lỗi trùng mã");
                        return; // Thoát hàm, không cho lưu
                    }
                    // Kiểm tra điều kiện rút tiền
                    if (loaiGDId == 2 && so.SoTien < soTienNhap)
                    {
                        MessageBox.Show("Số dư hiện tại (" + so.SoTien.ToString("N0") + ") không đủ để rút!");
                        return;
                    }

                    var gd = new GiaoDich
                    {
                        MaGD = txtMaGD.Text.Trim(),
                        NgayGD = dtpNgayGD.Value,
                        SoTien = soTienNhap,
                        SoTietKiemId = so.Id,
                        LoaiGiaoDichId = loaiGDId,
                        NhanVienId = nvId
                    };
                    context.GiaoDich.Add(gd);

                    // Cập nhật số dư vào sổ
                    if (loaiGDId == 1) so.SoTien += soTienNhap;
                    else so.SoTien -= soTienNhap;
                }
                else // Phần SỬA giao dịch
                {
                    var gdEdit = context.GiaoDich.Find(id);
                    if (gdEdit != null)
                    {
                        // 1. Hoàn lại số dư cũ
                        if (gdEdit.LoaiGiaoDichId == 1) so.SoTien -= gdEdit.SoTien;
                        else so.SoTien += gdEdit.SoTien;

                        // 2. Cập nhật thông tin giao dịch mới
                        gdEdit.SoTien = soTienNhap;
                        gdEdit.LoaiGiaoDichId = loaiGDId;
                        gdEdit.NhanVienId = nvId;
                        gdEdit.NgayGD = dtpNgayGD.Value;

                        // 3. Cập nhật trực tiếp Lãi suất và Kỳ hạn vào bảng SoTietKiem (QUAN TRỌNG)
                        decimal laiSuatMoi = 0;
                        int kyHanMoi = 0;
                        if (decimal.TryParse(txtLaiSuat.Text, out laiSuatMoi)) so.LaiSuat = laiSuatMoi;
                        if (int.TryParse(txtKyHan.Text, out kyHanMoi)) so.KyHan = kyHanMoi;

                        // 4. Áp dụng số dư mới
                        if (loaiGDId == 1) so.SoTien += soTienNhap;
                        else so.SoTien -= soTienNhap;
                    }
                }

                context.SaveChanges();
                // Tính toán nhanh để hiện thông báo
                decimal tLai = soTienNhap * (laiSuat / 100) * ((decimal)kyHan / 12);
                MessageBox.Show($"Lưu thành công!\nSố tiền lãi dự kiến của giao dịch này là: {tLai:N0} VND", "Thông tin tiền lãi");
                // GỌI HÀM NÀY ĐỂ CẬP NHẬT LƯỚI NGAY LẬP TỨC
                HienThiDuLieu();
                BatTatChucNang(false); // Tắt các ô nhập liệu sau khi lưu xong
                frmGiaoDich_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Nhập Excel";
            open.Filter = "Excel (*.xlsx)|*.xlsx";

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    using (XLWorkbook workbook = new XLWorkbook(open.FileName))
                    {
                        var sheet = workbook.Worksheet(1);
                        bool firstRow = true;

                        foreach (var row in sheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                foreach (var cell in row.Cells())
                                {
                                    table.Columns.Add(cell.Value.ToString());
                                }
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int i = 0;

                                foreach (var cell in row.Cells())
                                {
                                    table.Rows[table.Rows.Count - 1][i] = cell.Value.ToString();
                                    i++;
                                }
                            }
                        }
                    }

                    foreach (DataRow r in table.Rows)
                    {
                        GiaoDich gd = new GiaoDich();

                        gd.MaGD = r["MaGD"].ToString();
                        gd.NgayGD = DateTime.Parse(r["NgayGD"].ToString());
                        gd.SoTien = decimal.Parse(r["SoTien"].ToString());
                        gd.SoTietKiemId = int.Parse(r["SoTietKiemId"].ToString());
                        gd.LoaiGiaoDichId = int.Parse(r["LoaiGiaoDichId"].ToString());
                        gd.NhanVienId = int.Parse(r["NhanVienId"].ToString());

                        context.GiaoDich.Add(gd);
                    }

                    context.SaveChanges();

                    MessageBox.Show("Nhập thành công " + table.Rows.Count + " dòng");

                    frmGiaoDich_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Xuất Excel";
            save.Filter = "Excel (*.xlsx)|*.xlsx";
            save.FileName = "DanhSachGiaoDich.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("MaGD");
                    table.Columns.Add("NgayGD");
                    table.Columns.Add("SoTien");
                    table.Columns.Add("SoTietKiemId");
                    table.Columns.Add("LoaiGiaoDichId");
                    table.Columns.Add("NhanVienId");

                    var ds = context.GiaoDich.ToList();

                    foreach (var gd in ds)
                    {
                        table.Rows.Add(
                            gd.MaGD,
                            gd.NgayGD,
                            gd.SoTien,
                            gd.SoTietKiemId,
                            gd.LoaiGiaoDichId,
                            gd.NhanVienId
                        );
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "GiaoDich");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(save.FileName);
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            {
                if (txtSoTien.Text == "")
                    return;

                // Lấy vị trí con trỏ
                int selectionStart = txtSoTien.SelectionStart;

                // Bỏ format cũ
                string text = txtSoTien.Text.Replace(",", "");

                // Chỉ cho phép số
                if (!decimal.TryParse(text, out decimal value))
                    return;

                // Format lại
                txtSoTien.Text = value.ToString("N0");

                // Đặt lại con trỏ cuối text
                txtSoTien.SelectionStart = txtSoTien.Text.Length;
            }
            TinhLaiNhanh();
        }

        private void btnInGD_Click(object sender, EventArgs e)
        {
            // 🔹 Lấy Id giao dịch từ dòng đang chọn
            int id = Convert.ToInt32(dgvGiaoDich.CurrentRow.Cells["Id"].Value);

            using (frmInPhieuGiaoDich_ChiTiet inGiaoDich = new frmInPhieuGiaoDich_ChiTiet(id))
            {
                inGiaoDich.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn quay lại giao diện chính không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close(); // Đóng form Sổ tiết kiệm, Main Menu sẽ hiển thị rõ lại
            }
        }
    }
}
