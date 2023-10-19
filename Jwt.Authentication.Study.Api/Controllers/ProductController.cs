using Jwt.Authentication.Study.Api.Domain.Services.Interfaces;
using Jwt.Authentication.Study.Api.Middlewares;
using Microsoft.AspNetCore.Mvc;

namespace Jwt.Authentication.Study.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [AuthorizeJwt]
        public IActionResult Get()
        {
            var response = _productService.GetAll();
            return Ok(response);
        }
    }
}
