using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Blackmores.Core;
using CluedIn.Crawling.Blackmores.Infrastructure.Factories;

namespace CluedIn.Crawling.Blackmores
{
    public class BlackmoresCrawler : ICrawlerDataGenerator
    {
        private readonly IBlackmoresClientFactory clientFactory;
        public BlackmoresCrawler(IBlackmoresClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is BlackmoresCrawlJobData BlackmorescrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(BlackmorescrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
