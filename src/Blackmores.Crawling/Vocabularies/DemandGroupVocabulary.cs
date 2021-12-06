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
                Code = group.Add(new VocabularyKey("Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimKey = group.Add(new VocabularyKey("DimKey", "Dim Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameTPM = group.Add(new VocabularyKey("NameTpm", "Name TPM", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Region = group.Add(new VocabularyKey("Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessUnit = group.Add(new VocabularyKey("BusinessUnit", "Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey DimKey { get; private set; }
        public VocabularyKey NameTPM { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey BusinessUnit { get; private set; }
    }
}
