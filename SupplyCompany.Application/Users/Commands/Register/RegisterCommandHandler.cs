namespace SupplyCompany.Application.Users.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResult> {
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    public RegisterCommandHandler(IUserRepository userRepository, 
                                  IJwtTokenGenerator jwtTokenGenerator){
        _userRepository=userRepository;
        _jwtTokenGenerator=jwtTokenGenerator;
    }
    public async Task<AuthenticationResult> Handle(RegisterCommand request, 
                                                   CancellationToken cancellationToken) {
        var temp = await _userRepository.GetUserByEmail(request.Email);
        if (temp is not null) {
            throw new Exception("The email already exist");
        }
        var user = User.Create(request.FirstName, 
                               request.LastName,
                               request.Email, 
                               request.Password);
        await _userRepository.AddUser(user);
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, token);
    }
}