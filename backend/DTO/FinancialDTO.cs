using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPT.DTO
{
    public class FinancialDTO
    {
        public int GoalId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal MonthlyInvestment { get; set; }
    }
}