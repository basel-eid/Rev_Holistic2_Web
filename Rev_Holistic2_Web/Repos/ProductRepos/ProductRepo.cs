using Rev_Holistic2_Web.Data;
using Rev_Holistic2_Web.Dtos.ProductsDto;
using Rev_Holistic2_Web.Models;

namespace Rev_Holistic2_Web.Repos.ProductRepos
{
    public class ProductRepo : IProduct
    {
        private readonly DataContext _context;
        public ProductRepo(DataContext context)
        {
            _context = context;
        }
        public void AddProduct(AddProductAndOrderDto addProduct)
        {
            Product product = new Product
            {
                Description = addProduct.Description,
                Name = addProduct.Description,
                StockQuantity = addProduct.StockQuantity,
                Order = _context.Orders.FirstOrDefault(x=> x.Id ==  addProduct.OrderId)
            };
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}
