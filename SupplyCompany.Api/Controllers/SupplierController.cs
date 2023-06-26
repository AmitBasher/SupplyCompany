using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SupplyCompany.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SupplierController : ControllerBase {
    private readonly IMediator _mediator;
    private readonly Mapper _mapper;
    public SupplierController(IMediator mediator) {
        _mediator = mediator;
        _mapper = MappingConfiguration.InitializeAutoMapper();
    }
    [HttpPost]
    public async Task<ActionResult<Supplier?>> CreateSupplier([FromBody] CreateSupplierRequest request){
        var mapped = _mapper.Map<CreateSupplierCommand>(request);
        var response = await _mediator.Send(mapped);
        return Ok(response);
    }
    [HttpGet]
    public async Task<ActionResult<Supplier?>> GetSuppliers([FromServices] ISupplierRepository rep){
        //var mapped = _mapper.Map<CreateSupplierCommand>(request);
        //var response = await _mediator.Send(mapped);
        var s = await rep.GetSuppliers();
        return Ok(s);
    }
    [HttpPost("SupplierReview")]
    public async Task<ActionResult<SupplierReview?>> CreateSupplierReview([FromBody] CreateSupplierReviewRequest request){
        var mapped = _mapper.Map<CreateSupplierReviewCommand>(request);
        var response = await _mediator.Send(mapped);
        return Ok(response);
    }
}
