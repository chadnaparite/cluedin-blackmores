using Newtonsoft.Json;

namespace CluedIn.Crawling.Blackmores.Core.Models
{
    public class Customer 
    {
        public string Id { get; set; }
        public string DemandGroup { get; set; }
        public string Name { get; set; }
        public string BannerKey { get; set; }
        public string DimKey { get; set; }
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public string Channel { get; set; }
        public string Country { get; set; }
        public string SourceRegion { get; set; }
        public string SourceProvider { get; set; }
        public string DemandGroupCode { get; set; }
    }
}
