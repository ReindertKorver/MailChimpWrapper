using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimpWrapper.Models
{
    public class IndustryStats
    {
        [JsonPropertyName("open_rate")]
        public int OpenRate { get; set; }

        [JsonPropertyName("bounce_rate")]
        public int BounceRate { get; set; }

        [JsonPropertyName("click_rate")]
        public int ClickRate { get; set; }
    }
}