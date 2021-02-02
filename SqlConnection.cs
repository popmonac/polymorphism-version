using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PolymorphismAssignment
{
    public abstract class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }
        public override void Open() { Console.WriteLine("SqlConnection is open."); }
        public override void Close() { Console.WriteLine("SqlConnection is close."); }
    }
}
