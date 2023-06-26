using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SupplyCompany.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class AuthenticationController : ControllerBase {
    private readonly IMediator _mediator;
    private readonly Mapper _mapper;
    public AuthenticationController(IMediator mediator) {
        _mediator = mediator;
        _mapper = MappingConfiguration.InitializeAutoMapper();
    }
    [HttpPost("Register")]
    public async Task<ActionResult<AuthenticationResult>> Register([FromBody] RegisterRequest request) {
        var Command = _mapper.Map<RegisterCommand>(request);
        var response = await _mediator.Send(Command);
        return response;
    }
    [HttpPost("Login")]
    public async Task<ActionResult<AuthenticationResult>> Login([FromBody] LoginRequest request) {
        var Command = _mapper.Map<LoginCommand>(request);
        var response = await _mediator.Send(Command);
        return response;
    }
    //[HttpPost("Modify")]
    //public async Task<ActionResult<AuthenticationResult>> Modify([FromBody]ModifyRequest request) {

    //    var response = await _mediator.Send(new ModifyCommand(request.Token,request.FirstName,request.LastName,request.Email, request.Password));
    //    return response;
    //}
}