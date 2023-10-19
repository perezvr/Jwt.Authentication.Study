using Jwt.Authentication.Study.Api.Domain.Entities;

namespace Jwt.Authentication.Study.Api.Domain.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
    }
}
