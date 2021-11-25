using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Blackmores.Core.Constants;

namespace CluedIn.Crawling.Blackmores.Vocabularies
{
    public class  DemandGroupVocabulary : SimpleVocabulary
    {
        public  DemandGroupVocabulary()
        {
            VocabularyName = "Blackmores DemandGroup"; 
            KeyPrefix      = "blackmores.demandgroup"; 
            KeySeparator   = ".";
            Grouping       = BlackmoresEntities.DemandGroup; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Blackmores DemandGroup Details", group =>
            {
                DemandGroupName = group.Add(new VocabularyKey("DemandGroupName", "Demand Group Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimDemandGroupSk = group.Add(new VocabularyKey("DimDemandGroupSk", "Dim Demand Group SK", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandGroupNameTpm = group.Add(new VocabularyKey("DemandGroupNameTpm", "Demand Group Name TPM", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Region = group.Add(new VocabularyKey("Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessUnit = group.Add(new VocabularyKey("BusinessUnit", "Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });
        }

        public VocabularyKey DemandGroupName { get; private set; }
        public VocabularyKey DimDemandGroupSk { get; private set; }
        public VocabularyKey DemandGroupNameTpm { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey BusinessUnit { get; private set; }
    }
}
