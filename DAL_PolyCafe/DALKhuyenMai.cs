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
    public class DALKhuyenMai
    {
        public List<KhuyenMai> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<KhuyenMai> list = new List<KhuyenMai>();
            try
            {
                SqlDataReader reader = DBUNTIL.Query(sql, args);
                while (reader.Read())
                {
                    KhuyenMai entity = new KhuyenMai
                    {
                        MaKM = reader.GetString("MaKhuyenMai"),
                        TenKM = reader.GetString("TenKhuyenMai"),
                        PhanTramGiam = reader.GetDecimal("PhanTramGiam"),
                        NgayBatDau = reader.GetDateTime("NgayBatDau"),
                        NgayKetThuc = reader.GetDateTime("NgayKetThuc"),
                        TrangThai = reader.GetBoolean("TrangThai")
                    };
                    list.Add(entity);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                throw;
            }
            return list;
        }

        public List<KhuyenMai> selectAll(int trangThai = -1)
        {
            string sql = "SELECT MaKhuyenMai, TenKhuyenMai, PhanTramGiam, NgayBatDau, NgayKetThuc, TrangThai FROM KhuyenMai";
            List<object> p = new List<object>();

            if (trangThai > -1)
            {
                sql += " WHERE TrangThai = @0";
                p.Add(trangThai);
            }

            return SelectBySql(sql, p);
        }

        public KhuyenMai selectById(string id)
        {
            string sql = "SELECT * FROM KhuyenMai WHERE MaKhuyenMai = @0";
            List<object> thamSo = new List<object> { id };
            List<KhuyenMai> list = SelectBySql(sql, thamSo);
            return list.Count > 0 ? list[0] : null;
        }

        public void insertKhuyenMai(KhuyenMai km)
        {
            try
            {
                string sql = @"INSERT INTO KhuyenMai (MaKhuyenMai, TenKhuyenMai, PhanTramGiam, NgayBatDau, NgayKetThuc, TrangThai)
                   VALUES (@0, @1, @2, @3, @4, @5)";
                List<object> thamSo = new List<object>
                {
                    km.MaKM, km.TenKM, km.PhanTramGiam, km.NgayBatDau, km.NgayKetThuc, km.TrangThai
                };
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                throw;
            }
        }

        public void updateKhuyenMai(KhuyenMai km)
        {
            try
            {
                string sql = @"UPDATE KhuyenMai 
                   SET TenKhuyenMai = @1, PhanTramGiam = @2, NgayBatDau = @3, NgayKetThuc = @4, TrangThai = @5 
                   WHERE MaKhuyenMai = @0";
                List<object> thamSo = new List<object>
                {
                    km.MaKM, km.TenKM, km.PhanTramGiam, km.NgayBatDau, km.NgayKetThuc, km.TrangThai
                };
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                throw;
            }
        }

        public void deleteKhuyenMai(string maKM)
        {
            try
            {
                string sql = "DELETE FROM KhuyenMai WHERE MaKhuyenMai = @0";
                List<object> thamSo = new List<object> { maKM };
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                throw;
            }
        }

        public string generateMaKhuyenMai()
        {
            string prefix = "KM";
            string sql = "SELECT MAX(MaKhuyenMai) FROM KhuyenMai";
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
    }
}
