using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.Blackmores.Core.Constants;

namespace CluedIn.Crawling.Blackmores.Vocabularies
{
    public class  CustomerVocabulary : SimpleVocabulary
    {
        public  CustomerVocabulary()
        {
            VocabularyName = "Blackmores Customer"; 
            KeyPrefix      = "blackmores.customer"; 
            KeySeparator   = ".";
            Grouping       = BlackmoresEntities.Customer; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("Blackmores Customer Details", group =>
            {
                Id = group.Add(new VocabularyKey("Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandGroup = group.Add(new VocabularyKey("DemandGroup", "Demand Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey("Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BannerKey = group.Add(new VocabularyKey("BannerKey", "Banner Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimKey = group.Add(new VocabularyKey("DimKey", "Dim Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteId = group.Add(new VocabularyKey("SiteId", "Site Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteName = group.Add(new VocabularyKey("SiteName", "Site Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey("Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceRegion = group.Add(new VocabularyKey("SourceRegion", "Source Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProvider = group.Add(new VocabularyKey("SourceProvider", "Source Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });
        }

        public VocabularyKey Id { get; private set; }
        public VocabularyKey DemandGroup { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BannerKey { get; private set; }
        public VocabularyKey DimKey { get; private set; }
        public VocabularyKey SiteId { get; private set; }
        public VocabularyKey SiteName { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey SourceRegion { get; private set; }
        public VocabularyKey SourceProvider { get; private set; }
        
    }
}
