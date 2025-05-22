using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPT.Models;
namespace RPT.Services.Interfaces
{
    public interface IUserService
    {
        Task<Profile?> AuthenticateAsync(string username, string password);
    }
}