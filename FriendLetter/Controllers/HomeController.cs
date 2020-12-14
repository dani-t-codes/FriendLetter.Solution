using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  { //inherit or extend fxnlty from ASP.NET Core's built-in Controller class imported w/ using stmt

    [Route("/hello")]
    public string Hello() { return "Hello friend!"; } //Hello() method represents a route

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend.";}

    [Route("/")]
    public ActionResult Letter()//ActionResult is a built-in MVC class that handles rendering views; View() is a built-in method from `Microsoft.AspNetCore.Mvc` namespace to return a view when route is invoked
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jasmine";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }
}