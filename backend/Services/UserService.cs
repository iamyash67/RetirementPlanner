using System.Threading.Tasks;
using RPT.Models;
using RPT.Services.Interfaces;
using RPT.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace RPT.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        private readonly ILogger<UserService> _logger;

        public UserService(
            IUserRepository repo,
            ILogger<UserService> logger)
        {
            _repo = repo;
            _logger = logger;
        }

        public async Task<Profile?> AuthenticateAsync(string username, string password)
        {
            _logger.LogInformation("Authentication attempt for user: {Username}", username);
            
            try
            {
                var profile = await _repo.ValidateCredentialsAsync(username, password);
                if (profile == null)
                {
                    _logger.LogWarning("Failed authentication attempt for user: {Username}", username);
                }
                return profile;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error authenticating user: {Username}", username);
                throw;
            }
        }
    }
}