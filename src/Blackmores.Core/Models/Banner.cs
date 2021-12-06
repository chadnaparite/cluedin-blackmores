using Newtonsoft.Json;

namespace CluedIn.Crawling.Blackmores.Core.Models
{
    public class Banner 
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string DimKey { get; set; }
        public string Code { get; set; }
        public string SourceRegion { get; set; }
        public string SourceProvider { get; set; }
        public string DemandGroupCode { get; set; }
    }
}
