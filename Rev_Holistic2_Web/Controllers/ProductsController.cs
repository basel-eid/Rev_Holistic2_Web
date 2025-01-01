using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rev_Holistic2_Web.Dtos.OrdersDto;
using Rev_Holistic2_Web.Dtos.ProductsDto;
using Rev_Holistic2_Web.Repos.CustomerRepos;
using Rev_Holistic2_Web.Repos.ProductRepos;

namespace Rev_Holistic2_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProduct _repo;

        public ProductsController(IProduct repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add(AddProductAndOrderDto addOrder)
        {
            _repo.AddProduct(addOrder);
            return Ok();
        }
    }
}
