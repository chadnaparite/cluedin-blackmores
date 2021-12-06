using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.Blackmores.Vocabularies;
using CluedIn.Crawling.Blackmores.Core.Models;

namespace CluedIn.Crawling.Blackmores.ClueProducers
{
    public class DemandGroupClueProducer : BaseClueProducer<DemandGroup>
    {
        private readonly IClueFactory factory;

        public DemandGroupClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(DemandGroup input, Guid accountId)
        {
            var demandgroupVocabulary = new DemandGroupVocabulary();
            var clue = factory.Create(demandgroupVocabulary.Grouping, input.Name.ToString(), accountId);
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
            //     data.Properties[demandgroupVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[demandgroupVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[demandgroupVocabulary.Code] = input.Code.PrintIfAvailable();
            data.Properties[demandgroupVocabulary.Name] = input.Name.PrintIfAvailable();
            data.Properties[demandgroupVocabulary.DimKey] = input.DimKey.PrintIfAvailable();
            data.Properties[demandgroupVocabulary.NameTPM] = input.NameTpm.PrintIfAvailable();
            data.Properties[demandgroupVocabulary.Region] = input.Region.PrintIfAvailable();
            data.Properties[demandgroupVocabulary.BusinessUnit] = input.BusinessUnit.PrintIfAvailable();

            return clue;
        }
    }
}
