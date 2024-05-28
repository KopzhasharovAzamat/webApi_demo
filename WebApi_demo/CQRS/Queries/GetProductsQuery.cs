using MediatR;
using WebApi_demo.Models;

namespace WebApi_demo.CQRS.Queries
{
    public record GetProductsQuery : IRequest<IEnumerable<Product>>;
}
