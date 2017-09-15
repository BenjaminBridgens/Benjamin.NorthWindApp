using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Benjamin.NorthWindApp.Entities;

namespace Benjamin.NortWindApp.DataAccess
{
    class EmployeeDataRepository
    {
        private readonly string connectionString = "Data Source=cvdb3,1444;Integrated Security = True; Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public EmployeeDataRepository(string connectionString)
        {
            try
            {
                QueryExecutor executor = new QueryExecutor(connectionString)
            }
            catch { }
        }

        public List<Employee> GetAll()
        {
            List<Employee> allEmployees = new List<Employee>(0);
            string query = "SELECT * FROM Employees";

            try
            {
                
            }
            catch( ObjectDisposedException ) { throw; }
            catch( InvalidOperationException ) { throw; }
            catch( InvalidCastException ) { throw; }
            catch( SqlException ) { throw; }
            catch( System.IO.IOException ) { throw; }

            return allEmployees;
        }


    }
}
