using DoAnQuanLyTienGui.Data;
using DocumentFormat.OpenXml.Office2010.Excel;
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
    public partial class frmThongKeChiTiet : System.Windows.Forms.Form
    {
        QLTGDbcontext context = new QLTGDbcontext();

        QLTGDataSet.DanhSachGiaoDichDataTable table =
            new QLTGDataSet.DanhSachGiaoDichDataTable();

        string reportsFolder =
            Application.StartupPath.Replace("bin\\Debug", "Reports");
        public frmThongKeChiTiet()
        {
            InitializeComponent();
        }


        private void frmThongKeChiTiet_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.Reset();

                reportViewer1.Dock = DockStyle.Fill;
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                // 🔥 Lấy dữ liệu có Include đầy đủ
                var data = context.GiaoDich
                    .Include(gd => gd.SoTietKiem)
                    .Include(gd => gd.NhanVien)
                    .Include(gd => gd.LoaiGiaoDich)
                    .ToList();

                table.Clear();

                foreach (var gd in data)
                {
                    table.AddDanhSachGiaoDichRow(
                        gd.Id,
                        gd.MaGD,
                        gd.NgayGD,
                        gd.SoTien,
                        gd.SoTietKiem != null ? gd.SoTietKiem.MaSo : "",
                        gd.NhanVien != null ? gd.NhanVien.TenNV : "",
                        gd.LoaiGiaoDich != null ? gd.LoaiGiaoDich.TenLoai : ""
                    );
                }

                ReportDataSource rds = new ReportDataSource("ThongKeChiTiet", (DataTable)table);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "DoAnQuanLyTienGui.Reports.rptThongKeChiTiet.rdlc";

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1);

            var data = context.GiaoDich
                .Where(gd => gd.NgayGD >= tuNgay && gd.NgayGD < denNgay)
                .Include(gd => gd.SoTietKiem)
                .Include(gd => gd.NhanVien)
                .Include(gd => gd.LoaiGiaoDich)
                .ToList();

            table.Clear();

            foreach (var gd in data)
            {
                table.AddDanhSachGiaoDichRow(
                    gd.Id,
                    gd.MaGD,
                    gd.NgayGD,
                    gd.SoTien,
                    gd.SoTietKiem?.MaSo ?? "",
                    gd.NhanVien?.TenNV ?? "",
                    gd.LoaiGiaoDich?.TenLoai ?? ""
                );
            }

            // 🔥 QUAN TRỌNG: reset report
            reportViewer1.Reset();

            ReportDataSource rds = new ReportDataSource("ThongKeChiTiet", (DataTable)table);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "DoAnQuanLyTienGui.Reports.rptThongKeChiTiet.rdlc";

            // 🔥 SET PARAMETER SAU KHI LOAD REPORT
            ReportParameter param = new ReportParameter(
                "MoTaKetQuaHienThi",
                $"Từ ngày {dtpTuNgay.Text} - Đến ngày {dtpDenNgay.Text}"
            );

            reportViewer1.LocalReport.SetParameters(param);

            reportViewer1.RefreshReport(); // 🔥 BẮT BUỘC
        }
    }
}