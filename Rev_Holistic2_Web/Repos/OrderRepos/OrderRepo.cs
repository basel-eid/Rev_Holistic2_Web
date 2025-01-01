using Microsoft.EntityFrameworkCore;
using Rev_Holistic2_Web.Data;
using Rev_Holistic2_Web.Dtos.CustomerDtos;
using Rev_Holistic2_Web.Dtos.OrdersDto;
using Rev_Holistic2_Web.Dtos.ProductsDto;
using Rev_Holistic2_Web.Dtos.ShoppingDtos;
using Rev_Holistic2_Web.Models;

namespace Rev_Holistic2_Web.Repos.OrderRepos
{
    public class OrderRepo : IOrder
    {
        private readonly DataContext _context;
        public OrderRepo(DataContext context)
        {
            _context = context;
        }
        public void AddOreder(AddOrderAndCustomerDto addOrder)
        {
            Order order = new Order
            {
                Price = addOrder.Price,
                Customer = _context.Customers.FirstOrDefault(x => x.Id == addOrder.CustomerId
                ),
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public IEnumerable<OrderDto> GetAll()
        {
            var ord = _context.Orders.Include(x => x.Products).Include(x => x.Customer).ThenInclude(x => x.ShoppingCart).Select(x => new OrderDto
            {
                Price = x.Price,
                CustomerOnlyDto = new CustomerForOrderDto
                {
                    Contact = x.Customer.Contact,
                    Email = x.Customer.Email,
                    Name = x.Customer.Name,
                    ShoppingCartOnly = new ShoppingCartOnlyDto
                    {
                        NumberOfItems = x.Customer.ShoppingCart.NumberOfItems
                    }

                },
                productsOnlyDtos = x.Products.Select(x=> new ProductsOnlyDto
                {
                    Description = x.Description,
                    Name = x.Name,
                    StockQuantity = x.StockQuantity,
                }).ToList()
            }).ToList();
            return ord;
        }

       

        void IOrder.UpdateOrder(OrderOnlyDto orderOnlyDto, int id)
        {
            var ord = _context.Orders.FirstOrDefault(x => x.Id == id);
            if (ord != null)
            {
                ord.Price = orderOnlyDto.Price;
            }
            _context.Orders.Update(ord);
            _context.SaveChanges();
        }
    }
}
