using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Blackmores.Core.Constants;

namespace CluedIn.Crawling.Blackmores.Vocabularies
{
    public class  BannerVocabulary : SimpleVocabulary
    {
        public  BannerVocabulary()
        {
            VocabularyName = "Blackmores Banner"; 
            KeyPrefix      = "blackmores.banner"; 
            KeySeparator   = ".";
            Grouping       = BlackmoresEntities.Banner; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Blackmores Banner Details", group =>
            {
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey("Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimKey = group.Add(new VocabularyKey("DimKey", "Dim Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey("Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceRegion = group.Add(new VocabularyKey("SourceRegion", "Source Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProvider = group.Add(new VocabularyKey("SourceProvider", "Source Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey DimKey { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey SourceRegion { get; private set; }
        public VocabularyKey SourceProvider { get; private set; }
    }
}
