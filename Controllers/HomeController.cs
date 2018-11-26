using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/madlibsgenerator")]
    public ActionResult MadLibsGenerator(string name, string place, string adjective1)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetName(name);
      myLetterVariable.SetPlace(place);
      myLetterVariable.SetAdjective1(adjective1);
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }


  }
}
