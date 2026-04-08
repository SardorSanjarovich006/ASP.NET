using System.Data;
using System.Data.SqlClient;
namespace Sheenam.Data
{
    public class ApplicationDbContext
    {
       private readonly IConfiguration configuration;
        public ApplicationDbContext(IConfiguration configuration,IHostEnvironment environment)
        {
            this.configuration= configuration;  
        }
        public IDbConnection GetDbConnection()
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");

            return new SqlConnection(connectionString); 
        }
    }
}
