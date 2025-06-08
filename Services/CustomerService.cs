using apbd12_cw6.Data;
using apbd12_cw6.DTO;

namespace apbd12_cw6.Services;

public class CustomerService : ICustomerService
{
    private readonly DatabaseContext _databaseContext;

    public CustomerService(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public async Task<List<GetCustomerDTO>> GetCustomers(int id)
    {
        var customer =  _databaseContext.Customers.Where(p => p.CustomerId == id)
            .Select(p =>
                new GetCustomerDTO()
                {
                    CustomerId = p.CustomerId,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                  

                }).ToList();
        
        return customer;
    }
}