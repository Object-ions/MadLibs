using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/")]
    // public ActionResult Letter()
    // {
    // MadLibs myMadLibs = new MadLibs();
    //   myMadLibs.Adjective = "Lina";
    //   myMadLibs.Food = "Lina";
    //   myMadLibs.Verb = "Lina";

    //   return View(myMadLibs);
    // }
    [Route("/")]
    public ActionResult Form() { return View(); }
    [Route("/story")]
    public ActionResult Story(string adjective, string food, string verb)
    {
      Inputs myInputs = new Inputs();
      myInputs.Adjective = adjective;
      myInputs.Food = food;
      myInputs.Verb = verb;
      return View(myInputs);
    }
  }
}