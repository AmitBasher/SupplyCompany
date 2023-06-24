namespace SupplyCompany.Application.Users.Queries.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthenticationResult> {
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    public LoginCommandHandler(IUserRepository userRepository, IJwtTokenGenerator jwtTokenGenerator) {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public async Task<AuthenticationResult> Handle(LoginCommand request, CancellationToken cancellationToken) {
        var user = await _userRepository.GetUserByEmail(request.Email);
        if (user is null) {
            throw new Exception("Email doesnt exist");
        }
        if (user.Password != request.Password) {
            throw new Exception("Password is not correct");
        }
        var Token = _jwtTokenGenerator.GenerateToken(user);
        return new AuthenticationResult(user, Token);
    }
}