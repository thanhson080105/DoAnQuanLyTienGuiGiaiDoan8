using DoAnQuanLyTienGui.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyTienGui.Reports
{
    public partial class frmThongKeKhachHang : System.Windows.Forms.Form
    {
        QLTGDbcontext context = new QLTGDbcontext();

        // 🔥 DataTable typed giống ChiTiet
        QLTGDataSet.DanhSachKhachHangDataTable table =
            new QLTGDataSet.DanhSachKhachHangDataTable();

        string reportsFolder =
            Application.StartupPath.Replace("bin\\Debug", "Reports");
        public frmThongKeKhachHang()
        {
            InitializeComponent();
        }

        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {
            // 🔥 Setup ReportViewer
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 90;

            // =========================================
            // 🔹 1. LOAD COMBOBOX KHÁCH HÀNG
            // =========================================
            var listKH = context.KhachHang.ToList();

            listKH.Insert(0, new KhachHang
            {
                Id = 0,
                TenKH = "Tất cả"
            });

            cboKhachHang.DataSource = listKH;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "Id";
            cboKhachHang.SelectedIndex = 0;

            // =========================================
            // 🔹 2. LOAD TOÀN BỘ KHÁCH HÀNG (KỂ CẢ CHƯA GD)
            // =========================================
            var data = context.KhachHang
                .Select(kh => new
                {
                    kh.Id,
                    kh.MaKH,
                    kh.TenKH,
                    kh.SDT,
                    kh.DiaChi,

                    SoGiaoDich = context.GiaoDich
                        .Count(gd => gd.SoTietKiem.KhachHangId == kh.Id),

                    TongTien = context.GiaoDich
                        .Where(gd => gd.SoTietKiem.KhachHangId == kh.Id)
                        .Sum(gd => (decimal?)gd.SoTien) ?? 0
                })
                .ToList();

            table.Clear();

            foreach (var r in data)
            {
                table.AddDanhSachKhachHangRow(
                    r.Id,
                    r.MaKH,
                    r.TenKH,
                    r.SDT,
                    r.DiaChi,
                    r.SoGiaoDich,
                    r.TongTien
                );
            }

            // =========================================
            // 🔹 3. ĐỔ REPORT
            // =========================================
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DanhSachKhachHang"; // ⚠️ trùng RDLC
            rds.Value = table;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "DoAnQuanLyTienGui.Reports.rptThongKeKhachHang.rdlc";

            reportViewer1.RefreshReport();
        }
        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Lấy ngày
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1);

                // 2️⃣ Lấy khách hàng từ ComboBox
                int khId = cboKhachHang.SelectedValue != null
                           ? (int)cboKhachHang.SelectedValue
                           : 0;

                // 3️⃣ Lấy dữ liệu (GIỐNG NHÂN VIÊN nhưng đổi KH)
                var data = context.KhachHang
                    .Select(kh => new
                    {
                        kh.Id,
                        kh.MaKH,
                        kh.TenKH,
                        kh.SDT,
                        kh.DiaChi,

                        SoGiaoDich = context.GiaoDich
                            .Where(gd =>
                                gd.SoTietKiem.KhachHangId == kh.Id &&
                                gd.NgayGD >= tuNgay &&
                                gd.NgayGD < denNgay)
                            .Count(),

                        TongTien = context.GiaoDich
                            .Where(gd =>
                                gd.SoTietKiem.KhachHangId == kh.Id &&
                                gd.NgayGD >= tuNgay &&
                                gd.NgayGD < denNgay)
                            .Sum(gd => (decimal?)gd.SoTien) ?? 0
                    })
                    .Where(kh => khId == 0 || kh.Id == khId)
                    .ToList();

                // 4️⃣ Clear ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();

                // 🔥 QUAN TRỌNG: load lại RDLC
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "DoAnQuanLyTienGui.Reports.rptThongKeKhachHang.rdlc";

                // 5️⃣ DataSource (PHẢI TRÙNG RDLC)
                ReportDataSource rds = new ReportDataSource("DanhSachKhachHang", data);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 6️⃣ Parameter
                ReportParameter param = new ReportParameter(
                    "MoTaKetQuaHienThi",
                    $"Từ ngày {dtpTuNgay.Text} - Đến ngày {dtpDenNgay.Text}"
                );

                reportViewer1.LocalReport.SetParameters(param);

                // 7️⃣ Refresh
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi lọc dữ liệu:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
