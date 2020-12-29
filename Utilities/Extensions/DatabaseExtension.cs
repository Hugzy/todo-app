using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Utilities.Extensions
{
    public static class DatabaseExtension
    {
        public static string GetDatabaseConnection(this IConfiguration configuration)
        {
            return configuration.GetSection("ConnectionString").Value;
        }
    }
}