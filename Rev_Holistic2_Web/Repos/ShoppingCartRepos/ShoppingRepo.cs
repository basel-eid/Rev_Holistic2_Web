using Microsoft.EntityFrameworkCore;
using Rev_Holistic2_Web.Data;
using Rev_Holistic2_Web.Dtos.ShoppingDtos;
using Rev_Holistic2_Web.Models;

namespace Rev_Holistic2_Web.Repos.ShoppingCartRepos
{
    public class ShoppingRepo : IShopping
    {
        private readonly DataContext _context;
        public ShoppingRepo(DataContext context)
        {
            _context = context;
        }

        public void AddShopping(AddShoppingAndCustomerDto addShopping)
        {
            ShoppingCart shopping = new ShoppingCart
            {
                 NumberOfItems = addShopping.NumberOfItems,
                 Customer = _context.Customers.FirstOrDefault(x=> x.Id == addShopping.CustomerId),
            };
            _context.ShoppingCarts.Add(shopping);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = _context.ShoppingCarts.FirstOrDefault(x=> x.Id ==id);
            if(s != null)
            {
                _context.ShoppingCarts.Remove(s);
                _context.SaveChanges();
            }
        }
    }
}
