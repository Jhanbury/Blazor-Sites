using System.Collections.Generic;
using System.Threading.Tasks;

namespace Site.Services
{
  public interface ISocialLinkService
  {
    Task<IEnumerable<SocialLinkDto>> GetSocialLinks(int userId);
  }
}
