using Newtonsoft.Json;

namespace CluedIn.Crawling.Blackmores.Core.Models
{
    public class DemandGroup 
    {
        [JsonProperty("DemandGroupName")]
        public string DemandGroupName { get; set; }

        [JsonProperty("DimDemandGroupSK")]
        public string DimDemandGroupSk { get; set; }

        [JsonProperty("DemandGroupNameTPM")]
        public string DemandGroupNameTpm { get; set; }

        [JsonProperty("Region")]
        public string Region { get; set; }

        [JsonProperty("BusinessUnit")]
        public string BusinessUnit { get; set; }
    }
}
