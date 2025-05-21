using DTO_PolyCafe;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi hệ thống: {ex.Message}");
                throw;
            }
        }
        public void Insert(NhanVien entity)
        {
            string sql = "INSERT INTO NhanVien (MaNhanVien, HoTen, Email, MatKhau, VaiTro, TrangThai) VALUES (@0, @1, @2, @3, @4, @5)";
            List<object> thamSo = new List<object>();
            thamSo.Add(entity.MaNhanVien);
            thamSo.Add(entity.HoTen);
            thamSo.Add(entity.Email);
            thamSo.Add(entity.MatKhau);
            thamSo.Add(entity.VaiTro);
            thamSo.Add(entity.TrangThai);
            DBUNTIL.Update(sql, thamSo);
        }

        public void Update(NhanVien entity)
        {
            string sql = "UPDATE NhanVien SET HoTen = @0, Email = @1, MatKhau = @2, VaiTro = @3, TrangThai = @4 WHERE MaNhanVien = @5";
            List<object> thamSo = new List<object>();
            thamSo.Add(entity.HoTen);
            thamSo.Add(entity.Email);
            thamSo.Add(entity.MatKhau);
            thamSo.Add(entity.VaiTro);
            thamSo.Add(entity.TrangThai);
            thamSo.Add(entity.MaNhanVien);
            DBUNTIL.Update(sql, thamSo);
        }

        public List<NhanVien> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<NhanVien> list = new List<NhanVien>();
            try
            {
                SqlDataReader reader = DBUNTIL.Query(sql, args);
                while (reader.Read())
                {
                    NhanVien entity = new NhanVien();
                    entity.MaNhanVien = reader.GetString(0);
                    entity.HoTen = reader.GetString(1);
                    entity.Email = reader.GetString(2);
                    entity.MatKhau = reader.GetString(3);
                    entity.VaiTro = reader.GetBoolean(4);
                    entity.TrangThai = reader.GetBoolean(5);
                    list.Add(entity);
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return list;
        }

        public List<NhanVien> selectAll()
        {
            String sql = "SELECT * FROM NhanVien";
            return selectBySql(sql, new List<object>());
        }

        public NhanVien selectById(string id)
        {
            String sql = "SELECT * FROM NhanVien WHERE MaNhanVien=@0";
            List<object> thamSo = new List<object>();
            thamSo.Add(id);
            List<NhanVien> list = selectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public string generateMaNhanVien()
        {
            string prefix = "NV";
            string sql = "SELECT MAX(MaNhanVien) FROM NhanVien";
            List<object> thamSo = new List<object>();
            object result = DBUNTIL.ScalarQuery(sql, thamSo);

            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(2);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

        public bool checkEmailExists(string email)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE Email = @0";
            List<object> thamSo = new List<object>();
            thamSo.Add(email);
            object result = DBUNTIL.ScalarQuery(sql, thamSo);
            return Convert.ToInt32(result) > 0;
        }
    }
}
