using DTO_PolyCafe;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PolyCafe
{
    public class DALHDSD
    {
        public HDSD LayHuongDan()
        {
            HDSD hd = null; string query = "SELECT NoiDung FROM HuongDan WHERE MaHuongDan = @MaHuongDan";
            using (SqlConnection conn = DBUNTIL.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@MaHuongDan", "HD001");
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hd = new HDSD { NoiDung = reader["NoiDung"].ToString() };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy hướng dẫn: " + ex.Message);
                }
            }

            return hd ?? new HDSD { NoiDung = "Chưa có hướng dẫn sử dụng." };
        }
    }
}
