using Jwt.Authentication.Study.Api.Domain.Entities;
using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;
using Jwt.Authentication.Study.Api.Tools.Extensions;
using System.Reflection;

namespace Jwt.Authentication.Study.Api.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IAuditService _auditService;

        public ProductService(IAuditService auditService)
        {
            _auditService = auditService;
        }

        public IEnumerable<Product> GetAll()
        {
            var products = new List<Product>
            {
                new Product(1, "Product 1", 2.12m),
                new Product(2, "Product 2", 5.59m),
                new Product(3, "Product 3", 12.13m),
                new Product(4, "Product 4", 15.88m),
                new Product(5, "Product 5", 41.54m)
            };

            _auditService.RecordEvent(typeof(ProductService).GetFullMethodName(nameof(GetAll)));

            return products;
        }

        
    }
}
