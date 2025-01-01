using Rev_Holistic2_Web.Dtos.ProductsDto;

namespace Rev_Holistic2_Web.Repos.ProductRepos
{
    public interface IProduct
    {
        public void AddProduct(AddProductAndOrderDto addProduct);
    }
}
