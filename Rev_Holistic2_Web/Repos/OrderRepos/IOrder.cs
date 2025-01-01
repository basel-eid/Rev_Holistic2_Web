using Rev_Holistic2_Web.Dtos.CustomerDtos;
using Rev_Holistic2_Web.Dtos.OrdersDto;

namespace Rev_Holistic2_Web.Repos.OrderRepos
{
    public interface IOrder
    {
        public void AddOreder(AddOrderAndCustomerDto addOrder);
        IEnumerable<OrderDto> GetAll();
        public void UpdateOrder(OrderOnlyDto orderOnlyDto,int id);
    }
}
