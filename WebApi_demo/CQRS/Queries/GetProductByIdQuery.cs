using MediatR;
using WebApi_demo.Models;

namespace WebApi_demo.CQRS.Queries
{
    public record GetProductByIdQuery(int id) : IRequest<Product>;
}
