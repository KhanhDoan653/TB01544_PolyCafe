using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PolyCafe
{
    public class BLLPhieuBanHang
    {
        DALPhieuBanHang dalPhieuBanHang = new DALPhieuBanHang();

        public List<PhieuBanHang> GetListPhieuBanHang(string maThe)
        {
            DALPhieuBanHang dal = new DALPhieuBanHang();
            return dal.selectAll(maThe);
        }

        public string InsertPhieuBanHang(PhieuBanHang phieu)
        {
            try
            {
                DALPhieuBanHang dal = new DALPhieuBanHang();
                phieu.MaPhieu = dal.generateMaPhieu(); // Tạo mã phiếu
                dal.insertPhieuBanHang(phieu);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UpdatePhieuBanHang(PhieuBanHang phieu)
        {
            try
            {
                DALPhieuBanHang dal = new DALPhieuBanHang();
                dal.updatePhieuBanHang(phieu);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeletePhieuBanHang(string maPhieu)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }

                dalPhieuBanHang.deletePhieuBanHang(maPhieu);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public string UpdatePhanTramGiam(PhieuBanHang phieu)
        {
            try
            {
                return new DALPhieuBanHang().UpdatePhanTramGiam(phieu);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GenerateMaPhieu()
        {
            try
            {
                return dalPhieuBanHang.generateMaPhieu();
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
}
