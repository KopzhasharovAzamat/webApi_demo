using MediatR;
using WebApi_demo.CQRS.Commands;
using WebApi_demo.Models;

namespace WebApi_demo.CQRS.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly ProductStore _productStore;
        public AddProductCommandHandler(ProductStore productStore)
        {
            _productStore = productStore;
        }
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            int lastElementId = await _productStore.GetLastProductIdAsync();
            int newElementId = lastElementId + 1;
            Product product = new Product()
            {
                Id = newElementId,
                Name = request.Product.Name
            };
            await _productStore.AddProductAsync(product);
            return product;
        }
    }
}
