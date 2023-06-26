using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace SupplyCompany.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SupplyRequestController : ControllerBase {
    private readonly IMediator _mediator;
    private readonly Mapper _mapper;
    public SupplyRequestController(IMediator mediator) {
        _mediator = mediator;
        _mapper = MappingConfiguration.InitializeAutoMapper();
    }
    [HttpPost]
    public async Task<ActionResult<SupplyRequest?>> CreateSupplyRequest([FromBody] CreateSupplyRequestRequest request) {
        var mapped = _mapper.Map<CreateSupplyRequestCommand>(request);
        var response = await _mediator.Send(mapped);
        return Ok(response);
    }
}
