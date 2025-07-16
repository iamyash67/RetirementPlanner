using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPT.Models;
namespace RPT.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<Profile?> ValidateCredentialsAsync(string username, string password);

    }
}