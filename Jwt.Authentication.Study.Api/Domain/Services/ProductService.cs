using Jwt.Authentication.Study.Api.Domain.Entities;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;

namespace Jwt.Authentication.Study.Api.Domain.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAll()
            => new List<Product>
            {
                new Product(1, "Product 1", 2.12m),
                new Product(2, "Product 2", 5.59m),
                new Product(3, "Product 3", 12.13m),
                new Product(4, "Product 4", 15.88m),
                new Product(5, "Product 5", 41.54m)
            };
    }
}
