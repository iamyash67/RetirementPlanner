using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPT.Models;
namespace RPT.Repositories.Interfaces
{
    public interface IFinancialYearDataRepo
    {
        Task<FinancialYearData?> GetByProfileAndYearAsync(int goalId, int year, int month);
        Task<FinancialYearData?> CreateOrUpdateAsync(FinancialYearData data);
        Task<bool> MarkAsInvestedAsync(int recordId);
    }
}
