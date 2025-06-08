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
    public class DALChiNhanh
    {
        public List<ChiNhanh> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<ChiNhanh> list = new List<ChiNhanh>();
            try
            {
                SqlDataReader reader = DBUNTIL.Query(sql, args);
                while (reader.Read())
                {
                    ChiNhanh entity = new ChiNhanh();
                    entity.MaChiNhanh = reader.GetString("MaChiNhanh");
                    entity.TenChiNhanh = reader.GetString("TenChiNhanh");
                    entity.DiaChi = reader.GetString("DiaChi");
                    entity.SoDienThoai = reader.GetString("SoDienThoai");
                    entity.TrangThai = reader.GetBoolean("TrangThai");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<ChiNhanh> selectAll()
        {
            string sql = "SELECT * FROM ChiNhanh";
            return SelectBySql(sql, new List<object>());
        }

        public string generateMaChiNhanh()
        {
            string prefix = "CN";
            string sql = "SELECT MAX(MaChiNhanh) FROM ChiNhanh";
            List<object> thamSo = new List<object>();
            object result = DBUNTIL.ScalarQuery(sql, thamSo);
            if (result != null && result.ToString().StartsWith(prefix))
            {
                string maxCode = result.ToString().Substring(3);
                int newNumber = int.Parse(maxCode) + 1;
                return $"{prefix}{newNumber:D3}";
            }

            return $"{prefix}001";
        }

        public void insertChiNhanh(ChiNhanh cn)
        {
            try
            {
                string sql = @"INSERT INTO ChiNhanh (MaChiNhanh, TenChiNhanh, DiaChi, SoDienThoai, TrangThai) 
                   VALUES (@0, @1, @2, @3, @4)";
                List<object> thamSo = new List<object>();
                thamSo.Add(cn.MaChiNhanh);
                thamSo.Add(cn.TenChiNhanh);
                thamSo.Add(cn.DiaChi);
                thamSo.Add(cn.SoDienThoai);
                thamSo.Add(cn.TrangThai);
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void updateChiNhanh(ChiNhanh cn)
        {
            try
            {
                string sql = @"UPDATE ChiNhanh 
           SET TenChiNhanh = @1, DiaChi = @2, SoDienThoai = @3, TrangThai = @4 
           WHERE MaChiNhanh = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(cn.MaChiNhanh);     // @0
                thamSo.Add(cn.TenChiNhanh);    // @1
                thamSo.Add(cn.DiaChi);         // @2 ✅ Đúng chỗ
                thamSo.Add(cn.SoDienThoai);    // @3 ✅ Đúng chỗ
                thamSo.Add(cn.TrangThai);      // @4
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception e) { throw; }
        }

        public void deleteChiNhanh(string cn)
        {
            try
            {
                string sql = "DELETE FROM ChiNhanh WHERE MaChiNhanh = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(cn);
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
