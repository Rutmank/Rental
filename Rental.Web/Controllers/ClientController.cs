using Microsoft.AspNetCore.Mvc;
using Rental.Data.Models;
using Rental.Data.Repositories;
using System;

namespace Rental.Web.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            var repo = new ClientRepository();
            var clients = repo.Get();
            return View(clients);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Client newClient)
        {
            if (ModelState.IsValid)
            {
                if (newClient.BirthDate.HasValue && newClient.BirthDate > System.DateTime.Now)
                {
                    ModelState.AddModelError(nameof(Client.BirthDate), "Birth Date must be in the past.");
                    return View(newClient);
                }

                var repo = new ClientRepository();
                repo.Add(newClient);
                return RedirectToAction(nameof(Index));
            }
            return View(newClient);
        }

        public IActionResult Edit(int id)
        {
            var repo = new ClientRepository();
            var client = repo.Get(id);
            return View(client);
        }

        [HttpPost]
        public IActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {
                var repo = new ClientRepository();
                repo.Update(client);
                return RedirectToAction(nameof(Index));
            }
            return View(client);
        }

        public static int? GetAge(DateTime? birhDate)
        {
            if (!birhDate.HasValue)
            {
                return null;
            }

            return (int)(DateTime.Now - birhDate.Value).TotalDays / 365;
        }
    }
}
