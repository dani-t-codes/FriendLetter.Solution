using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FriendLetter // same code from FriendLetter namespace in Startup.cs
{
  public class Program // same code from FriendLetter namespace in Startup.cs
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}