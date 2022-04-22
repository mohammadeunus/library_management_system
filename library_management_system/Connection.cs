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
        public OracleConnection thisConnection = new OracleConnection("Data Source=XE;User ID='ULAB' ;Password='ULAB';");
    }
}
