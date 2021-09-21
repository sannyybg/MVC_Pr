using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using MVC_PersonManagmeng.ViewModels;
using MVC_PersonManagment.Service.Abstractions;
using MVC_PersonManagment.Service.Models;

namespace MVC_PersonManagmeng.Controllers
{
    public class PersonController : Controller
    {

        private readonly IPersonService _service;

        public PersonController(IPersonService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var result  = await _service.GetAllAsync();
            var personlist = result.Adapt<List<PersonViewModel>>();
            return View(personlist);
        }

        public IActionResult Create()
        {
            bool xx = false;
            if (TempData["Message"] != null)
            {
                xx = (bool)TempData["Message"];
            }
            ViewBag.isAdded = xx;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Address,Email,Age")] PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                var per = person.Adapt<PersonServiceModel>();
                await _service.AddAsync(per);
                //return RedirectToAction(nameof(Index));
                TempData["Message"] = true;
                return RedirectToAction();
            }
            return View(person);
        }

        
        public async Task<IActionResult> Details(int id)
        {

            var per = await _service.GetAsync(id);
            var personwithDetails = per.Adapt<PersonViewModel>();

            if (personwithDetails == null)
            {
                return NotFound();
            }
            else
            {
                return View(personwithDetails);
            }
            
        }

        public IActionResult About(int id)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Update(int id)
        {
            var per = await _service.GetAsync(id);
            var personwithDetails = per.Adapt<PersonViewModel>();
            return View(personwithDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Update([Bind("Id, FirstName,LastName,Address,Email,Age")] PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                var per = person.Adapt<PersonServiceModel>();
                await _service.UpdateAsync(per);
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
    }
}