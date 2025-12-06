using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Refeitep.Api.Repository
{
    public class SistemaContextFactory : IDesignTimeDbContextFactory<SistemaContext>
    {
        public SistemaContext CreateDbContext(string[]? args = null)
        {
            var host = "localhost";
            var user = "root";
            var senha = "root";
            var database = "refeitep";

            var connectionString = $"server={host};user={user};password={senha};database={database};";

            var builder = new DbContextOptionsBuilder<SistemaContext>();
            builder.UseMySql(connectionString,
                                ServerVersion.AutoDetect(connectionString));

            return new SistemaContext(builder.Options);
        }
    }
}