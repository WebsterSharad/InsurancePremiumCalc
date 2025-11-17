using InsurancePremiumCalc.Application.Interfaces;
using InsurancePremiumCalc.Domain.DTO_s;
using InsurancePremiumCalc.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
