// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionDataOverrideBillOnAcceptanceBillFromLineStartsAt : StripeEntity<QuoteSubscriptionDataOverrideBillOnAcceptanceBillFromLineStartsAt>, IHasId
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
