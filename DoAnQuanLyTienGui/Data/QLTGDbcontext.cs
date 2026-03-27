using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DoAnQuanLyTienGui.Data
{
    using Microsoft.EntityFrameworkCore;

    public class QLTGDbcontext : DbContext
    {
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<NhanVien> NhanVien{ get; set; }
        public DbSet<SoTietKiem> SoTietKiem { get; set; }
        public DbSet<GiaoDich> GiaoDich { get; set; }
        public DbSet<LoaiGiaoDich> LoaiGiaoDich { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=NGUYENVOTHANHSO\\THANHSON1;Database=QLTienGui;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;");
        }
    }
}


