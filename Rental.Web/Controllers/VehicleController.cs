using Microsoft.AspNetCore.Mvc;
using Rental.Data.Models;
using Rental.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental.Web.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            var repo = new VehicleRepository();
            var vehicles = repo.Get();
            return View(vehicles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Vehicle newVehicle)
        {
            if (ModelState.IsValid)
            {
                var repo = new VehicleRepository();
                repo.Add(newVehicle);
                return RedirectToAction(nameof(Index));
            }
            return View(newVehicle);
        }

        public IActionResult Edit(int id)
        {
            var repo = new VehicleRepository();
            var vehicle = repo.Get(id);
            return View(vehicle);
        }

        [HttpPost]
        public IActionResult Edit(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                var repo = new VehicleRepository();
                repo.Update(vehicle);
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        public IActionResult Delete(int id)
        {
            var repo = new VehicleRepository();
            var vehicle = repo.Get(id);
            return View(vehicle);
        }

        [HttpPost]
        public IActionResult Delete(Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                var repo = new VehicleRepository();
                repo.Delete(vehicle);
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }
    }
}

