using Microsoft.EntityFrameworkCore;
using Rev_Holistic2_Web.Data;
using Rev_Holistic2_Web.Dtos.CustomerDtos;
using Rev_Holistic2_Web.Dtos.OrdersDto;
using Rev_Holistic2_Web.Dtos.ProductsDto;
using Rev_Holistic2_Web.Dtos.ShoppingDtos;
using Rev_Holistic2_Web.Models;

namespace Rev_Holistic2_Web.Repos.CustomerRepos
{
    public class CustomerRepo : ICustomer
    {
        private readonly DataContext _context;
        public CustomerRepo(DataContext context)
        {
            _context = context;
        }
        public void AddCustomer(CustomerOnlyDto customerOnly)
        {
            Customer cus = new Customer
            {
                Name = customerOnly.Name,
                Email = customerOnly.Email,
                Contact = customerOnly.Contact,
            };
            _context.Customers.Add(cus);
            _context.SaveChanges();
        }

        public IEnumerable<CustomerDto> GetAll()
        {
            var cus = _context.Customers.Include(x => x.ShoppingCart).Include(x => x.Orders).ThenInclude(x => x.Products).Select(x => new CustomerDto
            {
                Name = x.Name,
                Contact = x.Contact,
                Email = x.Email,
                ShoppingCartOnlyDto = new ShoppingCartOnlyDto
                {
                    NumberOfItems = x.ShoppingCart.NumberOfItems
                },
                orderForCustomerDtos = x.Orders.Select(x => new OrderForCustomerDto
                {
                    Price = x.Price,
                    ProductsOnly = x.Products.Select(v=> new ProductsOnlyDto
                    {
                        Name=v.Name,
                        Description=v.Description,
                        StockQuantity = v.StockQuantity,
                    }).ToList()
                }).ToList()
            }).ToList();
            return cus;
        }

        public CustomerDto GetById(int id)
        {
            var cus = _context.Customers.Include(x => x.ShoppingCart).Include(x => x.Orders).ThenInclude(x => x.Products).FirstOrDefault(x=> x.Id == id);
            if(cus != null)
            {
                return new CustomerDto
                {
                    Name = cus.Name,
                    Contact = cus.Contact,
                    Email = cus.Email,
                    orderForCustomerDtos = cus.Orders.Select(x => new OrderForCustomerDto
                    {
                        Price = x.Price,
                        ProductsOnly = x.Products.Select(v => new ProductsOnlyDto { Name = v.Name, Description = v.Description, StockQuantity = v.StockQuantity, }).ToList()
                    }).ToList(),
                    ShoppingCartOnlyDto = new ShoppingCartOnlyDto
                    {
                        NumberOfItems = cus.ShoppingCart.NumberOfItems
                    }

                };
            }
            else
            {
                throw new Exception("Error");
            }
        }
    }
}
