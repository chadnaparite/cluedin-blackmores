using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Blackmores.Vocabularies;
using CluedIn.Crawling.Blackmores.Core.Models;

namespace CluedIn.Crawling.Blackmores.ClueProducers
{
    public class BannerClueProducer : BaseClueProducer<Banner>
    {
        private readonly IClueFactory factory;

        public BannerClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Banner input, Guid accountId)
        {
            var bannerVocabulary = new BannerVocabulary();
            var clue = factory.Create(bannerVocabulary.Grouping, input.BannerName.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.BannerName != null)
            {
                data.Name = input.BannerName;
                data.DisplayName = input.BannerName;
                data.Description = input.BannerName;
            }

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }


            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[bannerVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[bannerVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
            // }


            //TODO: Example of PersonReference
            //  if (input.UpdatedBy != null)
            // {
            //     if (input.UpdatedByName != null)
            //     {
            //         var updatedPersonReference = new PersonReference(input.UpdatedByName, new EntityCode(EntityType.Person, BlackmoresConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            //     else
            //     {
            //         var updatedPersonReference = new PersonReference(new EntityCode(EntityType.Person, BlackmoresConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            // }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[bannerVocabulary.BannerName] = input.BannerName.PrintIfAvailable();
            data.Properties[bannerVocabulary.BannerSk] = input.BannerSk.PrintIfAvailable();
            data.Properties[bannerVocabulary.DimBannerSk] = input.DimBannerSk.PrintIfAvailable();
            data.Properties[bannerVocabulary.BannerCode] = input.BannerCode.PrintIfAvailable();
            data.Properties[bannerVocabulary.SourceRegion] = input.SourceRegion.PrintIfAvailable();
            data.Properties[bannerVocabulary.SourceProvider] = input.SourceProvider.PrintIfAvailable();

            return clue;
        }
    }
}
