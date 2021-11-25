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
                CustomerId = group.Add(new VocabularyKey("CustomerId", "Customer ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DemandGroup = group.Add(new VocabularyKey("DemandGroup", "Demand Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerName = group.Add(new VocabularyKey("CustomerName", "Customer Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BannerSk = group.Add(new VocabularyKey("BannerSk", "Banner SK", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimCustomerSk = group.Add(new VocabularyKey("DimCustomerSk", "Dim Customer SK", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerSiteId = group.Add(new VocabularyKey("CustomerSiteId", "Customer Site ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerSiteName = group.Add(new VocabularyKey("CustomerSiteName", "Customer Site Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey("Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceRegion = group.Add(new VocabularyKey("SourceRegion", "Source Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceProvider = group.Add(new VocabularyKey("SourceProvider", "Source Provider", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                
            });
        }

        public VocabularyKey CustomerId { get; private set; }
        public VocabularyKey DemandGroup { get; private set; }
        public VocabularyKey CustomerName { get; private set; }
        public VocabularyKey BannerSk { get; private set; }
        public VocabularyKey DimCustomerSk { get; private set; }
        public VocabularyKey CustomerSiteId { get; private set; }
        public VocabularyKey CustomerSiteName { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey SourceRegion { get; private set; }
        public VocabularyKey SourceProvider { get; private set; }
        
    }
}
