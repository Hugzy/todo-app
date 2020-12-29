using Microsoft.Extensions.DependencyInjection;

namespace Utilities.Extensions
{
    public static class CorsExtensions
    {
        public static IServiceCollection AddCorsDevelopmentPolicies(this IServiceCollection services)
        {
            services.AddCors(o => o.AddPolicy("DevelopmentPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
            
            return services;
        }
    }
}