using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PolyCafe
{
    public class BLLCoSoVatChat
    {
        DALCoSoVatChat dal = new DALCoSoVatChat();

        public List<CoSoVatChat> GetCoSoVatChats()
        {
            return dal.selectAll();
        }

        public string InsertCoSoVatChat(CoSoVatChat cs)
        {
            try
            {
                cs.MaCoSo = dal.generateMaCoSoVatChat();
                if (string.IsNullOrEmpty(cs.MaCoSo))
                    return "Mã không hợp lệ.";

                dal.insertCoSoVatChat(cs);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string UpdateCoSoVatChat(CoSoVatChat cs)
        {
            try
            {
                if (string.IsNullOrEmpty(cs.MaCoSo))
                    return "Mã không hợp lệ.";

                dal.updateCoSo(cs);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string DeleteCoSo(string macs)
        {
            try
            {
                if (string.IsNullOrEmpty(macs))
                    return "Mã không hợp lệ.";

                dal.deleteCoSoVatChat(macs);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        public string GenerateMaCoSo()
        {
            return dal.generateMaCoSoVatChat();
        }
    }
}
