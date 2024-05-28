using MediatR;
using WebApi_demo.CQRS.Queries;
using WebApi_demo.Models;

namespace WebApi_demo.CQRS.Handlers
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly ProductStore _productStore;

        public GetProductsQueryHandler(ProductStore productStore)
        {
            _productStore = productStore;
        }

        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _productStore.GetAllProductsAsync();
        }
    }
}
