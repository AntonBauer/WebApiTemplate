using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiTemplate.Application.UseCases.Greeting
{
    internal sealed class GreetingQueryHandler : IRequestHandler<IRequest<string>, string>
    {
        public Task<string> Handle(IRequest<string> request, CancellationToken cancellationToken) =>
            Task.FromResult("Hello there");
    }
}
