using InsurancePremiumCalc.Application.Interfaces;
using InsurancePremiumCalc.Domain.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePremiumCalc.Application.Services
{
    public class PremiumService : IPremiumService
    {
       
        public Task<decimal> CalculateAsync(PremiumRequest request)
        {  

            decimal response= (request.SumInsured * request.Factor * request.Age) / 1000 * 12;
            return Task.FromResult(response);
        }


    }
}
