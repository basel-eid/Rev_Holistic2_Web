using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rev_Holistic2_Web.Dtos.CustomerDtos;
using Rev_Holistic2_Web.Repos.CustomerRepos;

namespace Rev_Holistic2_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomer _repo;

        public CustomersController(ICustomer repo)
        {
            _repo = repo;
        }
        [HttpPost("Add")]
        public IActionResult Add(CustomerOnlyDto customerOnly)
        {
            _repo.AddCustomer(customerOnly);
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _repo.GetAll();
            return Ok(res);
        }
        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            try
            {
                var res = _repo.GetById(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
