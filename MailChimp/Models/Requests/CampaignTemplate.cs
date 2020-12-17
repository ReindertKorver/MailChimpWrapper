using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models.Requests
{
    public class CampaignTemplate
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("sections")]
        public Dictionary<string, string> Sections { get; set; }
    }
}