using Newtonsoft.Json;

namespace CluedIn.Crawling.Blackmores.Core.Models
{
    public class DemandGroup 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string DimKey { get; set; }
        public string NameTpm { get; set; }
        public string Region { get; set; }
        public string BusinessUnit { get; set; }
    }
}
