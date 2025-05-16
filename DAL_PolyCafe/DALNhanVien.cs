using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PolyCafe
{
    public class DALNhanVien
    {
        public NhanVien getNhanVien(string email, string password)
        {
            string sql = "SELECT * FROM NhanVien WHERE Email = @0 AND MatKhau = @1";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            thamSo.Add(password);
            NhanVien nv = DBUNTIL.Value<NhanVien>(sql, thamSo);
            return nv;
        }

        public void ResetPassword(string email, string password)
        {
            try
            {
                string sql = "UPDATE NhanVien SET MatKhau = @0 WHERE Email = @1";
                List<object> thamSo = new List<object>();
                thamSo.Add(password);
                thamSo.Add(email);
                DBUNTIL.Update(sql, thamSo);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Lỗi hệ thống: {ex.Message}");
                throw;
            }
        }
    }
}
