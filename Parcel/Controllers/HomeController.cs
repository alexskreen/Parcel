using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/packages/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpGet("/packages")]
    public ActionResult ShowPackages()
    {
        List<Package> packages = Package.GetAll();
        return View(packages);
    }

    [HttpPost("/packages")]
    public ActionResult CreateForm(int height, int width, int weight, string to, string from)
    {
        Package myPackage = new Package(height, width, weight, to, from);
        int useThis = myPackage.GetVolume(myPackage);
        int finaCost = myPackage.CostToShip(myPackage);
        return RedirectToAction("ShowPackages");
    }
  }
}