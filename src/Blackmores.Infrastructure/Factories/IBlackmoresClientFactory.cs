using CluedIn.Crawling.Blackmores.Core;

namespace CluedIn.Crawling.Blackmores.Infrastructure.Factories
{
    public interface IBlackmoresClientFactory
    {
        BlackmoresClient CreateNew(BlackmoresCrawlJobData BlackmoresCrawlJobData);
    }
}
