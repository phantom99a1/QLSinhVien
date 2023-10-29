using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLSinhVien
{
    public class Database
    {
        private string connectionString =@"Data Source=DESKTOP-5QUDR48;Initial Catalog=QLSINHVIEN;Integrated Security=True";
        private SqlConnection conn;

        public Database()
        {
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connected failed: " + ex.Message);
            }
        }
        public DataTable SelectData(string sql,List<CustomParameter>lstPara)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var para in lstPara)
                    cmd.Parameters.AddWithValue(para.Key, para.Value);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);                
                var dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int Excute(string sql,List<CustomParameter>lstPara)
        {
            try
            {
                conn.Open();
                var cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach(var p in lstPara)
                {
                    cmd.Parameters.AddWithValue(p.Key, p.Value);
                }
                return (int)cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
                return -200;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}
