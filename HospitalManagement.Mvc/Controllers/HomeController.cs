using HospitalManagement.Models;
using HospitalManagement.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace HospitalManagement.Mvc.Controllers
{
    public class HomeController(ILogger<HomeController> _logger, Service service) : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel viewModel = new()
            {
                Hospitals = [
                    new()
                    {
                        Name = "NW OKC",
                        Description = "A beautiful hospital test A beautiful hospital test A beautiful hospital test A beautiful hospital test A beautiful hospital test ",
                        Color = "#ff0808"
                    },
                    new() {
                        Name = "SW OKC",
                        Description = "A more beautiful hospital",
                        Color = "#635b59"
                    },
                                        new()
                    {
                        Name = "NW OKC",
                        Description = "A beautiful hospital",
                        Color = "#496c2a"
                    },
                                        new()
                    {
                        Name = "NW OKC",
                        Description = "A beautiful hospital",
                        Color = "#496c2a"
                    },
                                        new()
                    {
                        Name = "NW OKC",
                        Description = "A beautiful hospital",
                        Color = "#0a0081"
                    },
                ]
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            // Hospital hospital = await service.Get(id);
            EditViewModel viewModel = new() { /*Hospital = hospital*/ };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Hospital hospital)
        {
            // await service.Save(hospital);
            TempData.Add("Toast", "Hospital " + (hospital.HospitalId == 0 ? "created!" : "updated!"));

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int hospitalId)
        {
            // await service.Delete(hospitalId);

            TempData.Add("Toast", "Hospital was deleted");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
