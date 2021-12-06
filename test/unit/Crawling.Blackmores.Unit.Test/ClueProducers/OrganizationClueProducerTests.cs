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
    public class OrganizationClueProducerTests : BaseClueProducerTest<Organization>
    {
        protected override BaseClueProducer<Organization> Sut =>
            new OrganizationClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => EntityType.Organization;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Organization customer)
        {
            var clue = Sut.MakeClue(customer, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
