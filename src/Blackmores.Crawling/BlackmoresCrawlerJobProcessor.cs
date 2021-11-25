using CluedIn.Crawling.Blackmores.Core;

namespace CluedIn.Crawling.Blackmores
{
    public class BlackmoresCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<BlackmoresCrawlJobData>
    {
        public BlackmoresCrawlerJobProcessor(BlackmoresCrawlerComponent component) : base(component)
        {
        }
    }
}
