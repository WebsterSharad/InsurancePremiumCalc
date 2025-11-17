using InsurancePremiumCalc.Application.Interfaces;
using InsurancePremiumCalc.Domain.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsurancePremiumCalc.Application.Services;

namespace InsurancePremiumCalc.Test
{
    public class PremiumServiceTests
    {
        [Fact]
        public async Task CalculateAsync_ValidInput_ReturnsCorrectPremium()
        {
            // Arrange
            var service = new PremiumService();

            var request = new PremiumRequest
            {
                SumInsured = 100000m,
                Factor = 1.2m,
                Age = 30
            };

            // Expected calculation:
            // (100000 * 1.2 * 30) / 1000 * 12
            // = (3,600,000 / 1000) * 12
            // = 3600 * 12
            // = 43,200
            decimal expected = 43200m;

            // Act
            var result = await service.CalculateAsync(request);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
