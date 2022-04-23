using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management_system
{
    internal class Connection
    {
        //public OracleConnection thisConnection = new OracleConnection("Data Source=XE;User ID='ULAB' ;Password='ULAB';");
    }
    /*
    public static int GetDeptNo(int empno)
    {
        int deptno = 0;
        // Check for context connection
        OracleConnection conn = new OracleConnection();
        if (OracleConnection.IsAvailable == true)
        {
            conn.ConnectionString = "context connection=true";
        }
        else
        {
            throw new InvalidOperationException("context connection" +"not available");
        }
        conn.Open();
        // Create and execute a command
        OracleCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT DEPTNO FROM EMP WHERE EMPNO = :1";
        cmd.Parameters.Add(":1", OracleDbType.Int32, empno,
        System.Data.ParameterDirection.Input);
        OracleDataReader rdr = cmd.ExecuteReader();
        if (rdr.Read())
            deptno = rdr.GetInt32(0);
        rdr.Close();
        cmd.Dispose();
        conn.Close();
        return deptno;
    }*/
}
