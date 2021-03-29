using MediatR;
using Microsoft.Extensions.DependencyInjection;
using WebApiTemplate.Application.UseCases.Greeting;

namespace WebApiTemplate.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services) =>
            services.AddTransient<IRequestHandler<IRequest<string>, string>, GreetingQueryHandler>();
    }
}
