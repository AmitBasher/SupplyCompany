using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace SupplyCompany.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase {
    private readonly IMediator _mediator;
    private readonly Mapper _mapper;
    public CustomerController(IMediator mediator) {
        _mediator = mediator;
        _mapper = MappingConfiguration.InitializeAutoMapper();
    }
    [HttpPost]
    public async Task<ActionResult<Customer?>> CreateCustomer([FromBody] CreateCustomerRequest request) {
        var mapped = _mapper.Map<CreateCustomerCommand>(request);
        var response = await _mediator.Send(mapped);
        return Ok(response);
    }
}
