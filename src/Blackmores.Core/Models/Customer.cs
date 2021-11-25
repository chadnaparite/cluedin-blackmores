using Newtonsoft.Json;

namespace CluedIn.Crawling.Blackmores.Core.Models
{
    public class Customer 
    {
        [JsonProperty("CustomerID")]
        public string CustomerId { get; set; }

        [JsonProperty("DemandGroup")]
        public string DemandGroup { get; set; }

        [JsonProperty("CustomerName")]
        public string CustomerName { get; set; }

        [JsonProperty("BannerSK")]
        public string BannerSk { get; set; }

        [JsonProperty("DimCustomerSK")]
        public string DimCustomerSk { get; set; }

        [JsonProperty("CustomerSiteID")]
        public string CustomerSiteId { get; set; }

        [JsonProperty("CustomerSiteName")]
        public string CustomerSiteName { get; set; }

        [JsonProperty("Channel")]
        public string Channel { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("SourceRegion")]
        public string SourceRegion { get; set; }

        [JsonProperty("SourceProvider")]
        public string SourceProvider { get; set; }
    }
}
