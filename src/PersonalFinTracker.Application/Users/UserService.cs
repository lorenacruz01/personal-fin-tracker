using PersonalFinTracker.Application.Interfaces;
using PersonalFinTracker.Domain.Entities;

namespace PersonalFinTracker.Application.Users
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> CreateAsync(string name, string email)
        {
            var user = new User(name, email);

            await _userRepository.AddAsync(user);

            return user.Id;
        }
    }
}
