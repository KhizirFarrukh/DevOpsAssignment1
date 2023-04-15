using k190359_A1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace k190359_A1.Controllers
{
    public class CertificationsController : Controller
    {
        private readonly ILogger<CertificationsController> _logger;

        public CertificationsController(ILogger<CertificationsController> logger)
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