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
        public string Subject { get; set; }
        public string Language { get; set; }
    }
}
