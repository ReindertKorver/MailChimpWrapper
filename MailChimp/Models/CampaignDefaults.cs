using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class CampaignDefaults
    {
        [JsonPropertyName("from_name")]
        public string FromName { get; set; }
        [JsonPropertyName("from_email")]
        public string FromEmail { get; set; }
        [JsonPropertyName("subject")]

        public string Subject { get; set; }
        [JsonPropertyName("language")]

        public string Language { get; set; }
    }
}
