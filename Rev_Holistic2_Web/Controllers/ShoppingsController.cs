using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rev_Holistic2_Web.Dtos.ProductsDto;
using Rev_Holistic2_Web.Dtos.ShoppingDtos;
using Rev_Holistic2_Web.Repos.OrderRepos;
using Rev_Holistic2_Web.Repos.ShoppingCartRepos;

namespace Rev_Holistic2_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingsController : ControllerBase
    {
        private readonly IShopping _repo;

        public ShoppingsController(IShopping repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add(AddShoppingAndCustomerDto add)
        {
            _repo.AddShopping(add);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return NoContent();
        }
    }
}
