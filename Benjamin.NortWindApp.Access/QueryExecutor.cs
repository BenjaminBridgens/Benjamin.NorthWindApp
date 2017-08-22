using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Benjamin.NorthWindApp.DataAccess
{
    public class QueryExecutor
    {
        private String connectionString;

        public QueryExecutor(string connectionString)
        {
            if( String.IsNullOrWhiteSpace(connectionString) )
            {
                throw new ArgumentException(nameof(connectionString) );
            }

            try
            {
                using( SqlConnection connection = new SqlConnection(connectionString) )
                {
                    connection.Open();
                }
            }
            catch( ArgumentException ) { throw; }
            catch( InvalidOperationException ) { throw; }
            catch( SqlException ) { throw; }

            this.connectionString = connectionString;
        }
        



    }
}
