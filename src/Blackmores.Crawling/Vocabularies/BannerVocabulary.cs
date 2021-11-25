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
                BannerName = group.Add(new VocabularyKey("BannerName", "Banner Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BannerSk = group.Add(new VocabularyKey("BannerSk", "Banner SK", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimBannerSk = group.Add(new VocabularyKey("DimBannerSk", "Dim Banner SK", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BannerCode = group.Add(new VocabularyKey("BannerCode", "Banner Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceRegion = group.Add(new VocabularyKey("SourceRegion", "Source Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProvider = group.Add(new VocabularyKey("SourceProvider", "Source Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });
        }

        public VocabularyKey BannerName { get; private set; }
        public VocabularyKey BannerSk { get; private set; }
        public VocabularyKey DimBannerSk { get; private set; }
        public VocabularyKey BannerCode { get; private set; }
        public VocabularyKey SourceRegion { get; private set; }
        public VocabularyKey SourceProvider { get; private set; }
    }
}
