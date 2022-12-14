using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/parcel")]
    public ActionResult Index()
    {     
      return View();
    }

    [HttpGet("/parcel/new")]
    public ActionResult CreateParcel()
    {            
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(int weigth, int heigth, int length, int width)
    {      
      Parcel newParcel = new Parcel (weigth, width, heigth, length);
      return View("Index", newParcel);
    }

  }
}