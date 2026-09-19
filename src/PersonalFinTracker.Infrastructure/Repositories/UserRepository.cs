using PersonalFinTracker.Application.Interfaces;
using PersonalFinTracker.Domain.Entities;
using PersonalFinTracker.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinTracker.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FinTrackerDbContext _context;

        public UserRepository(FinTrackerDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
