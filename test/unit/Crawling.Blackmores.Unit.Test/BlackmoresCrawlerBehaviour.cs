using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Blackmores;
using CluedIn.Crawling.Blackmores.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Blackmores.Unit.Test
{
    public class BlackmoresCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public BlackmoresCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IBlackmoresClientFactory>();

            _sut = new BlackmoresCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
