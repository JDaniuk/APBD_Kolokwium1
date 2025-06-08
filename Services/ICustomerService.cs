using apbd12_cw6.DTO;

namespace apbd12_cw6.Services;

public interface ICustomerService
{
    Task<List<GetCustomerDTO>> GetCustomers(int id);
}