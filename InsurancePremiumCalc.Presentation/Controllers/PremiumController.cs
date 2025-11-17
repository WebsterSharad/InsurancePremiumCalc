using InsurancePremiumCalc.Application.Interfaces;
using InsurancePremiumCalc.Domain.DTO_s;
using InsurancePremiumCalc.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using System.Numerics;

namespace InsurancePremiumCalc.Presentation.Controllers
{
    public class PremiumController : Controller
    {
        private readonly ILogger<PremiumController> _logger;
        private readonly IPremiumService _premiumService;
        public PremiumController(ILogger<PremiumController> logger, IPremiumService premiumService)
        {
            _logger = logger;
            _premiumService = premiumService;
        }
        public IActionResult Index()
        {
            //var occupations = new List<(string Name, double value)>
            // {
            //     ("Cleaner (Light Manual)", 11.50),
            //     ("Doctor (Professional)", 1.5),
            //     ("Author (White Collar)", 2.25),
            //     ("Farmer (Heavy Manual)", 31.75),
            //     ("Mechanic (Heavy Manual)", 31.75),
            //     ("Florist (Light Manual)", 11.50),
            //     ("Other (Heavy Manual)", 31.75)
            // };

            //ViewBag.Occupations = occupations;

            return View();
        }
        [HttpPost]
        public async Task<decimal> CalculatePrimium( int Age, decimal Factor, decimal SumInsured)
        {
            var request = new PremiumRequest
            {
                Age = Age,
                Factor = Factor,
                SumInsured = SumInsured
            };

            return await _premiumService.CalculateAsync(request);           
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
