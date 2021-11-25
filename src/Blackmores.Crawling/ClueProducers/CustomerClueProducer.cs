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
            var clue = factory.Create(customerVocabulary.Grouping, input.CustomerId.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.CustomerName != null)
            {
                data.Name = input.CustomerName;
                data.DisplayName = input.CustomerName;
                data.Description = input.CustomerName;
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
            data.Properties[customerVocabulary.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[customerVocabulary.DemandGroup] = input.DemandGroup.PrintIfAvailable();
            data.Properties[customerVocabulary.CustomerName] = input.CustomerName.PrintIfAvailable();
            data.Properties[customerVocabulary.BannerSk] = input.BannerSk.PrintIfAvailable();
            data.Properties[customerVocabulary.DimCustomerSk] = input.DimCustomerSk.PrintIfAvailable();
            data.Properties[customerVocabulary.CustomerSiteId] = input.CustomerSiteId.PrintIfAvailable();
            data.Properties[customerVocabulary.CustomerSiteName] = input.CustomerSiteName.PrintIfAvailable();
            data.Properties[customerVocabulary.Channel] = input.Channel.PrintIfAvailable();
            data.Properties[customerVocabulary.DemandGroup] = input.DemandGroup.PrintIfAvailable();
            data.Properties[customerVocabulary.Country] = input.Country.PrintIfAvailable();
            data.Properties[customerVocabulary.SourceRegion] = input.SourceRegion.PrintIfAvailable();
            data.Properties[customerVocabulary.SourceProvider] = input.SourceProvider.PrintIfAvailable();

            return clue;
        }
    }
}
