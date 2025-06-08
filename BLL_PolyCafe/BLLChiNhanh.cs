using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PolyCafe
{
    public class BLLChiNhanh
    {
        DALChiNhanh dalChiNhanh = new DALChiNhanh();

        public List<ChiNhanh> GetChiNhanhs()
        {
            return dalChiNhanh.selectAll();
        }


        public string InsertChiNhanh(ChiNhanh cn)
        {
            try
            {
                cn.MaChiNhanh = dalChiNhanh.generateMaChiNhanh();
                if (string.IsNullOrEmpty(cn.MaChiNhanh))
                {
                    return "Mã chi nhánh không hợp lệ.";
                }

                dalChiNhanh.insertChiNhanh(cn);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Thêm mới không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateChiNhanh(ChiNhanh cn)
        {
            try
            {
                if (string.IsNullOrEmpty(cn.MaChiNhanh))
                {
                    return "Mã chi nhánh không hợp lệ.";
                }
                dalChiNhanh.updateChiNhanh(cn);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Cập nhật không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteChiNhanh(string maCN)
        {
            try
            {
                if (string.IsNullOrEmpty(maCN))
                {
                    return "Mã chi nhánh không hợp lệ.";
                }

                dalChiNhanh.deleteChiNhanh(maCN);
                return string.Empty;
            }
            catch (Exception ex)
            {
                //return "Xóa không thành công.";
                return "Lỗi: " + ex.Message;
            }
        }
        public string GenerateChiNhanh()
        {
            return dalChiNhanh.generateMaChiNhanh();
        }
    }
}
