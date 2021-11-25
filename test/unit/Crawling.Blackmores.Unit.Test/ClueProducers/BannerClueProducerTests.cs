using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.Blackmores.ClueProducers;
using CluedIn.Crawling.Blackmores.Core.Models;
using CluedIn.Crawling.Blackmores.Core.Constants;

namespace Crawling.Blackmores.Unit.Test.ClueProducers
{
    public class BannerClueProducerTests : BaseClueProducerTest<Banner>
    {
        protected override BaseClueProducer<Banner> Sut =>
            new BannerClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => BlackmoresEntities.Banner;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Banner banner)
        {
            var clue = Sut.MakeClue(banner, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
