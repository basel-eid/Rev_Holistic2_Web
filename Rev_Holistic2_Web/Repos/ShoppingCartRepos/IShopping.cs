using Rev_Holistic2_Web.Dtos.ShoppingDtos;

namespace Rev_Holistic2_Web.Repos.ShoppingCartRepos
{
    public interface IShopping
    {
        public void AddShopping(AddShoppingAndCustomerDto addShopping);
        public void Delete(int id);
    }
}
