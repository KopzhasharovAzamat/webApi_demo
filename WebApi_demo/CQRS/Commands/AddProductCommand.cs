using MediatR;
using WebApi_demo.Models;

namespace WebApi_demo.CQRS.Commands
{
    public record AddProductCommand(Product Product) : IRequest<Product>;
}
