using MediatR;

namespace WebApiTemplate.Application.UseCases.Greeting
{
    public record TestQuery : IRequest<string> { }
}
