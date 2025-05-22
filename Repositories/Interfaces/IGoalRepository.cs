using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPT.Models;
using RPT.DTO;
using System.Data;
namespace RPT.Repositories.Interfaces
{
    public interface IGoalRepository
    {
        Task<Goal?> GetByProfileIdAsync(int profileId);
        Task<bool> ExistsByProfileIdAsync(int profileId);
        Task<bool> ExistsByGoalIdAsync(int goalId);
        Task<bool> CreateAsync(GoalDTO goal);
        Task<int?> GetProfileIdByGoalIdAsync(int goalId);
        Task<Goal?> GetByGoalIdAsync(int goalId);
        Task<decimal?> GetUserProgressAsync(int goalId);
    }
}