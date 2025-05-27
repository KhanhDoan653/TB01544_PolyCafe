using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PolyCafe
{
    public class BLLThongKe
    {
        DALThongKe dalThongKe = new DALThongKe();

        public List<ThongKeTheoLoaiSanPham> getThongKeLoaiSP(string loaiSP, DateTime ngayBD, DateTime ngayKt)
        {
            return dalThongKe.GetDoanhThuTheoLoaiSP(loaiSP, ngayBD, ngayKt);

        }

        public List<ThongKeTheoNhanVien> getThongKeNhanVien(string maNV, DateTime ngayBD, DateTime ngayKt)
        {
            return dalThongKe.GetDoanhThuTheoNhanVien(maNV, ngayBD, ngayKt);

        }
    }
}
