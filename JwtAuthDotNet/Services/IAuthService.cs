using JwtAuthDotNet.Entities;
using JwtAuthDotNet.Model;

namespace JwtAuthDotNet.Services
{
    public interface IAuthService
    {
        Task<User?> RegisterAsync(UserDto request);
        Task<string?> LoginAsync(UserDto request);
    }
}
