using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyCuaHangMayTinh.DTO;
using System.Configuration;

namespace QuanLyCuaHangMayTinh.DAL
{
    public class DataConnect
    {
        public SqlConnection conn = null;
        string sqlConn = ConfigurationManager.ConnectionStrings
            ["QuanLyBanHangSieuThi.Properties.Settings.QLBANHANGConnectionString"].ConnectionString;
        
        public void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(sqlConn);
            }
            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
