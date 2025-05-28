using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PolyCafe
{
    public class BLLKhuyenMai
    {
        DALKhuyenMai dalKhuyenMai = new DALKhuyenMai();
        public List<KhuyenMai> GetKhuyenMaiList(int trangThai = -1)
        {
            return dalKhuyenMai.selectAll(trangThai);
        }
        public bool InsertKhuyenMai(KhuyenMai km, out string message)
        {
            try
            {
                if (dalKhuyenMai == null)
                {
                    message = "Lỗi kết nối với cơ sở dữ liệu.";
                    return false;
                }

                km.MaKM = dalKhuyenMai.generateMaKhuyenMai();
                if (string.IsNullOrEmpty(km.MaKM))
                {
                    message = "Mã khuyến mãi không hợp lệ.";
                    return false;
                }

                dalKhuyenMai.insertKhuyenMai(km);
                message = "Thêm khuyến mãi thành công!";
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi Insert: " + ex.Message);
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool UpdateKhuyenMai(KhuyenMai km, out string message)
        {
            try
            {
                if (dalKhuyenMai == null)
                {
                    message = "Lỗi kết nối với cơ sở dữ liệu.";
                    return false;
                }

                if (string.IsNullOrEmpty(km.MaKM))
                {
                    message = "Mã khuyến mãi không hợp lệ.";
                    return false;
                }

                dalKhuyenMai.updateKhuyenMai(km);
                message = "Cập nhật khuyến mãi thành công!";
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi Update: " + ex.Message);
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }

        public bool DeleteKhuyenMai(string maKM, out string message)
        {
            try
            {
                if (dalKhuyenMai == null)
                {
                    message = "Lỗi kết nối với cơ sở dữ liệu.";
                    return false;
                }

                if (string.IsNullOrEmpty(maKM))
                {
                    message = "Mã khuyến mãi không hợp lệ.";
                    return false;
                }

                dalKhuyenMai.deleteKhuyenMai(maKM);
                message = "Xóa khuyến mãi thành công!";
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Lỗi Delete: " + ex.Message);
                message = "Lỗi: " + ex.Message;
                return false;
            }
        }
    }
}
