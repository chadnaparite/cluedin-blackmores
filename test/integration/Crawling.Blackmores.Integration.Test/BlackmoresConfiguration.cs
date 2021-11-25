using System.Collections.Generic;
using CluedIn.Crawling.Blackmores.Core;

namespace CluedIn.Crawling.Blackmores.Integration.Test
{
  public static class BlackmoresConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { BlackmoresConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
