using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Blackmores.Vocabularies;
using CluedIn.Crawling.Blackmores.Core.Models;

namespace CluedIn.Crawling.Blackmores.ClueProducers
{
    public class OrganizationClueProducer : BaseClueProducer<Organization>
    {
        private readonly IClueFactory factory;

        public OrganizationClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Organization input, Guid accountId)
        {
            var organizationVocabulary = new OrganizationVocabulary();
            var clue = factory.Create(organizationVocabulary.Grouping, input.Id.ToString(), accountId);
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
            //     data.Properties[organizationVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[organizationVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[organizationVocabulary.Id] = input.Id.PrintIfAvailable();
            data.Properties[organizationVocabulary.DemandGroup] = input.DemandGroup.PrintIfAvailable();
            data.Properties[organizationVocabulary.Name] = input.Name.PrintIfAvailable();
            data.Properties[organizationVocabulary.BannerKey] = input.BannerKey.PrintIfAvailable();
            data.Properties[organizationVocabulary.DimKey] = input.DimKey.PrintIfAvailable();
            data.Properties[organizationVocabulary.SiteId] = input.SiteId.PrintIfAvailable();
            data.Properties[organizationVocabulary.SiteName] = input.SiteName.PrintIfAvailable();
            data.Properties[organizationVocabulary.Channel] = input.Channel.PrintIfAvailable();
            data.Properties[organizationVocabulary.DemandGroup] = input.DemandGroup.PrintIfAvailable();
            data.Properties[organizationVocabulary.Country] = input.Country.PrintIfAvailable();
            data.Properties[organizationVocabulary.SourceRegion] = input.SourceRegion.PrintIfAvailable();
            data.Properties[organizationVocabulary.SourceProvider] = input.SourceProvider.PrintIfAvailable();
            data.Properties[organizationVocabulary.DemandGroupCode] = input.DemandGroupCode.PrintIfAvailable();

            return clue;
        }
    }
}
