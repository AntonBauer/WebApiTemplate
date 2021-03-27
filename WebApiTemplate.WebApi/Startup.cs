using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using WebApiTemplate.Application.Extensions;

namespace WebApiTemplate.WebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddUseCases()
                    .AddMediatR(typeof(Startup))
                    .AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting()
               .UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
