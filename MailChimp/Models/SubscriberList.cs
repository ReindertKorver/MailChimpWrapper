using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class SubscriberList
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("web_id")]
        public int WebId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }

        [JsonPropertyName("permission_reminder")]
        public string PermissionReminder { get; set; }

        [JsonPropertyName("use_archive_bar")]
        public bool UseArchiveBar { get; set; }

        [JsonPropertyName("campaign_defaults")]
        public CampaignDefaults CampaignDefaults { get; set; }

        [JsonPropertyName("notify_on_subscribe")]
        public string NotifyOnSubscribe { get; set; }

        [JsonPropertyName("notify_on_unsubscribe")]
        public string NotifyOnUnsubscribe { get; set; }

        [JsonPropertyName("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonPropertyName("list_rating")]
        public int ListRating { get; set; }

        [JsonPropertyName("email_type_option")]
        public bool EmailTypeOption { get; set; }

        [JsonPropertyName("subscribe_url_short")]
        public string SubscribeUrlShort { get; set; }

        [JsonPropertyName("subscribe_url_int")]
        public string SubscribeUrlint { get; set; }

        [JsonPropertyName("beamer_address")]
        public string BeamerAddress { get; set; }

        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("double_optin")]
        public bool DoubleOptin { get; set; }

        [JsonPropertyName("has_welcome")]
        public bool HasWelcome { get; set; }

        [JsonPropertyName("marketing_permissions")]
        public bool MarketingPermissions { get; set; }

        [JsonPropertyName("modules")]
        public string[] Modules { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }

        [JsonPropertyName("_links")]
        public Link[] Links { get; set; }
    }
}
