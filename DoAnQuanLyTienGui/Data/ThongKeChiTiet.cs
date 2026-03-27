using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnQuanLyTienGui.Data
{
    public class ThongKeChiTiet
    {
        public int ThongKeChiTietId { get; set; }
        public string NoiDung { get; set; }
        public decimal SoTienTruocGD { get; set; }
        public decimal SoTienSauGD { get; set; }

        // FK
        public int GiaoDichId { get; set; }
        public GiaoDich GiaoDich { get; set; }
    }

}
