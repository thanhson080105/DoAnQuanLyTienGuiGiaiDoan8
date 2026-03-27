using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnQuanLyTienGui.Data
{
    public class SoTietKiem
    {
        [Key]
        public int Id { get; set; }

        public string MaSo { get; set; }
        public DateTime NgayMoSo { get; set; }
        public decimal SoTien { get; set; }
        public decimal LaiSuat { get; set; }
        public int KyHan { get; set; }

        // khóa ngoại khách hàng
        public int KhachHangId { get; set; }
        public KhachHang KhachHang { get; set; }

        public ICollection<GiaoDich> GiaoDich { get; set; }

        [NotMapped]
        public string TenKhachHang => KhachHang?.TenKH;
    }
}