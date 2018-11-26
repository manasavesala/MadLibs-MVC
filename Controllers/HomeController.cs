using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
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
    [Route("/madlibsgenerator2")]
    public ActionResult MadLibsGenerator2(string noun, string place, string adjective, string noun2)
    {
      StoryVariable myStoryVariable = new StoryVariable();
      myStoryVariable.SetNoun(noun);
      myStoryVariable.SetPlace(place);
      myStoryVariable.SetAdjective(adjective);
      myStoryVariable.SetNoun2(noun2);
      return View(myStoryVariable);
    }

    [Route("/index")]
    public ActionResult Index() { return View(); }
    [Route("/form")]
    public ActionResult Form() { return View(); }
    [Route("/form2")]
    public ActionResult Form2() { return View(); }

  }
}
