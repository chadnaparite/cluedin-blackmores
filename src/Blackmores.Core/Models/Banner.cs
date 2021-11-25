using Newtonsoft.Json;

namespace CluedIn.Crawling.Blackmores.Core.Models
{
    public class Banner 
    {
        [JsonProperty("BannerName")]
        public string BannerName { get; set; }

        [JsonProperty("BannerSK")]
        public string BannerSk { get; set; }

        [JsonProperty("DimBannerSK")]
        public string DimBannerSk { get; set; }

        [JsonProperty("BannerCode")]
        public string BannerCode { get; set; }

        [JsonProperty("SourceRegion")]
        public string SourceRegion { get; set; }

        [JsonProperty("SourceProvider")]
        public string SourceProvider { get; set; }
    }
}
