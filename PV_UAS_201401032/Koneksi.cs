using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace PV_UAS_201401032
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = DESKTOP-41RGSIL; initial catalog = Apotek; integrated security = true";
            return Conn;
        }
    }
}