using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FriendLetter  //namespace
{
  public class Startup  //class declaration
  {
    public Startup(IHostingEnvironment env) //constructor to Startup class
    { //^^creates an iteration of Startup class containing spec. settings & vars
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

  public IConfigurationRoot Configuration { get; }  // part of adding custom configs ... more configuring below VV

  public void ConfigureServices(IServiceCollection services) // ConfigureServices() a built-in method used to set up an application's server ... also required
  {
    services.AddMvc();
  }

  public void Configure(IApplicationBuilder app)  //Configure() method is built-in & required ... called when the app launches; tells app how to handle server requests
  {
    app.UseMvc(routes =>  //tells app to use MVC framework to respond to HTTP reqs
    { //also sets up default routing for our app
      routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");//setting default route: Index action of Home controller - sets our homepage
    });

    app.Run(async (context) =>
    { // not required, but will test that our Configure() method is working properly
      await context.Response.WriteAsync("Hello World!");
    });
  }

  }
}