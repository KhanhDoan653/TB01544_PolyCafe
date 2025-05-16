using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PolyCafe
{
    public class BLLNhanVien
    {
        DALNhanVien dalNhanVien = new DALNhanVien();
        public NhanVien DangNhap(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return null;
            }
            return dalNhanVien.getNhanVien(email, password);
        }
        public bool ResetPassword(string email, string password)
        {
            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    return false;
                }
                dalNhanVien.ResetPassword(email, password);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi hệ thống: {ex.Message}");
                return false;
            }
        }
    }
}
