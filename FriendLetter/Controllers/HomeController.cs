using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  { //inherit or extend fxnlty from ASP.NET Core's built-in Controller class imported w/ using stmt

    public string Hello() { return "Hello friend!"; } //Hello() method represents a route

    public string Goodbye() { return "Goodbye friend.";}
    
  }
}