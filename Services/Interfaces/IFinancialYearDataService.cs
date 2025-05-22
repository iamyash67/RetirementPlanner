using System.Data;
using RPT.Models;
using RPT.DTO;
namespace RPT.Services.Interfaces
{
    public interface IFinancialYearDataService
    {
        
        Task<FinancialYearData?> GetFinancialDataAsync(int goalId, int year, int month);
        Task<FinancialYearData?> CreateOrUpdateFinancialDataAsync(FinancialYearData data);
        Task<bool> RecordInvestmentAsync(int recordId);
        IDbTransaction BeginTransaction();
    }
}
