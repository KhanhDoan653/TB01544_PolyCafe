using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULTIL_PolyCafe
{
    public class AuthUtil
    {
        public static NhanVien user = null;
        public static bool IsLogin()
        {
            if (user == null)
            {
                return false;
            }
            if(string.IsNullOrWhiteSpace(user.MaNhanVien))
            {
                return false;
            }
            return true;
        }
    }
}
