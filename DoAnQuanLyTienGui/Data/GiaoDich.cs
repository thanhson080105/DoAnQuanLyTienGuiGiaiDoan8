using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class GiaoDich
    {
        [Key]
        public int Id { get; set; }

        public string MaGD { get; set; }
        public DateTime NgayGD { get; set; }
        public decimal SoTien { get; set; }

        public int SoTietKiemId { get; set; }
        public SoTietKiem SoTietKiem { get; set; }

        public int LoaiGiaoDichId { get; set; }
        public LoaiGiaoDich LoaiGiaoDich { get; set; }

        public int NhanVienId { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
