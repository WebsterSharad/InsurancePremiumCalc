using InsurancePremiumCalc.Application.Interfaces;
using InsurancePremiumCalc.Domain.DTO_s;
using InsurancePremiumCalc.Presentation.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsurancePremiumCalc.Test
{
    public class PremiumControllerTests
    {
        [Fact]
        public async Task CalculatePrimium_ValidInputs_ReturnsExpectedPremium()
        {
            // Arrange
            var mockService = new Mock<IPremiumService>();
            var _logger = new Mock<ILogger<PremiumController>>();
            var controller = new PremiumController(_logger.Object,mockService.Object);

            int age = 30;
            decimal factor = 1.5m;
            decimal sumInsured = 200000m;
            decimal expectedPremium = 90000m;

            // Setup mock service behavior
            mockService
                .Setup(s => s.CalculateAsync(It.IsAny<PremiumRequest>()))
                .ReturnsAsync(expectedPremium);

            // Act
            var result = await controller.CalculatePrimium(age, factor, sumInsured);

            // Assert
            Assert.Equal(expectedPremium, result);

            mockService.Verify(s => s.CalculateAsync(
                It.Is<PremiumRequest>(r =>
                    r.Age == age &&
                    r.Factor == factor &&
                    r.SumInsured == sumInsured)),
                Times.Once);
        }
    }
}
