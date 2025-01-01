using Rev_Holistic2_Web.Dtos.CustomerDtos;

namespace Rev_Holistic2_Web.Repos.CustomerRepos
{
    public interface ICustomer
    {
        public void AddCustomer(CustomerOnlyDto customerOnly);
        IEnumerable<CustomerDto> GetAll();
        CustomerDto GetById(int id);
    }
}
