using apbd12_cw6.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd12_cw6.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _service;

    public CustomersController(ICustomerService _CustomerService)
    {
        _service = _CustomerService;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPatients(int id)
    {
        var customers = _service;
        if (customers == null)
            return NotFound();

        return Ok(customers);
    }
}
