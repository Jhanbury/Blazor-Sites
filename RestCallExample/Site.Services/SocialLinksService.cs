using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Site.Core;

namespace Site.Services
{
  public class SocialLinksService : ISocialLinkService
  {
    private readonly Settings _settings;

    public SocialLinksService(Settings settings)
    {
      _settings = settings;
    }

    public async Task<IEnumerable<SocialLinkDto>> GetSocialLinks(int userId)
    {
      try
      {
        var client = new HttpClient();
        var baseUrl = _settings.APIUrl;
        var response = await client.GetAsync($"{baseUrl}/api/userinfo/{userId}/socialmediaaccounts");
        if (response.IsSuccessStatusCode)
        {
          var data = await response.Content.ReadAsStringAsync();
          return JsonConvert.DeserializeObject<IEnumerable<SocialLinkDto>>(data);
        }
        else
        {
          return Enumerable.Empty<SocialLinkDto>();
        }
      }
      catch (Exception e)
      {
        return Enumerable.Empty<SocialLinkDto>();
      }
    }
  }
}
