using Microsoft.AspNetCore.Mvc;
using PlacesYouHaveBeen.Models;
using System.Collections.Generic;

namespace PlacesYouHaveBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/items/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string cityName, int length)
    {
      Place myPlace = new Place(cityName,length);
      return RedirectToAction("Index");
    }

    [HttpPost("/items/delete")]
    public ActionResult DeleteAll()
    {
      Place.ClearAll();
      return View();
    }

    [HttpGet("/items/{id}")]
    public ActionResult Show(int id)
    {
      Place foundPlace = Place.Find(id);
      return View(foundPlace);
    }
  }
}