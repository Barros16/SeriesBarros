using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySqlConnector;

namespace SeriesBarros.Repositories
{
    public abstract class RepositorioBase
    {
        private readonly string _conectionString;
        public RepositorioBase()
        {
            _conectionString = "Server=(local); Database=MVVMLoginDb; Integrated Security = true";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(_conectionString);
        }
    }
}
