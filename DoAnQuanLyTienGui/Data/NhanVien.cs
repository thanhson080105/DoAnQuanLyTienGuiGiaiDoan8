using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class NhanVien
    {
        [Key]
        public int Id { get; set; }         // khóa chính

        public string MaNV { get; set; }    // mã hiển thị
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string ChucVu { get; set; }


        // đăng nhập 
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }

        public ICollection<GiaoDich> GiaoDich { get; set; }
    }


}
