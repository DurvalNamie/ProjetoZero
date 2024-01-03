using System.Data;
using System.Data.SqlClient;

namespace ProjetoZero3.Repositorio
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection connection;
        public DbConexao()
        {
            connection = new SqlConnection(@"Server=.;Database=CADASTROPESSOA_ZERO1;User ID = sa; Password = 123;Trusted_Connection=true"); 
        }
        public IDbConnection GetConnection() 
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;

        }

        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
