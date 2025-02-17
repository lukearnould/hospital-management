using HospitalManagement.Models;
using HospitalManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace HospitalManagement.Web.Controllers
{
    public class HomeController(HospitalRepository repository) : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Hospital> hospitals = await repository.Get();
            return View(hospitals);
        }

        public IActionResult Create()
        {
            return View("Edit", new Hospital());
        }

        public async Task<IActionResult> Edit(int id)
        {
            Hospital? hospital = await repository.Get(id);

            if (hospital == null)
            {
                Toast(ActionType.Error, "Hospital could not be retrieved.");
                return RedirectToAction("Index");
            }

            return View(hospital);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Hospital hospital)
        {
            if (!ModelState.IsValid)
            {
                Toast(ActionType.Error, "Please fill out all required fields.");
                return View("Edit", hospital);
            }

            int initialId = hospital.HospitalId;
            await repository.Save(hospital);

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
            await repository.Delete(hospitalId);
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
