using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace SupplyCompany.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase {
    private readonly IMediator _mediator;
    private readonly Mapper _mapper;
    public OrderController(IMediator mediator) {
        _mediator = mediator;
        _mapper = MappingConfiguration.InitializeAutoMapper();
    }
    [HttpPost]
    public async Task<ActionResult<Order?>> CreateOrder([FromBody] CreateOrderRequest request) {
        var mapped = _mapper.Map<CreateOrderCommand>(request);
        var response = await _mediator.Send(mapped);
        return Ok(response);
    }
}
