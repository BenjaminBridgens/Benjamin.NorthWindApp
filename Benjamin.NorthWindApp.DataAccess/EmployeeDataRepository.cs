using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Benjamin.NorthWindApp.Entities;

namespace Benjamin.NorthWindApp.DataAccess
{
    class EmployeeDataRepository
    {
        private QueryExecutor executor;

        public EmployeeDataRepository()
        {
            try
            {
                executor = new QueryExecutor("Data Source=cvdb3,1444;Integrated Security = True; Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
            catch( Exception ) { throw; }
        }

        public List<Employee> GetAll()
        {
            List<Employee> allEmployees = new List<Employee>(0);
            string query = "SELECT * FROM Employees";

            try
            {
                DataSet ds = executor.Execute(query);
                DataTable table = ds.Tables[0];

                
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
