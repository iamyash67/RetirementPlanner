using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPT.DTO
{
    public class GoalDTO
    {
        public int ProfileId { get; set; }
        public int CurrentAge { get; set; }
        public int RetirementAge { get; set; }
        public decimal TargetSavings { get; set; }
        public decimal CurrentSavings { get; set; }
    }
}