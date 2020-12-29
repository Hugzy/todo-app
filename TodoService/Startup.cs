using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TodoService.Models.Context;
using Utilities.Extensions;

namespace TodoService
{
    public class Startup
    {
        private IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCorsDevelopmentPolicies();

            services.AddControllers();
            
            services.AddScoped<Services.TodoService>();
            services.AddDbContext<TodoDbContext>((options) =>
            {
                options.UseSqlServer(Configuration.GetDatabaseConnection());
            });
        }
        
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, TodoDbContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            context.Database.EnsureDeletedAsync();
            context.Database.EnsureCreatedAsync();

            app.UseRouting();

            app.UseHttpsRedirection();

            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                builder.AllowAnyOrigin();
            });

            app.UseAuthentication();

            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}