using Newtonsoft.Json;

namespace Site.Services
{
  public class SocialLinkDto
  {
    [JsonProperty("platform")]
    public string Platform { get; set; }
    [JsonProperty("accountUrl")]
    public string Url { get; set; }
  }
}
