using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HopeProfessor.Helpers
{
    class Dbs1
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["HopeProfessor.Properties.Settings.crudConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
