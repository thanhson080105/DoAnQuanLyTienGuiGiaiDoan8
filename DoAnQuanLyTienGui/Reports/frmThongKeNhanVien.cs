using DoAnQuanLyTienGui.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAnQuanLyTienGui.Reports
{
    public partial class frmThongKeNhanVien : System.Windows.Forms.Form
    {
        QLTGDbcontext context = new QLTGDbcontext();

        QLTGDataSet.DanhSachNhanVienDataTable table =
            new QLTGDataSet.DanhSachNhanVienDataTable();

        public frmThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void frmThongKeNhanVien_Load(object sender, EventArgs e)
        {
            // ✅ setup giống form chuẩn
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 90;

            var data = context.NhanVien
                .Select(nv => new
                {
                    nv.Id,
                    nv.MaNV,
                    nv.TenNV,
                    nv.SDT,
                    nv.ChucVu,

                    SoGiaoDich = context.GiaoDich
                        .Count(gd => gd.NhanVien.Id == nv.Id),

                    TongTien = context.GiaoDich
                        .Where(gd => gd.NhanVien.Id == nv.Id)
                        .Sum(gd => (decimal?)gd.SoTien) ?? 0
                })
                .ToList();

            // 🔥 CLEAR
            table.Clear();

            // 🔥 ĐỔ DATA
            foreach (var r in data)
            {
                table.AddDanhSachNhanVienRow(
                    r.Id,
                    r.MaNV,
                    r.TenNV,
                    r.SDT,
                    r.ChucVu,
                    r.SoGiaoDich,
                    r.TongTien
                );
            }

            // 🔥 DATASOURCE
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DanhSachNhanVien"; // phải trùng RDLC
            rds.Value = table;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // 🔥 LOAD RDLC
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "DoAnQuanLyTienGui.Reports.rptThongKeNhanVien.rdlc";

            reportViewer1.RefreshReport();

            // gán dữ liệu vào combobox nhân viên 
            var listNV = context.NhanVien.ToList();

            // thêm "Tất cả"
            listNV.Insert(0, new NhanVien
            {
                Id = 0,
                TenNV = "Tất cả"
            });

            cboNhanVien.DataSource = listNV;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "Id";

            cboNhanVien.SelectedIndex = 0; // mặc định chọn "Tất cả"
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Lấy ngày từ DateTimePicker
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1); // fix lỗi 0 dòng

                // 2️⃣ Lấy nhân viên từ ComboBox
                int nvId = cboNhanVien.SelectedValue != null
                           ? (int)cboNhanVien.SelectedValue
                           : 0; // 0 = Tất cả

                // 3️⃣ Lấy dữ liệu từ DB + Include + Lọc + Group theo nhân viên
                var data = context.GiaoDich
                    .Include(gd => gd.NhanVien)
                    .Where(gd => gd.NgayGD >= tuNgay && gd.NgayGD < denNgay)
                    .Where(gd => nvId == 0 || gd.NhanVienId == nvId)
                    .GroupBy(gd => new
                    {
                        gd.NhanVien.Id,
                        gd.NhanVien.MaNV,
                        gd.NhanVien.TenNV,
                        gd.NhanVien.ChucVu
                    })
                    .Select(g => new
                    {
                        Id = g.Key.Id,
                        MaNV = g.Key.MaNV,
                        TenNV = g.Key.TenNV,
                        ChucVu = g.Key.ChucVu,
                        SoGiaoDich = g.Count(),
                        TongTien = g.Sum(x => x.SoTien)
                    })
                    .ToList();

                // 4️⃣ Clear ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();

                // 5️⃣ Add DataSource (tên dataset phải trùng RDLC)
                ReportDataSource rds = new ReportDataSource("DanhSachNhanVien", data);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 6️⃣ Tạo Parameter mô tả ngày (tên phải trùng RDLC)
                ReportParameter param = new ReportParameter(
                               "MoTaKetQuaHienThi",
                               $"Từ ngày {dtpTuNgay.Text} - Đến ngày {dtpDenNgay.Text}"
                           );
                reportViewer1.LocalReport.SetParameters(param);

                // 7️⃣ Refresh ReportViewer
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi chi tiết
                MessageBox.Show("Lỗi khi lọc dữ liệu:\n" + ex.Message + "\n" + ex.StackTrace, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}