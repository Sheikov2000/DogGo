using DogGo.Controllers;
using DogGo.Models;
using DogGo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DogGo.Controllers
{
    public class OwnersController : Controller
    {


        private readonly IOwnerRepository _ownerRepo;

// ASP.NET will give us an instance of our Owner Repository. This is called "Dependency Injection"
public OwnersController(IOwnerRepository ownerRepository)
{
    _ownerRepo = ownerRepository;
}


        //anything


// GET: HomeController1
// GET: Owners

public ActionResult Index()
        {
            List<Owner> owners = _ownerRepo.GetAllOwners();

            return View(owners);
        }

        // GET: HomeController1/Details/5
        // GET: Owners/Details/5
        public ActionResult Details(int id)
{
            Owner owner = _ownerRepo.GetOwnerById(id);

    if (owner == null)
    {
        return NotFound();
    }

    return View(owner);
}

// GET: HomeController1/Create
public ActionResult Create()
{
    return View();
}

// POST: HomeController1/Create
[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(IFormCollection collection)
{
    try
    {
        return RedirectToAction(nameof(Index));
    }
    catch
    {
        return View();
    }
}

// GET: HomeController1/Edit/5
public ActionResult Edit(int id)
{
    return View();
}

// POST: HomeController1/Edit/5
[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Edit(int id, IFormCollection collection)
{
    try
    {
        return RedirectToAction(nameof(Index));
    }
    catch
    {
        return View();
    }
}

// GET: HomeController1/Delete/5
public ActionResult Delete(int id)
{
    return View();
}

// POST: HomeController1/Delete/5
[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Delete(int id, IFormCollection collection)
{
    try
    {
        return RedirectToAction(nameof(Index));
    }
    catch
    {
        return View();
    }

}


}


}

