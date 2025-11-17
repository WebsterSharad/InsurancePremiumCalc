using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsurancePremiumCalc.Domain.DTO_s;

namespace InsurancePremiumCalc.Application.Interfaces
{
    internal interface IPremiumService
    {
        public Task<decimal> Calculate(PremiumRequest request);
    }
}
