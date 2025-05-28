using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_PolyCafe
{
    public class KhuyenMai
    {
        public string MaKM { get; set; }
        public string TenKM { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public decimal PhanTramGiam { get; set; }
        public bool TrangThai { get; set; }
        public string TrangThaiText => TrangThai ? "Đang được áp dụng" : "Hết hạn KM";
    }
}
