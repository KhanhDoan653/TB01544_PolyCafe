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
    public class DALPhieuBanHang
    {
        public string generateMaPhieu()
        {
            string prefix = "PBH";
            string sql = "SELECT MAX(MaPhieu) FROM PhieuBanHang";
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

        public void insertPhieuBanHang(PhieuBanHang pbh)
        {
            try
            {
                string sql = @"INSERT INTO PhieuBanHang (MaPhieu, MaThe, MaNhanVien, NgayTao, TrangThai) 
                   VALUES (@0, @1, @2, @3, @4)";
                List<object> thamSo = new List<object>();
                thamSo.Add(pbh.MaPhieu);
                thamSo.Add(pbh.MaThe);
                thamSo.Add(pbh.MaNhanVien);
                thamSo.Add(pbh.NgayTao);
                thamSo.Add(pbh.TrangThai);
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void updateNhanVien(PhieuBanHang pbh)
        {
            try
            {
                string sql = @"UPDATE PhieuBanHang 
                   SET MaThe = @1, MaNhanVien = @2, NgayTao = @3, TrangThai = @4 
                   WHERE MaPhieu = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(pbh.MaPhieu);
                thamSo.Add(pbh.MaThe);
                thamSo.Add(pbh.MaNhanVien);
                thamSo.Add(pbh.NgayTao);
                thamSo.Add(pbh.TrangThai);
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public void deletePhieuBanHang(string maPhieu)
        {
            try
            {
                string sql = "DELETE FROM PhieuBanHang WHERE MaPhieu = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(maPhieu);
                DBUNTIL.Update(sql, thamSo);
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public List<PhieuBanHang> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhieuBanHang> list = new List<PhieuBanHang>();
            try
            {
                SqlDataReader reader = DBUNTIL.Query(sql, args);
                while (reader.Read())
                {
                    PhieuBanHang entity = new PhieuBanHang();
                    entity.MaPhieu = reader.GetString("MaPhieu");
                    entity.MaThe = reader.GetString("MaThe");
                    entity.ChuSoHuu = reader.GetString("ChuSoHuu");
                    entity.MaNhanVien = reader.GetString("MaNhanVien");
                    entity.HoTen = reader.GetString("HoTen");
                    entity.NgayTao = reader.GetDateTime("NgayTao");
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

        public List<PhieuBanHang> selectAll(string maThe)
        {
            //String sql = "SELECT * FROM PhieuBanHang";
            List<object> param = new List<object>();
            string sql = "SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai " +
                "FROM PhieuBanHang phieu INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien " +
                "INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe";
            if (!string.IsNullOrEmpty(maThe))
            {
                sql = "SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai " +
               "FROM PhieuBanHang phieu INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien " +
               "INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe " +
               "WHERE the.MaThe = @0";
                param.Add(maThe);
            }

            return SelectBySql(sql, param);
        }
        public string UpdatePhanTramGiam(PhieuBanHang phieu)
        {
            try
            {
                string sql = "UPDATE PhieuBanHang SET PhanTramGiam = @1 WHERE MaPhieu = @0";
                List<object> thamSo = new List<object>();
                thamSo.Add(phieu.MaPhieu);
                thamSo.Add(phieu.PhanTramGiam);
                DBUNTIL.Update(sql, thamSo);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}
