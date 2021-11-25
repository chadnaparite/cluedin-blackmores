using CluedIn.Core;
using CluedIn.Crawling.Blackmores.Core;

using ComponentHost;

namespace CluedIn.Crawling.Blackmores
{
    [Component(BlackmoresConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class BlackmoresCrawlerComponent : CrawlerComponentBase
    {
        public BlackmoresCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

