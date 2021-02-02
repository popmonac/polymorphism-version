using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PolymorphismAssignment
{
    public abstract class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }
        public override void Open() { Console.WriteLine("OracleConnection is open."); }
        public override void Close() { Console.WriteLine("OracleConnection is close."); }
    }
}