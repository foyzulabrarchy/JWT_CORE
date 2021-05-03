
using JWT_CORE.Utilities;
using System.Data.SqlClient;

namespace JWT_CORE.DAL
{
    public class ApiDAL
    {
        public static SqlConnection conn = new SqlConnection(DBConnection.GetConnectionString());



    }
}
