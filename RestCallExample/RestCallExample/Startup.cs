using System.IO;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Site.Core;
using Site.Services;

namespace RestCallExample
{
  public class Startup
  {
    
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddScoped<ISocialLinkService, SocialLinksService>();
      services.AddSingleton(new Settings()
      {
        APIUrl = "<API_URL>"
      });
    }

    public void Configure(IComponentsApplicationBuilder app)
    {
      app.AddComponent<App>("app");
    }
  }
}
