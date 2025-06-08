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
    public class DALCoSoVatChat
    {
        public string generateMaCoSoVatChat()
        {
            string prefix = "CSV";
            string sql = "SELECT MAX(MaCoSo) FROM CoSoVatChat";
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

        public List<CoSoVatChat> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<CoSoVatChat> list = new List<CoSoVatChat>();
            try
            {
                SqlDataReader reader = DBUNTIL.Query(sql, args);
                while (reader.Read())
                {
                    CoSoVatChat entity = new CoSoVatChat();
                    entity.MaCoSo = reader["MaCoSo"].ToString();
                    entity.TenCoSo = reader["TenCoSo"].ToString();
                    entity.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                    entity.MaChiNhanh = reader["MaChiNhanh"].ToString();
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public List<CoSoVatChat> selectAll()
        {
            string sql = "SELECT * FROM CoSoVatChat";
            List<object> p = new List<object>();
            return SelectBySql(sql, p);
        }

        public List<CoSoVatChat> selectMaCoSo(string macs)
        {
            string sql = "SELECT * FROM CoSoVatChat WHERE MaCoSo = @0";
            List<object> thamSo = new List<object> { macs };
            return SelectBySql(sql, thamSo);
        }

        public void insertCoSoVatChat(CoSoVatChat cs)
        {
            string sql = @"INSERT INTO CoSoVatChat (MaCoSo, TenCoSo, SoLuong, MaChiNhanh) 
                       VALUES (@0, @1, @2, @3)";
            List<object> thamSo = new List<object>
        {
            cs.MaCoSo,
            cs.TenCoSo,
            cs.SoLuong,
            cs.MaChiNhanh
        };
            DBUNTIL.Update(sql, thamSo);
        }

        public void insertListCoSo(List<CoSoVatChat> lst)
        {
            foreach (CoSoVatChat item in lst)
            {
                insertCoSoVatChat(item);
            }
        }

        public void updateCoSo(CoSoVatChat cs)
        {
            string sql = @"UPDATE CoSoVatChat 
                       SET TenCoSo = @1, SoLuong = @2, MaChiNhanh = @3
                       WHERE MaCoSo = @0";
            List<object> thamSo = new List<object>
        {
            cs.MaCoSo,
            cs.TenCoSo,
            cs.SoLuong,
            cs.MaChiNhanh
        };
            DBUNTIL.Update(sql, thamSo);
        }

        public void deleteCoSoVatChat(string Id)
        {
            string sql = "DELETE FROM CoSoVatChat WHERE MaCoSo = @0";
            List<object> thamSo = new List<object> { Id };
            DBUNTIL.Update(sql, thamSo);
        }

    }
}

