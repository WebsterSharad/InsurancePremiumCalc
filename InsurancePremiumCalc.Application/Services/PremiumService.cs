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

        private readonly HttpClient _httpClient;

        public PremiumService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal> Calculate(PremiumRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/premium/calculate", request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<decimal>();
        }


    }
}
