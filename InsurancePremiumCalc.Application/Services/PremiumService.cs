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
    internal class PremiumService : IPremiumService
    {
        // Used Hardcoded insted call from DB as mentioned inDoc // Additional requirement: Database table design for the above (diagram or representation only, no need of scripts)
        private readonly Dictionary<string, decimal> _occupationRatings =
        new Dictionary<string, decimal>
    {
        {"Cleaner", 11.50m},
        {"Doctor", 1.50m},
        {"Author", 2.25m},
        {"Farmer", 31.75m},
        {"Mechanic", 31.75m},
        {"Florist", 11.50m},
        {"Other", 31.75m}
    };
        public decimal Calculate(PremiumRequest request)
        {           

            var factor = _occupationRatings[request.Occupation];

            return (request.SumInsured * factor * request.AgeNextBirthday) / 1000 * 12;            
        }


    }
}
