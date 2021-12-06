using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Blackmores.Core.Constants;
using CluedIn.DataStore.Document.Models;
using CluedIn.RelatedEntities;
using Microsoft.Extensions.Logging;

namespace CluedIn.Provider.Blackmores.SuggestedSearches
{
    public class BannerRelatedEntities : IRelatedEntitiesProvider
    {
        public IEnumerable<SuggestedSearch> GetRelatedEntitiesSearches(ExecutionContext context, Entity entity)
        {
            var Log = context.Log;

            Log.LogInformation($"[Blackmores - Related Entities] CustomerRelatedEntitiesProvider.GetRelatedEntitiesSearches({context}, {entity})");

            if (entity.Type != BlackmoresEntities.Banner)
            {
                Log.LogInformation("[Blackmores - Related Entities] Entity is not a Banner - nothing to suggest");

                return new SuggestedSearch[0];
            }

            var searches = new List<SuggestedSearch>();


            if (RelatedEntitiesUtility.CypherFluentQueriesCount("{{RELATIONSHIP}} for {{ENTITY}} of type {{TYPE}}", string.Format("{0},{1},{2}", EntityEdgeType.MemberOf, entity.Id.ToString(), BlackmoresEntities.DemandGroup), context) > 0)
            {
                searches.Add(new SuggestedSearch
                {
                    DisplayName = "Demand Group's List",
                    Id = entity.Id.ToString(),
                    SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} of type {{TYPE}}",
                    Tokens = string.Format("{0},{1},{2}", EntityEdgeType.MemberOf, entity.Id.ToString(), BlackmoresEntities.DemandGroup),
                    Type = "List"
                });
            }

            return searches;
        }
    }
}
