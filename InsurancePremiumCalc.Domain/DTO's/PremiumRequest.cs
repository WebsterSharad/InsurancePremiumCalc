using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePremiumCalc.Domain.DTO_s
{
    public class PremiumRequest
    {
        public string Name { get; set; }
        public int AgeNextBirthday { get; set; }
        public string DateOfBirth { get; set; } // mm/YYYY format
        public string Occupation { get; set; }
        public decimal SumInsured { get; set; }
    }
}
