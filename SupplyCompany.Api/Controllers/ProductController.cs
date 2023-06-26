using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace SupplyCompany.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase {
    private readonly IMediator _mediator;
    private readonly Mapper _mapper;
    public ProductController(IMediator mediator) {
        _mediator = mediator;
        _mapper = MappingConfiguration.InitializeAutoMapper();
    }
    [HttpPost("AddNew")]
    public async Task<ActionResult<Product>> Create([FromBody] CreateProductRequest request) {
        var Command = _mapper.Map<CreateProductCommand>(request);
        var response = await _mediator.Send(Command);
        return response;
    }
    [HttpPost("AddProductReview")]
    public async Task<ActionResult<ProductReview>> CreateReview([FromBody] CreateProductReviewRequest request) {
        var Command = _mapper.Map<CreateProductReviewCommand>(request);
        var response = await _mediator.Send(Command);
        return response;
    }
}
