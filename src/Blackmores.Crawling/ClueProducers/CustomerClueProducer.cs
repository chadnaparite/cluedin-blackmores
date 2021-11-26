using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Blackmores.Vocabularies;
using CluedIn.Crawling.Blackmores.Core.Models;

namespace CluedIn.Crawling.Blackmores.ClueProducers
{
    public class CustomerClueProducer : BaseClueProducer<Customer>
    {
        private readonly IClueFactory factory;

        public CustomerClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Customer input, Guid accountId)
        {
            var customerVocabulary = new CustomerVocabulary();
            var clue = factory.Create(customerVocabulary.Grouping, input.Id.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.Name != null)
            {
                data.Name = input.Name;
                data.DisplayName = input.Name;
                data.Description = input.Name;
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
            //     data.Properties[customerVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[customerVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[customerVocabulary.Id] = input.Id.PrintIfAvailable();
            data.Properties[customerVocabulary.DemandGroup] = input.DemandGroup.PrintIfAvailable();
            data.Properties[customerVocabulary.Name] = input.Name.PrintIfAvailable();
            data.Properties[customerVocabulary.BannerKey] = input.BannerKey.PrintIfAvailable();
            data.Properties[customerVocabulary.DimKey] = input.DimKey.PrintIfAvailable();
            data.Properties[customerVocabulary.SiteId] = input.SiteId.PrintIfAvailable();
            data.Properties[customerVocabulary.SiteName] = input.SiteName.PrintIfAvailable();
            data.Properties[customerVocabulary.Channel] = input.Channel.PrintIfAvailable();
            data.Properties[customerVocabulary.DemandGroup] = input.DemandGroup.PrintIfAvailable();
            data.Properties[customerVocabulary.Country] = input.Country.PrintIfAvailable();
            data.Properties[customerVocabulary.SourceRegion] = input.SourceRegion.PrintIfAvailable();
            data.Properties[customerVocabulary.SourceProvider] = input.SourceProvider.PrintIfAvailable();

            return clue;
        }
    }
}
