using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using WebApiTemplate.Application.Extensions;

namespace WebApiTemplate.WebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddUseCases()
                    .AddSwaggerGen(options => 
                    {
                        options.SwaggerDoc("v01", new OpenApiInfo { Title = "API Doc", Version = "v0.1" });
                    })
                    .AddMediatR(typeof(Startup))
                    .AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting()
               .UseSwagger(options =>
               {
                   options.RouteTemplate = "docs/{documentName}/swagger.json";
               })
               .UseSwaggerUI(options =>
               {
                   options.RoutePrefix = "docs";
                   options.SwaggerEndpoint("v01/swagger.json", "API V1");
               })
               .UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
