using App.Business.Abstract;
using App.Core.Utilities.Extensions;
using App.Entities.Concrete;
using App.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Web.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    IAbilityService _abiltiyService;

    public HomeController(ILogger<HomeController> logger, IAbilityService abilityService)
    {
      _logger = logger;
      _abiltiyService = abilityService;
    }

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }
    [HttpGet]
    public IActionResult Add()
    {
      return View();
    }
    [HttpPost, ActionName("Add")]
    public IActionResult AddAbility(Ability ability)
    {
      if (ability == null)
      {
        return RedirectToAction("Index");
      }

      var validationResult = _abiltiyService.Validate(ability);
      if (validationResult.IsValid == false)
      {
        validationResult.AddToModelState(ModelState);
        return View(ability);
      }

      var result = _abiltiyService.Add(ability);
      if (result.Success == false)
      {
        return RedirectToAction("Index");
      }
      _abiltiyService.Save();
      return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}