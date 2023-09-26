using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet]
    [Route("/")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost]
    [Route("/story")]
    public ActionResult Story(string adjective, string food, string verb, string formId)
    {
      Inputs myInputs = new Inputs
      {
        Adjective = adjective,
        Food = food,
        Verb = verb
      };

      switch (formId)
      {
        case "taco":
          return View("story-taco", myInputs); // Use if you have a View named "story-taco.cshtml"
        case "gingerbread":
          return View("story-gingerbread", myInputs); // Use if you have a View named "story-gingerbread.cshtml"
        case "photoshoot":
          return View("story-photoshoot", myInputs); // Use if you have a View named "story-photoshoot.cshtml"
        case "pizza-party":
          return View("story-pizza-party", myInputs); // Use if you have a View named "story-pizza-party.cshtml"
        default:
          return NotFound(); // Return a 404 not found if the formId doesn't match any known cases
      }
    }
  }
}