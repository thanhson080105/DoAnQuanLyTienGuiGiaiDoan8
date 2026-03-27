using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnQuanLyTienGui.Data;

namespace DoAnQuanLyTienGui.Data
{
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }         // Khóa chính thực sự

        public string MaKH { get; set; }    // Mã định danh hiển thị trên UI
        public string TenKH { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }

        [Browsable(false)]
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public ICollection<SoTietKiem> SoTietKiems { get; set; }
    }

}
