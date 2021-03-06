namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SubscriptionItemOptions : IHasId, INestedOptions, IHasMetadata
    {
        /// <summary>
        /// SubscriptionItem to update. This parameter is only available on update.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Delete all usage for a given subscription item. Only allowed when <c>deleted</c> is set
        /// to true and the current plan’s <c>usage_type</c> is metered.  This parameter is only
        /// available on update.
        /// </summary>
        [JsonProperty("clear_usage")]
        public bool? ClearUsage { get; set; }

        /// <summary>
        /// Delete the specified item if set to true. This parameter is only available on update.
        /// </summary>
        [JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// A set of key/value pairs that you can attach to a charge object. It can be useful for
        /// storing additional information about the customer in a structured format. It's often a
        /// good idea to store an email address in metadata for tracking later.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Plan ID for this item.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan { get; set; }

        /// <summary>
        /// The ID of the price object.
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// Data used to generate a new price object inline.
        /// </summary>
        [JsonProperty("price_data")]
        public SubscriptionItemPriceDataOptions PriceData { get; set; }

        /// <summary>
        /// Quantity for this item.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        /// <summary>
        /// Ids of the tax rates to apply to this subscription item.
        /// </summary>
        [JsonProperty("tax_rates")]
        public List<string> TaxRates { get; set; }
    }
}
