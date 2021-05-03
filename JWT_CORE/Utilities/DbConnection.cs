using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_CORE.Utilities
{
    public static class DBConnection
    {
        public static string _connectionString;

        public static string GetConnectionString()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["APIConnection"].ConnectionString;

            return _connectionString;
        }
    }
}
