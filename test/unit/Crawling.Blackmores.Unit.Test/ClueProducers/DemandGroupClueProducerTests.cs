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
    public class DemandGroupClueProducerTests : BaseClueProducerTest<DemandGroup>
    {
        protected override BaseClueProducer<DemandGroup> Sut =>
            new DemandGroupClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => BlackmoresEntities.DemandGroup;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(DemandGroup demandgroup)
        {
            var clue = Sut.MakeClue(demandgroup, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
