using DoAnQuanLyTienGui.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace DoAnQuanLyTienGui.Reports
{
    public partial class frmInPhieuGiaoDich_ChiTiet : System.Windows.Forms.Form
    {
        private int IdGiaoDich;
        private QLTGDbcontext context = new QLTGDbcontext();

        public frmInPhieuGiaoDich_ChiTiet(int id)
        {
            InitializeComponent();
            IdGiaoDich = id;
        }

        private void frmInPhieuGiaoDich_ChiTiet_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Kiểm tra ID hợp lệ
                if (IdGiaoDich <= 0)
                {
                    MessageBox.Show("Không có giao dịch để in!");
                    return;
                }

                // 2. Lấy dữ liệu giao dịch từ DB (Phần này bạn đã viết đúng)
                var gd = context.GiaoDich
                    .Include(x => x.NhanVien)
                    .Include(x => x.SoTietKiem)
                        .ThenInclude(stk => stk.KhachHang)
                    .FirstOrDefault(x => x.Id == IdGiaoDich);

                if (gd == null)
                {
                    MessageBox.Show("Không tìm thấy giao dịch để in!");
                    return;
                }

                // 3. Tạo DataTable từ DataSet (Đúng tên bảng trong DataSet của bạn)
                QLTGDataSet.DanhSachGiaoDich_ChiTietDataTable table =
                    new QLTGDataSet.DanhSachGiaoDich_ChiTietDataTable();

                table.AddDanhSachGiaoDich_ChiTietRow(
                    gd.Id,
                    gd.MaGD ?? "",
                    gd.SoTietKiem?.KhachHang?.TenKH ?? "",
                    gd.SoTietKiem?.KhachHang?.SDT ?? "",
                    gd.SoTietKiem?.KhachHang?.DiaChi ?? "",
                    gd.NhanVien?.TenNV ?? "",
                    gd.SoTietKiem?.MaSo ?? "",
                    gd.NgayGD,
                    gd.SoTien 
                );

                // 4. Setup ReportViewer
                // Dùng Control có sẵn từ Designer, không tạo mới bằng lệnh 'new'
                reportViewer1.LocalReport.DataSources.Clear();  

                // Tên "DanhSachGiaoDich_ChiTiet" phải khớp 100% với tên Dataset trong file .rdlc
                ReportDataSource rds = new ReportDataSource("DanhSachGiaoDich_ChiTiet", (DataTable)table);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Đường dẫn Resource (Đảm bảo Build Action của file .rdlc là Embedded Resource)
                reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnQuanLyTienGui.Reports.rptInPhieuGiaoDich.rdlc";

                // Thiết lập chế độ hiển thị
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                // 5. Refresh report
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load report: " + ex.Message);
            }
        }
    }
}