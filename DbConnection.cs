using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PolymorphismAssignment
{
    public abstract class DbConnection
    {
        private readonly string _connectionString; private readonly string _timeout;
        protected DbConnection(string connectionString) { if (String.IsNullOrWhiteSpace(connectionString)) throw new ArgumentException("The connection string cannot be null,whitespace or empty"); _connectionString = connectionString; }
        public abstract void Open(); public abstract void Close();
    }
}