using HospitalManagement.Models;
using HospitalManagement.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HospitalManagement.Mvc.Controllers
{
    public class HomeController(ILogger<HomeController> _logger, Service service) : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel viewModel = new()
            {
                Hospitals = new()
                {
                    new()
                    {
                        Name = "NW OKC",
                        Description = "A beautiful hospital"
                    }
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Submit(Hospital hospital)
        {

            // await service.Save(hospital);
            return View();
        }

        public IActionResult Privacy()
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
