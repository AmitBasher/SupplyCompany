using Microsoft.AspNetCore.Mvc;
using SupplyCompany.Api.Common;
using SupplyCompany.Application.Suppliers.Commands.Create;
using SupplyCompany.Domain.Models.supplier;
using SupplyCompany.DTO.Supplier;

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
    public async Task<ActionResult<Supplier?>> CreateCustomer([FromBody] CreateSupplierRequest request) {
        var mapped = _mapper.Map<CreateSupplierCommand>(request);
        var response = await _mediator.Send(mapped);
        return Ok(response);
    }
}
