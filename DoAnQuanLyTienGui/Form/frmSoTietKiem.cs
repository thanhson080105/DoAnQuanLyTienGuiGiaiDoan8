using ClosedXML.Excel;
using DoAnQuanLyTienGui.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmSoTietKiem : System.Windows.Forms.Form
    {
        QLTGDbcontext context = new QLTGDbcontext();
        bool xulythem = false;
        int id;
        System.Windows.Forms.Form formTruoc;


        public frmSoTietKiem(System.Windows.Forms.Form f)
        {
            InitializeComponent();
            formTruoc = f;
        }
        public frmSoTietKiem()
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

            txtMaSo.Enabled = giaTri;
            txtSoTien.Enabled = giaTri;
            txtKyHan.Enabled = giaTri;
            txtLaiSuat.Enabled = giaTri;
            dtpNgayMo.Enabled = giaTri;
            cboKhachHang.Enabled = giaTri;
        }
        private void LoadComboboxKhachHang()
        {
            var dsKH = context.KhachHang
                              .Select(k => new { k.Id, k.TenKH })
                              .ToList();

            cboKhachHang.DataSource = dsKH;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "Id";
        }

        public void LoadSoTietKiem()
        {
            // 1. Lấy dữ liệu bao gồm cả tên khách hàng để hiển thị
            var dsSTK = context.SoTietKiem
                        .Include(x => x.KhachHang)
                        .Select(x => new
                        {
                            x.Id,
                            x.MaSo,
                            x.SoTien,
                            x.LaiSuat,
                            x.KyHan,
                            x.NgayMoSo,
                            TenKhachHang = x.KhachHang.TenKH, // Lấy tên KH để hiện ra lưới
                            // tính tiền lãi dự kiến 
                            TienLaiDuKien = x.SoTien * (x.LaiSuat / 100) * (x.KyHan / 12m),
                            x.KhachHangId
                        })
                        .OrderByDescending(x => x.Id)
                        .ToList();

            BindingSource binding = new BindingSource();
            binding.DataSource = dsSTK;
            dgvSoTietKiem.DataSource = binding;

            // 2. FORMAT BẢNG ĐỒNG BỘ VỚI FORM GIAO DỊCH
            dgvSoTietKiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSoTietKiem.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSoTietKiem.ColumnHeadersHeight = 35;

            // Đổi tên Header và căn chỉnh
            if (dgvSoTietKiem.Columns.Contains("Id"))
            {
                dgvSoTietKiem.Columns["Id"].HeaderText = "STT";
                dgvSoTietKiem.Columns["Id"].FillWeight = 35;
                dgvSoTietKiem.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvSoTietKiem.Columns.Contains("MaSo"))
            {
                dgvSoTietKiem.Columns["MaSo"].HeaderText = "Mã sổ";
                dgvSoTietKiem.Columns["MaSo"].FillWeight = 80;
                dgvSoTietKiem.Columns["MaSo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvSoTietKiem.Columns.Contains("SoTien"))
            {
                dgvSoTietKiem.Columns["SoTien"].HeaderText = "Tiền gốc";
                dgvSoTietKiem.Columns["SoTien"].DefaultCellStyle.Format = "N0"; // Format 10,000,000
                dgvSoTietKiem.Columns["SoTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvSoTietKiem.Columns.Contains("LaiSuat"))
            {
                dgvSoTietKiem.Columns["LaiSuat"].HeaderText = "Lãi suất";
                dgvSoTietKiem.Columns["LaiSuat"].DefaultCellStyle.Format = "#,##0.00'%'"; // Thêm %
                dgvSoTietKiem.Columns["LaiSuat"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvSoTietKiem.Columns.Contains("KyHan"))
            {
                dgvSoTietKiem.Columns["KyHan"].HeaderText = "Kỳ hạn";
                dgvSoTietKiem.Columns["KyHan"].DefaultCellStyle.Format = "#,##0' tháng'"; // Thêm chữ tháng
                dgvSoTietKiem.Columns["KyHan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvSoTietKiem.Columns.Contains("NgayMoSo"))
            {
                dgvSoTietKiem.Columns["NgayMoSo"].HeaderText = "Ngày mở sổ";
                dgvSoTietKiem.Columns["NgayMoSo"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvSoTietKiem.Columns.Contains("TenKhachHang"))
            {
                dgvSoTietKiem.Columns["TenKhachHang"].HeaderText = "Khách hàng";
                dgvSoTietKiem.Columns["TenKhachHang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (dgvSoTietKiem.Columns.Contains("TienLaiDuKien"))
            {
                dgvSoTietKiem.Columns["TienLaiDuKien"].HeaderText = "Lãi dự kiến";
                dgvSoTietKiem.Columns["TienLaiDuKien"].DefaultCellStyle.Format = "N0"; // Hiện 1,000,000
                dgvSoTietKiem.Columns["TienLaiDuKien"].DefaultCellStyle.ForeColor = Color.Black;
                dgvSoTietKiem.Columns["TienLaiDuKien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Ẩn cột ID khách hàng
            if (dgvSoTietKiem.Columns.Contains("KhachHangId"))
                dgvSoTietKiem.Columns["KhachHangId"].Visible = false;

            // 3. THIẾT LẬP BINDING (GIỮ NGUYÊN LOGIC CỦA BẠN)
            txtMaSo.DataBindings.Clear();
            txtTienLai.DataBindings.Clear();
            txtSoTien.DataBindings.Clear();
            txtKyHan.DataBindings.Clear();
            txtLaiSuat.DataBindings.Clear();
            dtpNgayMo.DataBindings.Clear();
            cboKhachHang.DataBindings.Clear();

            txtMaSo.DataBindings.Add("Text", binding, "MaSo");
            txtSoTien.DataBindings.Add("Text", binding, "SoTien");
            txtKyHan.DataBindings.Add("Text", binding, "KyHan");
            txtLaiSuat.DataBindings.Add("Text", binding, "LaiSuat");
            txtTienLai.DataBindings.Add("Text", binding, "TienLaiDuKien", true, DataSourceUpdateMode.Never, "", "N0");
            dtpNgayMo.DataBindings.Add("Value", binding, "NgayMoSo");
            cboKhachHang.DataBindings.Add("SelectedValue", binding, "KhachHangId", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        // tính lãi nhanh khi nhập 
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
        private void frmSoTietKiem_Load(object sender, EventArgs e)
        {

            dgvSoTietKiem.AutoGenerateColumns = true;
            this.ActiveControl = btnThem;
            BatTatChucNang(false);

            // Load dữ liệu
            LoadComboboxKhachHang();
            LoadSoTietKiem(); // Gọi hàm load đã được tối ưu bên dưới
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulythem = true;
            BatTatChucNang(true);

            txtMaSo.DataBindings.Clear();
            txtSoTien.DataBindings.Clear();
            txtKyHan.DataBindings.Clear();
            txtLaiSuat.DataBindings.Clear();
            dtpNgayMo.DataBindings.Clear();
            cboKhachHang.DataBindings.Clear();

            txtMaSo.Clear();
            txtSoTien.Clear();
            txtKyHan.Clear();
            txtLaiSuat.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulythem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvSoTietKiem.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sổ tiết kiệm này?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvSoTietKiem.CurrentRow.Cells["Id"].Value.ToString());
                var stk = context.SoTietKiem.Find(id);
                if (stk != null)
                {
                    context.SoTietKiem.Remove(stk);
                    context.SaveChanges();
                }

                frmSoTietKiem_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSo.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sổ!", "Lỗi");
                return;
            }

            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Lỗi");
                return;
            }

            int khId = (int)cboKhachHang.SelectedValue;

            if (xulythem)
            {
                // kiểm tra trùng mã sổ
                var trungMa = context.SoTietKiem
                                     .FirstOrDefault(x => x.MaSo == txtMaSo.Text);

                if (trungMa != null)
                {
                    MessageBox.Show("Mã sổ đã tồn tại!");
                    return;
                }

                var stkiem = new SoTietKiem
                {
                    MaSo = txtMaSo.Text,
                    SoTien = decimal.Parse(txtSoTien.Text),
                    KyHan = int.Parse(txtKyHan.Text),
                    LaiSuat = decimal.Parse(txtLaiSuat.Text),
                    NgayMoSo = dtpNgayMo.Value,
                    KhachHangId = khId
                };

                context.SoTietKiem.Add(stkiem);
            }
            else
            {
                var stkiem = context.SoTietKiem.Find(id);

                if (stkiem == null)
                {
                    MessageBox.Show("Không tìm thấy sổ tiết kiệm!");
                    return;
                }

                stkiem.MaSo = txtMaSo.Text;
                stkiem.SoTien = decimal.Parse(txtSoTien.Text);
                stkiem.KyHan = int.Parse(txtKyHan.Text);
                stkiem.LaiSuat = decimal.Parse(txtLaiSuat.Text);
                stkiem.NgayMoSo = dtpNgayMo.Value;
                stkiem.KhachHangId = khId;
            }

            context.SaveChanges();

            MessageBox.Show("Lưu thành công!");

            frmSoTietKiem_Load(sender, e);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtKyHan.Text = "";
            txtLaiSuat.Text = "";
            txtSoTien.Text = "";
            txtMaSo.Text = "";
            txtSoTien.Text = "";
            dtpNgayMo.Value = DateTime.Now;
            cboKhachHang.SelectedIndex = 0;
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
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
            TinhLaiNhanh();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = $"1:{row.LastCellUsed().Address.ColumnNumber}";
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Columns.Add(cell.Value.ToString());
                                }
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;

                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                    }

                    if (table.Rows.Count > 0)
                    {
                        foreach (DataRow r in table.Rows)
                        {
                            SoTietKiem stk = new SoTietKiem();

                            stk.MaSo = r["MaSo"].ToString();
                            stk.NgayMoSo = DateTime.Now;
                            stk.SoTien = decimal.Parse(r["SoTien"].ToString());
                            stk.LaiSuat = decimal.Parse(r["LaiSuat"].ToString());
                            stk.KyHan = int.Parse(r["KyHan"].ToString());
                            stk.KhachHangId = 1; // Gán tạm khách hàng mặc định (có thể sửa sau)

                            context.SoTietKiem.Add(stk);
                        }

                        context.SaveChanges();

                        MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.",
                                        "Thành công",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        frmSoTietKiem_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Tập tin Excel rỗng.",
                                        "Lỗi",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Lỗi",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "SoTietKiem_" +
                DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[4] {
                new DataColumn("MaSo", typeof(string)),
                new DataColumn("SoTien", typeof(decimal)),
                new DataColumn("LaiSuat", typeof(decimal)),
                new DataColumn("KyHan", typeof(int))
            });

                    var soTietKiem = context.SoTietKiem.ToList();

                    if (soTietKiem != null)
                    {
                        foreach (var s in soTietKiem)
                        {
                            table.Rows.Add(s.MaSo, s.SoTien, s.LaiSuat, s.KyHan);
                        }
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "SoTietKiem");

                        sheet.Columns().AdjustToContents();

                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
