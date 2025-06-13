using DTO_PolyCafe;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PolyCafe
{
    public class DALGioiThieu
    {
        public GioiThieu LayGioiThieu()
        {
            GioiThieu gt = null; string query = "SELECT NoiDung FROM GioiThieu WHERE MaGioiThieu = @MaGioiThieu";
            using (SqlConnection conn = DBUNTIL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaGioiThieu", "GT0001");
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            gt = new GioiThieu { NoiDung = reader["NoiDung"].ToString() };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy nội dung giới thiệu: " + ex.Message);
                }
            }

            return gt ?? new GioiThieu { NoiDung = "Chưa có nội dung giới thiệu." };
        }
    }
}

