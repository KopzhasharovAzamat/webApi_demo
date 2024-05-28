using MediatR;
using WebApi_demo.CQRS.Queries;
using WebApi_demo.Models;

namespace WebApi_demo.CQRS.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly ProductStore _productStore;
        public GetProductByIdQueryHandler(ProductStore productStore)
        {
            _productStore = productStore;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken) => await _productStore.GetProductByIdAsync(request.id);
    }
}
