using PersonalFinTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalFinTracker.Application.Interfaces
{
    public interface IUserRepository
    {
        Task AddAsync(User user);
    }
}
