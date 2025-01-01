using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rev_Holistic2_Web.Dtos.OrdersDto;
using Rev_Holistic2_Web.Repos.CustomerRepos;
using Rev_Holistic2_Web.Repos.OrderRepos;

namespace Rev_Holistic2_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrder _repo;

        public OrdersController(IOrder repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Add(AddOrderAndCustomerDto addOrder)
        {
            _repo.AddOreder(addOrder);
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _repo.GetAll();
            return Ok(res);
        }
        [HttpPut("Update{id}")]
        public IActionResult Update(OrderOnlyDto account, int id)
        {
            _repo.UpdateOrder(account, id);
            return Ok();
        }
    }
}
