using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CEM_Event_Managment_System
{
    class DBConnection
    {
        public SqlConnection getConnection()
        {

            SqlConnection sqlCon = null;
            try
            {
                sqlCon = new SqlConnection("Data Source=DESKTOP-MADARAS\\SQLEXPRESS02;Initial Catalog=CEM_Database;Integrated Security=True");
                          
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to DB" + ex);

            }
            return sqlCon;
        }
    }
}
