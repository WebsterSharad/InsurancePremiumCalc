using InsurancePremiumCalc.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InsurancePremiumCalc.Presentation.Controllers
{
    public class PremiumController : Controller
    {
        private readonly ILogger<PremiumController> _logger;

        public PremiumController(ILogger<PremiumController> logger)
        {
            _logger = logger;
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
