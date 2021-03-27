using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiTemplate.Application.UseCases.Greeting
{
    internal sealed class TestRequestHandler : IRequestHandler<TestQuery, string>
    {
        public Task<string> Handle(TestQuery request, CancellationToken cancellationToken) => Task.FromResult("Hello there");
    }
}
