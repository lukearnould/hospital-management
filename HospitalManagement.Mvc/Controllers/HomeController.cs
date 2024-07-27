using HospitalManagement.Models;
using HospitalManagement.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace HospitalManagement.Mvc.Controllers
{
    public class HomeController(ILogger<HomeController> _logger, Service service) : Controller
    {
        public async Task<IActionResult> Index()
        {
            HomeViewModel viewModel = new();
            viewModel.Hospitals = await service.Get();

            return View(viewModel);
        }

        public async Task<IActionResult> Create()
        {
            EditViewModel viewModel = new();

            return View("Edit", viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Hospital hospital = await service.Get(id);
            EditViewModel viewModel = new() { Hospital = hospital };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Hospital hospital)
        {
            int initialId = hospital.HospitalId;
            await service.Save(hospital);

            if (initialId == 0)
            {
                Toast(ActionType.Create, "Hospital created!");
            }
            else
            {
                Toast(ActionType.Edit, "Hospital edited.");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int hospitalId)
        {
            await service.Delete(hospitalId);

            Toast(ActionType.Delete, "Hospital deleted.");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private void Toast(ActionType actionType, string message)
        {
            string encoded = JsonSerializer.Serialize(new Toast(actionType, message));
            TempData.Add("Toast", encoded);
        }
    }
}
